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
    internal class Medication
    {

        public void InsertMedication(string medicationName, string type)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[2];

                param[0] = new SqlParameter("@MedicationName", SqlDbType.NVarChar, 50);
                param[0].Value = medicationName;

                param[1] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
                param[1].Value = type;

                dal.execute("sp_InsertMedication", param); // اسم الإجراء المخزن الخاص بإدخال الدواء

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات الدواء: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable GetAllMedicationsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllMedications", null); // اسم الإجراء المخزن هو "sp_GetAllMedications"
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات الأدوية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public void DeleteMedication(int medicationID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@MedicationID", SqlDbType.Int);
                param[0].Value = medicationID;

                dal.execute("sp_DeleteMedicationById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteMedicationById"

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
