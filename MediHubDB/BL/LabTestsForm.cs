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
    internal class LabTestsForm
    {

        public void InsertLabTest(int patientID, int doctorID, DateTime testDate, string testType, string testResults, string testFile)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[6];

                param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[0].Value = patientID;

                param[1] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[1].Value = doctorID;

                param[2] = new SqlParameter("@TestDate", SqlDbType.Date);
                param[2].Value = testDate;

                param[3] = new SqlParameter("@TestType", SqlDbType.NVarChar, 250);
                param[3].Value = testType;

                param[4] = new SqlParameter("@TestResults", SqlDbType.NVarChar, 50);
                param[4].Value = testResults;

                param[5] = new SqlParameter("@TestFile", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[5].Value = testFile;

                dal.execute("sp_InsertLabTest", param); // اسم الإجراء المخزن هو "sp_InsertLabTest"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات التحليل الطبي: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        public DataTable GetAllLabTestsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                DataTable dt = dal.selectdata("sp_GetAllLabTests", null);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات التحاليل الطبية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void DeleteLabTest(int testID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@TestID", SqlDbType.Int);
                param[0].Value = testID;

                dal.execute("sp_DeleteLabTestById", param); // اسم الإجراء المخزن للحذف

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchLabTests(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول التحاليل الطبية واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_SearchLabTests", param); // يجب استبدال "sp_SearchLabTests" باسم الإجراء المخزن الجديد الذي يبحث في جدول التحاليل الطبية
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

        public void UpdateLabTest(int testID, int patientID, int doctorID, DateTime testDate, string testType, string testResults, string testFile)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@TestID", SqlDbType.Int);
                param[0].Value = testID;

                param[1] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[1].Value = patientID;

                param[2] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[2].Value = doctorID;

                param[3] = new SqlParameter("@TestDate", SqlDbType.Date);
                param[3].Value = testDate;

                param[4] = new SqlParameter("@TestType", SqlDbType.NVarChar, 250);
                param[4].Value = testType;

                param[5] = new SqlParameter("@TestResults", SqlDbType.NVarChar, 50);
                param[5].Value = testResults;

                param[6] = new SqlParameter("@TestFile", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[6].Value = testFile;

                dal.execute("sp_UpdateLabTest", param); // اسم الإجراء المخزن لتحديث بيانات التحليل الطبي

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات التحليل الطبي: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
