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
    internal class Surgeries
    {


        public DataTable GetAllSurgeriesData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllSurgeries", null); // اسم الإجراء المخزن لجلب بيانات العمليات
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات العمليات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public DataTable GetAllSurgeriesDataToday()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllSurgeriesForToday", null); // اسم الإجراء المخزن لجلب التتبع المسجل في تاريخ اليوم
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات التتبع: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public int GetAllSurgeriesCountForToday()
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء المخزن للحصول على عدد المرضى الذين لديهم تتبع في التاريخ الحالي
                DataTable dt = dal.selectdata("sp_GetSurgeriesCountForToday", null);

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



        public void InsertSurgery(int patientID, int doctorID, int hospitalID, DateTime surgeryDate, TimeSpan surgeryTime, string surgeryType, string surgeryNotes)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[0].Value = patientID;

                param[1] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[1].Value = doctorID;

                param[2] = new SqlParameter("@HospitalID", SqlDbType.Int);
                param[2].Value = hospitalID;

                param[3] = new SqlParameter("@SurgeryDate", SqlDbType.Date);
                param[3].Value = surgeryDate;

                param[4] = new SqlParameter("@SurgeryTime", SqlDbType.Time);
                param[4].Value = surgeryTime;

                param[5] = new SqlParameter("@SurgeryType", SqlDbType.NVarChar, 50);
                param[5].Value = surgeryType;

                param[6] = new SqlParameter("@SurgeryNotes", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[6].Value = surgeryNotes;

                dal.execute("sp_InsertSurgery", param); // اسم الإجراء المخزن هو "sp_InsertSurgery"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات العملية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchSurgeries(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول المواعيد واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_SearchSurgeries", param); // يجب استبدال "sp_SearchAppointments" باسم الإجراء المخزن الجديد الذي يبحث في جدول المواعيد
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
        public void UpdateSurgery(int surgeryID, int patientID, int doctorID, int hospitalID, DateTime surgeryDate, TimeSpan surgeryTime, string surgeryType, string surgeryNotes)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[8];

                param[0] = new SqlParameter("@SurgeryID", SqlDbType.Int);
                param[0].Value = surgeryID;

                param[1] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[1].Value = patientID;

                param[2] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[2].Value = doctorID;

                param[3] = new SqlParameter("@HospitalID", SqlDbType.Int);
                param[3].Value = hospitalID;

                param[4] = new SqlParameter("@SurgeryDate", SqlDbType.Date);
                param[4].Value = surgeryDate;

                param[5] = new SqlParameter("@SurgeryTime", SqlDbType.Time);
                param[5].Value = surgeryTime;

                param[6] = new SqlParameter("@SurgeryType", SqlDbType.NVarChar, 50);
                param[6].Value = surgeryType;

                param[7] = new SqlParameter("@SurgeryNotes", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[7].Value = surgeryNotes;

                dal.execute("sp_UpdateSurgery", param); // اسم الإجراء المخزن لتحديث بيانات العملية

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات العملية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteSurgery(int surgeryID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@SurgeryID", SqlDbType.Int);
                param[0].Value = surgeryID;

                dal.execute("sp_DeleteSurgery", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteSurgery"

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
