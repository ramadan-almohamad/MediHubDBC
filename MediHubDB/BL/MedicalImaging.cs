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
    internal class MedicalImaging
    {

        public void InsertMedicalImaging(int patientID, int doctorID, DateTime imageDate, string imageType, string imageDescription, string imageFile)
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

                param[2] = new SqlParameter("@ImageDate", SqlDbType.Date);
                param[2].Value = imageDate;

                param[3] = new SqlParameter("@ImageType", SqlDbType.NVarChar, 50);
                param[3].Value = imageType;

                param[4] = new SqlParameter("@ImageDescription", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[4].Value = imageDescription;

                param[5] = new SqlParameter("@ImageFile", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[5].Value = imageFile;

                dal.execute("sp_InsertMedicalImaging", param); // اسم الإجراء المخزن هو "sp_InsertMedicalImaging"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات الصور الشعاعية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteMedicalImaging(int imageID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@ImageID", SqlDbType.Int);
                param[0].Value = imageID;

                dal.execute("sp_DeleteMedicalImagingById", param); // اسم الإجراء المخزن للحذف

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetAllMedicalImagingData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                DataTable dt = dal.selectdata("sp_GetAllMedicalImaging", null);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات الصور الشعاعية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void UpdateMedicalImaging(int imageID, int patientID, int doctorID, DateTime imageDate, string imageType, string imageDescription, string imageFile)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@ImageID", SqlDbType.Int);
                param[0].Value = imageID;

                param[1] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[1].Value = patientID;

                param[2] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[2].Value = doctorID;

                param[3] = new SqlParameter("@ImageDate", SqlDbType.Date);
                param[3].Value = imageDate;

                param[4] = new SqlParameter("@ImageType", SqlDbType.NVarChar, 50);
                param[4].Value = imageType;

                param[5] = new SqlParameter("@ImageDescription", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[5].Value = imageDescription;

                param[6] = new SqlParameter("@ImageFile", SqlDbType.NVarChar, -1); // -1 يعني MAX
                param[6].Value = imageFile;

                dal.execute("sp_UpdateMedicalImaging", param); // اسم الإجراء المخزن لتحديث بيانات الأشعة الطبية

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات الأشعة الطبية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Searchimage(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول التحاليل الطبية واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_Searchimage", param); // يجب استبدال "sp_SearchLabTests" باسم الإجراء المخزن الجديد الذي يبحث في جدول التحاليل الطبية
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
