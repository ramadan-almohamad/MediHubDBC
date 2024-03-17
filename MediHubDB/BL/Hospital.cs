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
    internal class Hospital
    {

        public int InsertHospital(string hospitalName, string hospitalAddress, string contactNumber)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@HospitalName", SqlDbType.NVarChar, -1);
                param[0].Value = hospitalName;

                param[1] = new SqlParameter("@HospitalAddress", SqlDbType.NVarChar, -1);
                param[1].Value = hospitalAddress;

                param[2] = new SqlParameter("@ContactNumber", SqlDbType.NVarChar, -1);
                param[2].Value = contactNumber;

                dal.execute("sp_InsertHospital", param); // اسم الإجراء المخزن هو "sp_InsertHospital"

                dal.close();

                // لاحظ أن هذا الإجراء المخزن يقوم بإرجاع هوية المشفى المدرجة حديثًا
                // يمكنك استخدام هذه الهوية في حال كانت مطلوبة
                return 0; // أو يمكنك إرجاع قيمة أخرى تعبر عن نجاح العملية
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات المشفى: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // أو قيمة تعبيرية للخطأ
            }
        }
        public DataTable GetHospitalsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                DataTable dt = dal.selectdata("sp_GetAllHospitals", null);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات المشافى: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void DeleteHospital(int hospitalID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@HospitalID", SqlDbType.Int);
                param[0].Value = hospitalID;

                dal.execute("sp_DeleteHospitalById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteHospitalById"

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
