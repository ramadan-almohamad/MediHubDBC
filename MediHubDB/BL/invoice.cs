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
    internal class invoice
    {

        public void InsertInvoice(int patientID, int doctorID, DateTime invoiceDate, decimal totalAmount, string paymentStatus)
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

                param[2] = new SqlParameter("@InvoiceDate", SqlDbType.Date);
                param[2].Value = invoiceDate;

                param[3] = new SqlParameter("@TotalAmount", SqlDbType.Decimal);
                param[3].Value = totalAmount;

                param[4] = new SqlParameter("@PaymentStatus", SqlDbType.NVarChar, 50);
                param[4].Value = paymentStatus;

                dal.execute("sp_InsertInvoice", param); // اسم الإجراء المخزن الجديد

                dal.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية إدخال بيانات الفاتورة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetAllInvoicesData()
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                DataTable dt = dal.selectdata("sp_GetAllInvoices", null); // اسم الإجراء المخزن لجلب بيانات الفواتير
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب بيانات الفواتير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public decimal GetTotalInvoicesByDate(DateTime targetDate)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();

                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TargetDate", SqlDbType.Date);
                param[0].Value = targetDate;

                DataTable dt = dal.selectdata("sp_GetTotalInvoicesByDate", param);

                // التحقق من أن الجدول لديه صف واحد على الأقل
                if (dt != null && dt.Rows.Count > 0)
                {
                    // استرجاع القيمة من الجدول
                    return Convert.ToDecimal(dt.Rows[0]["اجمالي الفواتير"]);
                }
                else
                {
                    // إذا لم يكن هناك بيانات
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء جلب اجمالي الفواتير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public DataTable SearchInvoices(string keyword)
        {
            try
            {
                // إنشاء كائن من الفئة DAL.DataAccess للوصول إلى قاعدة البيانات
                DAL.DataAccess dal = new DAL.DataAccess();

                // استدعاء إجراء البحث في جدول الفواتير واسترجاع النتائج في DataTable
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@searchKeyword", SqlDbType.NVarChar, 100);
                param[0].Value = keyword;

                DataTable dt = dal.selectdata("sp_SearchInvoices", param); // يجب استبدال "sp_SearchInvoices" باسم الإجراء المخزن الجديد الذي يبحث في جدول الفواتير
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
        public void DeleteInvoice(int invoiceID)
        {
            try
            {
                DAL.DataAccess dal = new DAL.DataAccess();
                dal.open();

                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@InvoiceID", SqlDbType.Int);
                param[0].Value = invoiceID;

                dal.execute("sp_DeleteInvoiceById", param); // تأكد من تغيير اسم الإجراء المخزن إلى "sp_DeleteInvoiceById"

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
