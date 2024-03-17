using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediHubDB.PL
{
    public partial class DoctorManagementForm : Form
    {  BL.DoctorHandler d = new BL.DoctorHandler();
        public DoctorManagementForm()
        {
            InitializeComponent();
            this.dataGridView1.DataSource=d.GetDoctorsData();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[5].Width = 300;
            this.dataGridView1.Columns[6].Width = 300;


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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


                d.InsertDoctor(firstnametext.Text, lastnametext.Text, contacttext.Text, numtext.Text, addresstext.Text, comboBox1.Text);

                MessageBox.Show("تم إضافة البيانات بنجاح");

                // تفريغ الحقول بعد الإضافة بنجاح
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            firstnametext.Text = "";
            lastnametext.Text = "";
            contacttext.Text = "";
            numtext.Text = "";
            addresstext.Text = "";
            comboBox1.Text = "";




            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);



                
                d.DeleteDoctor(docID);


                MessageBox.Show("تمت عمليةالحذف بنجاح");

                this.dataGridView1.DataSource = d.GetDoctorsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                { DoctorEditForm ded=new DoctorEditForm();

                    //int BonusID1 = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    ////int BonusID2 = Convert.ToInt32(this.datagridviewitems.CurrentRow.Cells[0].Value);
                    //edf.textBoxid.Text = BonusID1.ToString();
                    ////edf.textBoxid1.Text = BonusID2.ToString();
                    //edf.saplyercombo.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    ////  edf.barcodinputtext.Text = this.datagridviewitems.CurrentRow.Cells[1].Value.ToString();
                    //// edf.nameitemtextup.Text = this.datagridviewitems.CurrentRow.Cells[2].Value.ToString();
                    //edf.quantext.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    //edf.filetect.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    //edf.statecombo.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    //edf.cardnumtext.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();

                    //edf.ShowDialog();

                    int docid = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    ded.idtex.Text= docid.ToString();
                    ded.upfirstnametext.Text= this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    ded.uplastnametext.Text= this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    ded.upcontacttext.Text= this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    ded.upnumtext.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ded.upaddresstext.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    ded.upcomboBox1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    ded.ShowDialog();


                }
                else
                {
                    MessageBox.Show("الرجاء تحديد صف لتعديل البيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = d.GetDoctorsData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addresstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void numtext_TextChanged(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
