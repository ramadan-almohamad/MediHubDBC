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
    internal class DoctorHandler
    {
        public DataTable GetDoctorsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllDoctors", null); // اسم الإجراء المخزن هو "sp_GetAllDoctors"
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات الأطباء: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public void InsertDoctor(string firstName, string lastName, string contactNumber, string licenseNumber, string clinicAddress, string specialization)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[6];

                param[0] = new SqlParameter("@firstName", SqlDbType.NVarChar, 50);
                param[0].Value = firstName;

                param[1] = new SqlParameter("@lastName", SqlDbType.NVarChar, 50);
                param[1].Value = lastName;

                param[2] = new SqlParameter("@contactNumber", SqlDbType.NVarChar, 50);
                param[2].Value = contactNumber;

                param[3] = new SqlParameter("@licenseNumber", SqlDbType.NVarChar, 50);
                param[3].Value = licenseNumber;

                param[4] = new SqlParameter("@clinicAddress", SqlDbType.NVarChar, 50);
                param[4].Value = clinicAddress;

                param[5] = new SqlParameter("@specialization", SqlDbType.NVarChar, 50);
                param[5].Value = specialization;

                dal.execute("InsertDoctor", param); // اسم الإجراء المخزن هو "sp_InsertDoctor"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateDoctor(int doctorID, string firstName, string lastName, string contactNumber, string licenseNumber, string clinicAddress, string specialization)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[0].Value = doctorID;

                param[1] = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
                param[1].Value = firstName;

                param[2] = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
                param[2].Value = lastName;

                param[3] = new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 50);
                param[3].Value = contactNumber;

                param[4] = new SqlParameter("@LicenseNumber", SqlDbType.NVarChar, 50);
                param[4].Value = licenseNumber;

                param[5] = new SqlParameter("@ClinicAddress", SqlDbType.NVarChar, 50);
                param[5].Value = clinicAddress;

                param[6] = new SqlParameter("@Specialization", SqlDbType.NVarChar, 50);
                param[6].Value = specialization;

                dal.execute("sp_UpdateDoctor", param); // اسم الإجراء المخزن لتحديث بيانات الطبيب

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات الطبيب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void DeleteDoctor(int doctorID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@DoctorID", SqlDbType.Int);
                param[0].Value = doctorID;

                dal.execute("sp_DeleteDoctorById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteDoctorById"

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
