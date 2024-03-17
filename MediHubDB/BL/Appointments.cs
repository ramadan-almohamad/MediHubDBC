using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediHubDB.BL
{
    internal class Appointments
    {

        public DataTable GetAllAppointmentsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllAppointments", null); // اسم الإجراء المخزن لجلب بيانات المواعيد
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات المواعيد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable GetAppointmentsRegisteredToday()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAppointmentsRegisteredToday", null); // اسم الإجراء المخزن لجلب المواعيد المسجلة في تاريخ اليوم
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات المواعيد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable GetPatientsData()
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول المرضى واسترجاع النتائج في DataTable
                DataTable dt = dal.selectdata("sp_GetAllPatients", null); // يجب استبدال "sp_GetAllPatients" باسم الإجراء المخزن الذي يجلب معلومات المرضى
                dal.close();

                // إعادة الجدول الذي يحتوي على معلومات المرضى
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات المرضى: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // أو يمكنك التعامل مع الخطأ بالطريقة التي تراها مناسبة هنا
            }
        }
        public DataTable GetDoctorsData()
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول الأطباء واسترجاع النتائج في DataTable
                DataTable dt = dal.selectdata("sp_GetAllDoctors", null); // يجب استبدال "sp_GetAllDoctors" باسم الإجراء المخزن الذي يجلب معلومات الأطباء
                dal.close();

                // إعادة الجدول الذي يحتوي على معلومات الأطباء
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات الأطباء: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // أو يمكنك التعامل مع الخطأ بالطريقة التي تراها مناسبة هنا
            }
        }
        public void InsertAppointment(int patientID, int doctorID, DateTime appointmentDate, TimeSpan entryTime)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[0].Value = patientID;

                param[1] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[1].Value = doctorID;

                param[2] = new SqlParameter("@AppointmentDate", SqlDbType.Date);
                param[2].Value = appointmentDate;

                param[3] = new SqlParameter("@EntryTime", SqlDbType.Time);
                param[3].Value = entryTime;

                dal.execute("sp_InsertAppointment", param); // اسم الإجراء المخزن هو "sp_InsertAppointment"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات الموعد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteAppointment(int appointmentID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@AppointmentID", SqlDbType.Int);
                param[0].Value = appointmentID;

                dal.execute("sp_DeleteAppointmentById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteAppointmentById"

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchAppointments(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول المواعيد واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_SearchAppointments", param); // يجب استبدال "sp_SearchAppointments" باسم الإجراء المخزن الجديد الذي يبحث في جدول المواعيد
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
        public int GetPatientAppointmentsCount()
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء المخزن للحصول على عدد المرضى المسجلين في مواعيد اليوم
                DataTable dt = dal.selectdata("sp_GetPatientAppointmentsCount", null);

                // التحقق من أن هناك بيانات في الجدول قبل الوصول إلى القيمة
                if (dt != null && dt.Rows.Count > 0)
                {
                    // استرجاع القيمة من الجدول وتحويلها إلى int
                    int appointmentsCount = Convert.ToInt32(dt.Rows[0]["عدد المرضى المسجلين في مواعيد اليوم"]);
                    return appointmentsCount;
                }

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحصول على عدد المرضى: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // أو يمكنك التعامل مع الخطأ بالطريقة التي تراها مناسبة هنا
            }
        }
        public void UpdateAppointment(int appointmentID, int patientID, int doctorID, DateTime appointmentDate, TimeSpan entryTime)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@AppointmentID", SqlDbType.Int);
                param[0].Value = appointmentID;

                param[1] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[1].Value = patientID;

                param[2] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[2].Value = doctorID;

                param[3] = new SqlParameter("@AppointmentDate", SqlDbType.Date);
                param[3].Value = appointmentDate;

                param[4] = new SqlParameter("@EntryTime", SqlDbType.Time);
                param[4].Value = entryTime;

                dal.execute("sp_UpdateAppointment", param); // اسم الإجراء المخزن لتحديث بيانات الموعد

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات الموعد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BackupDatabase(string backupPath)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                // تحديد المعلمات وقيمها
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@BackupPath", SqlDbType.NVarChar, 255);
                param[0].Value = backupPath;

                // تنفيذ الإجراء المخزن لعملية النسخ الاحتياطي
                dal.execute("sp_BackupDatabase", param);

                // إغلاق الاتصال بقاعدة البيانات بعد الانتهاء
                dal.close();

                MessageBox.Show("تم إنشاء نسخة احتياطية بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // يتم عرض رسالة الخطأ إذا حدثت مشكلة أثناء عملية النسخ الاحتياطي
                MessageBox.Show("حدث خطأ أثناء عملية النسخ الاحتياطي: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void RestoreDatabase(string backupPath)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                // بناء استعلام الاستعادة مباشرة
                string restoreQuery = $"USE master; RESTORE DATABASE MediHubDB FROM DISK = '{backupPath}' WITH REPLACE;";

                // تنفيذ الاستعلام
                dal.execute1(restoreQuery);

                // إغلاق الاتصال بقاعدة البيانات بعد الانتهاء
                dal.close();

                MessageBox.Show("تم استعادة قاعدة البيانات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // يتم عرض رسالة الخطأ إذا حدثت مشكلة أثناء عملية الاستعادة
                MessageBox.Show("حدث خطأ أثناء عملية الاستعادة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
