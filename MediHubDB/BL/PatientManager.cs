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
    internal class PatientManager
    {




        public DataTable GetPatientsData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllPatients", null); // اسم الإجراء المخزن لجلب بيانات المرضى
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات المرضى: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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









        public void InsertPatient(int patientID, string firstName, string lastName, string gender, DateTime dateOfBirth, string contactNumber, string address)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[0].Value = patientID;

                param[1] = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
                param[1].Value = firstName;

                param[2] = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
                param[2].Value = lastName;

                param[3] = new SqlParameter("@Gender", SqlDbType.NVarChar, 50);
                param[3].Value = gender;

                param[4] = new SqlParameter("@DateOfBirth", SqlDbType.Date);
                param[4].Value = dateOfBirth;

                param[5] = new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 50);
                param[5].Value = contactNumber;

                param[6] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                param[6].Value = address;

                dal.execute("InsertPatient", param); // اسم الإجراء المخزن هو "InsertPatient"

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات المريض: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void UpdatePatient(int patientID, string firstName, string lastName, string gender, DateTime dateOfBirth, string contactNumber, string address)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[7];

                param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[0].Value = patientID;

                param[1] = new SqlParameter("@FirstName", SqlDbType.NVarChar, 50);
                param[1].Value = firstName;

                param[2] = new SqlParameter("@LastName", SqlDbType.NVarChar, 50);
                param[2].Value = lastName;

                param[3] = new SqlParameter("@Gender", SqlDbType.NVarChar, 50);
                param[3].Value = gender;

                param[4] = new SqlParameter("@DateOfBirth", SqlDbType.Date);
                param[4].Value = dateOfBirth;

                param[5] = new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 50);
                param[5].Value = contactNumber;

                param[6] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
                param[6].Value = address;

                dal.execute("sp_UpdatePatient", param);

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية تحديث بيانات المريض: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeletePatient(int patientID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@PatientID", SqlDbType.Int);
                param[0].Value = patientID;

                dal.execute("sp_DeletePatientById", param);

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable SearchPatients(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول المرضى واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_SearchPatients", param); // يجب استبدال "sp_SearchPatients" باسم الإجراء المخزن الجديد الذي يبحث في جدول المرضى
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



    }
}
