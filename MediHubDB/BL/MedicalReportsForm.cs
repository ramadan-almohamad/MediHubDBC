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
    internal class MedicalReportsForm
    {

        public void InsertReport(int patientID, int doctorID, DateTime reportDate, string diagnosis, string medicalProcedure)
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

                param[2] = new SqlParameter("@ReportDate", SqlDbType.Date);
                param[2].Value = reportDate;

                param[3] = new SqlParameter("@Diagnosis", SqlDbType.NVarChar, 255);
                param[3].Value = diagnosis;

                param[4] = new SqlParameter("@MedicalProcedure", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[4].Value = medicalProcedure;

                dal.execute("sp_InsertMedicalReport", param); // تم تغيير اسم الإجراء المخزن إلى "sp_InsertMedicalReport" بناءً على اسم الجدول

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateReport(int reportID, int patientID, int doctorID, DateTime reportDate, string diagnosis, string medicalProcedure)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[6];

                param[0] = new SqlParameter("@ReportID", SqlDbType.Int);
                param[0].Value = reportID;

                param[1] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[1].Value = patientID;

                param[2] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[2].Value = doctorID;

                param[3] = new SqlParameter("@ReportDate", SqlDbType.Date);
                param[3].Value = reportDate;

                param[4] = new SqlParameter("@Diagnosis", SqlDbType.NVarChar, 255);
                param[4].Value = diagnosis;

                param[5] = new SqlParameter("@MedicalProcedure", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[5].Value = medicalProcedure;

                dal.execute("sp_UpdateMedicalReport", param); // اسم الإجراء المخزن لتحديث بيانات التقرير الطبي

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public DataTable GetAllReportsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllReports", null); // استبدل "sp_GetAllReports" بالاسم الصحيح للإجراء المخزن الذي يجلب معلومات التقارير
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات التقارير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void DeleteReport(int reportID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ReportID", SqlDbType.Int);
                param[0].Value = reportID;

                dal.execute("sp_DeleteReportById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteReportById"

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchSreport(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول المواعيد واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_Searchreport", param); // يجب استبدال "sp_SearchAppointments" باسم الإجراء المخزن الجديد الذي يبحث في جدول المواعيد
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
    }
}
