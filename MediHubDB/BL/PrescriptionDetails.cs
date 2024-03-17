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
    internal class PrescriptionDetails
    {
        public DataTable GetAllPrescriptionDetailsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                DataTable dt = dal.selectdata("sp_GetAllPrescriptionDetails", null);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات تفاصيل الوصفات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void InsertPrescription(int prescriptionID, int medicationID, string dosage, string time, string beforeMeal, string duration, string notes)
        {
            try
            {
                // إنشاء كائن من فئة DataAccess في طبقة الوصول إلى البيانات
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                // تعريف مصفوفة من نوع SqlParameter لتمثيل المتغيرات في إجراء الإدخال
                SqlParameter[] param = new SqlParameter[7];

                // تعيين قيم المتغيرات
                param[0] = new SqlParameter("@PrescriptionID", SqlDbType.Int);
                param[0].Value = prescriptionID;

                param[1] = new SqlParameter("@MedicationID", SqlDbType.Int);
                param[1].Value = medicationID;

                param[2] = new SqlParameter("@Dosage", SqlDbType.NVarChar, 50);
                param[2].Value = dosage;

                param[3] = new SqlParameter("@Time", SqlDbType.NVarChar, 50);
                param[3].Value = time;

                param[4] = new SqlParameter("@BeforeMeal", SqlDbType.NVarChar, 50);
                param[4].Value = beforeMeal;

                param[5] = new SqlParameter("@Duration", SqlDbType.NVarChar, 50);
                param[5].Value = duration;

                param[6] = new SqlParameter("@Notes", SqlDbType.NVarChar, -1); // MAX في حالة nvarchar(MAX)
                param[6].Value = notes;

                // استدعاء إجراء المخزن لإدخال بيانات الوصفة في الجدول المحدد
                dal.execute("sp_InsertPrescription", param);

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات الوصفة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                dal.execute("sp_DeletePrescriptionDetailsById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeletePrescriptionDetailsById"

                dal.close();
            }
            catch (Exception ex)
            {
                // يمكنك إضافة رسالة خطأ هنا إذا حدث خطأ أثناء عملية الحذف
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public DataTable GetPrescriptionDetailsByPrescriptionID(int prescriptionID)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استخدام مصفوفة SqlParameter لتمرير قيمة رقم الوصفة
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@PrescriptionID", SqlDbType.Int);
                param[0].Value = prescriptionID;

                // استدعاء الدالة للحصول على تفاصيل الوصفة
                DataTable dt = dal.selectdata("sp_GetPrescriptionDetailsByPrescriptionID", param);
                dal.close();

                // إعادة الجدول الذي يحتوي على تفاصيل الوصفة
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات تفاصيل الوصفة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }




    }
}
