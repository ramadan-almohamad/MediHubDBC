using MediHubDB.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediHubDB.PL
{
    public partial class InvoiceManagerForm : Form
    {     BL.invoice inv =new BL.invoice();
        BL.Appointments ap = new BL.Appointments();
        public InvoiceManagerForm()
        {
            InitializeComponent();

            this.DATADREDVIEPINTA.DataSource = inv.GetAllInvoicesData();


            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }



            DataTable allapand = ap.GetPatientsData();
            nampan.DataSource = allapand;
            nampan.DisplayMember = "الاسم الأول";
            nampan.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            docname.DataSource = alldoc;
            docname.DisplayMember = "الاسم الأول";
            docname.ValueMember = "رقم الطبيب";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(nampan.SelectedValue);
                int docid = Convert.ToInt32(docname.SelectedValue);
                decimal quan = decimal.Parse(qount.Text);


                inv.InsertInvoice(panid, docid, date.Value, quan, comboBox1.Text);


                MessageBox.Show("تم إضافة البيانات بنجاح");
                this.DATADREDVIEPINTA.DataSource = inv.GetAllInvoicesData();

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text=inv.GetTotalInvoicesByDate(date.Value).ToString();
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();


 
            dt = inv.SearchInvoices(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DATADREDVIEPINTA.DataSource = inv.GetAllInvoicesData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);



 
                inv.DeleteInvoice(docID);


                MessageBox.Show("تمت عمليةالحذف بنجاح");
                this.DATADREDVIEPINTA.DataSource = inv.GetAllInvoicesData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }
    }
}
