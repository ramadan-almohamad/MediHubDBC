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
    public partial class usermanagment : Form
    {  BL.User us=new BL.User();
        public usermanagment()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = us.GetUsersData();
            this.dataGridView1.Columns[1].Width = 200;
             this.dataGridView1.Columns[2].Width = 200;
            this.dataGridView1.Columns[0].Visible = false;
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



                 
                us.AddUser(firstnametext.Text, lastnametext.Text, comboBox1.Text);
                MessageBox.Show("تم إضافة البيانات بنجاح");

                // تفريغ الحقول بعد الإضافة بنجاح
                this.dataGridView1.DataSource = us.GetUsersData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات  : {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            firstnametext.Text = "";
            lastnametext.Text = "";
 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);




                us.DeleteUser(docID);
               

                MessageBox.Show("تمت عمليةالحذف بنجاح");

                this.dataGridView1.DataSource = us.GetUsersData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }
    }
}
