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
    internal class User
    {



        public DataTable Login(string username, string passwowrd, string userType)
        {
            DAL.DataAccess dal = new DAL.DataAccess();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            param[0].Value = username;
            param[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            param[1].Value = passwowrd;
            param[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            param[2].Value = userType;
            dal.open();

            DataTable dt = dal.selectdata("sp_Login", param); // استخدم اسم الإجراء المخزن الصحيح هنا
            return dt;
        }








        // ... (تعريف الخصائص اللازمة لكل حقل في جدول المستخدمين)

        public void AddUser(string username, string password, string type)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[3];

                param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                param[0].Value = username;

                param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                param[1].Value = password;

                param[2] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
                param[2].Value = type;

                dal.execute("sp_InsertUser", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_InsertUser"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إضافة مستخدم: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetUsersData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                DataTable dt = dal.selectdata("sp_GetAllUsers", null); // اسم الإجراء المخزن لجلب معلومات المستخدمين
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات المستخدمين: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public void UpdateUser(int userID, string username, string password, string type)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[4];

                param[0] = new SqlParameter("@UserID", SqlDbType.Int);
                param[0].Value = userID;

                param[1] = new SqlParameter("@Username", SqlDbType.NVarChar, 50);
                param[1].Value = username;

                param[2] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
                param[2].Value = password;

                param[3] = new SqlParameter("@Type", SqlDbType.NVarChar, 50);
                param[3].Value = type;

                dal.execute("sp_UpdateUser", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_UpdateUser"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث مستخدم: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteUser(int userID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@UserID", SqlDbType.Int);
                param[0].Value = userID;

                dal.execute("sp_DeleteUser", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteUser"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية حذف مستخدم: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
