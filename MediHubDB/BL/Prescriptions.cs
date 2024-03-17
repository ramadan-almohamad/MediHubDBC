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
    internal class Prescriptions
    {


        public void InsertPrescription(int patientID, int doctorID, DateTime prescriptionDate, string diagnosis)
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

                param[2] = new SqlParameter("@PrescriptionDate", SqlDbType.Date);
                param[2].Value = prescriptionDate;

                param[3] = new SqlParameter("@Diagnosis", SqlDbType.NVarChar, 255);
                param[3].Value = diagnosis;

                dal.execute("sp_InsertPrescription10", param); // تم تغيير اسم الإجراء المخزن إلى "sp_InsertPrescription" بناءً على اسم الجدول

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetAllPrescriptionsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllPrescriptions", null); // استبدل "sp_GetAllPrescriptions" بالاسم الصحيح للإجراء المخزن الذي يجلب معلومات الوصفات
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات الوصفات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable SearchPrescriptions(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول الوصفات واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_SearchPrescriptions", param); // يجب استبدال "sp_SearchPrescriptions" باسم الإجراء المخزن الجديد الذي يبحث في جدول الوصفات
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
        public void DeletePrescription(int prescriptionID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@PrescriptionID", SqlDbType.Int);
                param[0].Value = prescriptionID;

                dal.execute("sp_DeletePrescriptionById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeletePrescriptionById"

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdatePrescription(int prescriptionID, int patientID, int doctorID, DateTime prescriptionDate, string diagnosis)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[5];

                param[0] = new SqlParameter("@PrescriptionID", SqlDbType.Int);
                param[0].Value = prescriptionID;

                param[1] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[1].Value = patientID;

                param[2] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[2].Value = doctorID;

                param[3] = new SqlParameter("@PrescriptionDate", SqlDbType.Date);
                param[3].Value = prescriptionDate;

                param[4] = new SqlParameter("@Diagnosis", SqlDbType.NVarChar, 50);
                param[4].Value = diagnosis;

                dal.execute("sp_UpdatePrescription", param); // اسم الإجراء المخزن لتحديث بيانات الوصفة الطبية

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات الوصفة الطبية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
