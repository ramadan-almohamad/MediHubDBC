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
    public partial class PatientManager : Form
    {     BL.PatientManager p=new BL.PatientManager();

        public PatientManager()
        {
            InitializeComponent();
            this.DATADREDVIEPINTA.DataSource = p.GetPatientsData();


            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {


                BL.PatientManager p = new BL.PatientManager();
                System.Data.DataTable dt = new System.Data.DataTable();


                dt = p.SearchPatients(textBox1.Text);







                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("رقم الاضبارة  محجوز لمريض اخر ");
                }
                else
                {


                    int id = Convert.ToInt32(textBox1.Text);
                    //int supid = Convert.ToInt32(saplyercombo.SelectedValue);
                    //string barcodin = barcodinputtext.Text;
                    //decimal quan = decimal.Parse(quantext.Text);
                    //string file = filetect.Text;
                    //string status = statecombo.Text;
                    //string cardnum = cardnumtext.Text;


                    p.InsertPatient(id, firstnametext.Text, lastnametext.Text, gendertext.Text, dateperth.Value, contacttext.Text, adresstext.Text);



                    MessageBox.Show("تم إضافة البيانات بنجاح");
                    this.DATADREDVIEPINTA.DataSource = p.GetPatientsData();

                    // تفريغ الحقول بعد الإضافة بنجاح
                }









            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            firstnametext.Text = "";
            lastnametext.Text = "";
            contacttext.Text = "";
            gendertext.Text = "";
            adresstext.Text = "";
        


        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);




         
                p.DeletePatient(docID); 


                MessageBox.Show("تمت عمليةالحذف بنجاح");

                this.DATADREDVIEPINTA.DataSource = p.GetPatientsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {
                    PatientEditForm ped = new PatientEditForm();

                    

                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    ped.penid.Text = docid.ToString();
                    ped.upfirstnametext.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[1].Value.ToString();
                    ped.uplastnametext.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    ped.upgendertext.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[3].Value.ToString();
                    ped.updateperth.Value = Convert.ToDateTime(this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value);
                    ped.upcontacttext.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[5].Value.ToString();
                
                   
                 
                    ped.upadresstext.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[6].Value.ToString();
                   
                    ped.ShowDialog();


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

        private void button2_Click(object sender, EventArgs e)
        {
            this.DATADREDVIEPINTA.DataSource = p.GetPatientsData();
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();


            dt = p.SearchPatients(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adresstext_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateperth_ValueChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gendertext_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm s=new ManageAppointmentsForm();
            s.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MedicalReportsForm medicalReportsForm = new MedicalReportsForm();   
                medicalReportsForm.ShowDialog();    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
