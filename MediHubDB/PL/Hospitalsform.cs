using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediHubDB.PL
{      
    public partial class Hospitalsform : Form
    {    BL.Hospital hp=new BL.Hospital();  
        public Hospitalsform()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = hp.GetHospitalsData();

            this.dataGridView1.Columns[3].Width = 200;
            this.dataGridView1.Columns[2].Width = 200;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //int inputid = Convert.ToInt32(textBoxid.Text);
                //int supid = Convert.ToInt32(saplyercombo.SelectedValue);
                //string barcodin = barcodinputtext.Text;
                //decimal quan = decimal.Parse(quantext.Text);
                //string file = filetect.Text;
                //string status = statecombo.Text;
                //string cardnum = cardnumtext.Text;


              
                hp.InsertHospital(firstnametext.Text, lastnametext.Text, contacttext.Text);
                MessageBox.Show("تم إضافة البيانات بنجاح");

                // تفريغ الحقول بعد الإضافة بنجاح
                this.dataGridView1.DataSource = hp.GetHospitalsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            firstnametext.Text = "";
            lastnametext.Text = "";
            contacttext.Text = "";
         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);




                
                hp.DeleteHospital(docID);

                MessageBox.Show("تمت عمليةالحذف بنجاح");

                this.dataGridView1.DataSource = hp.GetHospitalsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contacttext_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastnametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
