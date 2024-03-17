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
    public partial class Prescriptionsmanagmentform : Form
    {
        BL.Appointments ap = new BL.Appointments();
        BL.Prescriptions pre = new BL.Prescriptions();
        public Prescriptionsmanagmentform()
        {
            InitializeComponent();


            this.DATADREDVIEPINTA.DataSource = pre.GetAllPrescriptionsData();


            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }



            DataTable allapand = ap.GetPatientsData();
            comboBox1.DataSource = allapand;
            comboBox1.DisplayMember = "الاسم الأول";
            comboBox1.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            comboBox2.DataSource = alldoc;
            comboBox2.DisplayMember = "الاسم الأول";
            comboBox2.ValueMember = "رقم الطبيب";


           // this.DATADREDVIEPINTA.Columns[0].Visible = false;
            //this.DATADREDVIEPINTA.Columns[1].Visible = false;
            this.DATADREDVIEPINTA.Columns[5].Visible = false;
            this.DATADREDVIEPINTA.Columns[6].Visible = false;
            this.DATADREDVIEPINTA.Columns[7].Visible = false;
            this.DATADREDVIEPINTA.Columns[8].Visible = false;
            this.DATADREDVIEPINTA.Columns[9].Visible = false;



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(comboBox1.SelectedValue);
                int docid = Convert.ToInt32(comboBox2.SelectedValue);
                pre.InsertPrescription(panid, docid, dateTimePicker1.Value, richTextBox1.Text);

                






                MessageBox.Show("تم إضافة البيانات بنجاح");
                this.DATADREDVIEPINTA.DataSource = pre.GetAllPrescriptionsData();


                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();



            dt = pre.SearchPrescriptions(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);




                pre.DeletePrescription(docID);


                MessageBox.Show("تمت عمليةالحذف بنجاح");

                this.DATADREDVIEPINTA.DataSource = pre.GetAllPrescriptionsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Prescriptionsmanagmentform_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {
                    PrescriptionDetails pre =new PrescriptionDetails();

                    int BonusID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    int id2 = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[1].Value);
                    pre.textBox1.Text= BonusID.ToString();
                    pre.textBox4.Text = id2.ToString();
                 
                   pre.textBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    pre.textBox8.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[5].Value.ToString();
                    pre.text2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[6].Value.ToString();
                    pre.text1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[7].Value.ToString();
                    pre.text3.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[8].Value.ToString();
                    pre.text4.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[9].Value.ToString();
                    pre.text5.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[3].Value.ToString();
                    pre.text6.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();

                    pre.ShowDialog();
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

        private void DATADREDVIEPINTA_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Prescriptionsmanagmentform_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {

                    //AppointmentsDoctorEditForm ped =new AppointmentsDoctorEditForm();

                    editPrescriptionform ped = new editPrescriptionform();




                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    ped.textBox1.Text = docid.ToString();
                    ped.upnampan.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    ped.docname.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[5].Value.ToString();
                    ped.update.Value = Convert.ToDateTime(this.DATADREDVIEPINTA.CurrentRow.Cells[10].Value);
                    ped.textBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[11].Value.ToString();
                 
                    




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
            this.DATADREDVIEPINTA.DataSource = pre.GetAllPrescriptionsData();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
