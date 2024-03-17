using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediHubDB.BL
{
    internal class RecoveryTrackingform
    {

        public void InsertRecoveryTracking(int patientID, int doctorID, DateTime recoveryDate, TimeSpan entryTime, string followUpComments)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[0].Value = patientID;

                param[1] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[1].Value = doctorID;

                param[2] = new SqlParameter("@RecoveryDate", SqlDbType.Date);
                param[2].Value = recoveryDate;

                param[3] = new SqlParameter("@EntryTime", SqlDbType.Time);
                param[3].Value = entryTime;

                param[4] = new SqlParameter("@FollowUpComments", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[4].Value = followUpComments;

                dal.execute("sp_InsertRecoveryTracking", param); // اسم الإجراء المخزن هو "sp_InsertRecoveryTracking"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات التتبع: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetAllRecoveryTrackingData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllRecoveryTracking", null); // اسم الإجراء المخزن لجلب بيانات التتبع
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات التتبع: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public DataTable GetRecoveryTrackingRegisteredToday()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetRecoveryTrackingForToday", null); // اسم الإجراء المخزن لجلب التتبع المسجل في تاريخ اليوم
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات التتبع: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public int GetPatientTrackingCountForToday()
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء المخزن للحصول على عدد المرضى الذين لديهم تتبع في التاريخ الحالي
                DataTable dt = dal.selectdata("sp_GetPatientTrackingCountForToday", null);

                // التحقق من أن هناك بيانات في الجدول قبل الوصول إلى القيمة
                if (dt != null && dt.Rows.Count > 0)
                {
                    // استرجاع القيمة من الجدول وتحويلها إلى int
                    int trackingCount = Convert.ToInt32(dt.Rows[0]["عدد المرضى الذين لديهم تتبع في التاريخ الحالي"]);
                    return trackingCount;
                }

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحصول على عدد المرضى: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // أو يمكنك التعامل مع الخطأ بالطريقة التي تراها مناسبة هنا
            }
        }
        public DataTable SearchRecoveryTracking(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول التتبع واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_SearchRecoveryTracking", param); // استبدال "sp_SearchRecoveryTracking" بالاسم الصحيح للإجراء المخزن
                dal.close();

                // إعادة الجدول الذي يحتوي على نتائج البحث
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // أو يمكنك التعامل مع الخطأ بالطريقة التي تراها مناسبة هنا
            }
        }
        public void DeleteRecoveryTrackingByAppointmentID(int appointmentID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@AppointmentID", SqlDbType.Int);
                param[0].Value = appointmentID;

                dal.execute("sp_DeleteRecoveryTrackingByAppointmentID", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteRecoveryTrackingByAppointmentID"

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateRecoveryTracking(int trackingID, int patientID, int doctorID, DateTime recoveryDate, TimeSpan entryTime, string followUpComments)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[6];

                param[0] = new SqlParameter("@TrackingID", SqlDbType.Int);
                param[0].Value = trackingID;

                param[1] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[1].Value = patientID;

                param[2] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[2].Value = doctorID;

                param[3] = new SqlParameter("@RecoveryDate", SqlDbType.Date);
                param[3].Value = recoveryDate;

                param[4] = new SqlParameter("@EntryTime", SqlDbType.Time);
                param[4].Value = entryTime;

                param[5] = new SqlParameter("@FollowUpComments", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[5].Value = followUpComments;

                dal.execute("sp_UpdateRecoveryTracking", param); // اسم الإجراء المخزن لتحديث بيانات تتبع الاسترداد

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات تتبع الاسترداد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
