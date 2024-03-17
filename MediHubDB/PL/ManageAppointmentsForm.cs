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
    public partial class ManageAppointmentsForm : Form
    {  BL.Appointments ap=new BL.Appointments();
        
        public ManageAppointmentsForm()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.ToLongTimeString();

            this.DATADREDVIEPINTA.DataSource = ap.GetAllAppointmentsData();
            this.DATADREDVIEPINTA.Columns[0].Visible = false;
           


            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }



           this.dataGridViewdate.DataSource = ap.GetAppointmentsRegisteredToday();


            foreach (DataGridViewColumn column in dataGridViewdate.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }



            label4.Text=ap.GetPatientAppointmentsCount().ToString();




            DataTable allapand =ap.GetPatientsData();
            nampan.DataSource = allapand;
            nampan.DisplayMember =  "الاسم الأول";
            nampan.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            docname.DataSource = alldoc;
            docname.DisplayMember = "الاسم الأول";
            docname.ValueMember = "رقم الطبيب";
        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
               
                int panid = Convert.ToInt32(nampan.SelectedValue);
                int docid = Convert.ToInt32(docname.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;

               

                ap.InsertAppointment(panid, docid, date.Value, selectedTime);


                MessageBox.Show("تم إضافة البيانات بنجاح");
              

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


             

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(nampan.SelectedValue);
                int docid = Convert.ToInt32(docname.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;



                ap.InsertAppointment(panid, docid, date.Value, selectedTime);


                MessageBox.Show("تم إضافة البيانات بنجاح");


                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.DATADREDVIEPINTA.DataSource = ap.GetAllAppointmentsData();
            label4.Text = ap.GetPatientAppointmentsCount().ToString();
            this.dataGridViewdate.DataSource = ap.GetAppointmentsRegisteredToday();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);




               ap.DeleteAppointment(docID);


                MessageBox.Show("تمت عمليةالحذف بنجاح");
                this.DATADREDVIEPINTA.DataSource = ap.GetAllAppointmentsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void textBoxserch_TextChanged_1(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();


          
            dt = ap.SearchAppointments(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
        }

        private void dataGridViewdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {
                   
                    //AppointmentsDoctorEditForm ped =new AppointmentsDoctorEditForm();
                    editAppointmentsForm ped=new editAppointmentsForm();
                    



                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    ped.textBox1.Text = docid.ToString();
                    ped.upnampan.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    ped.docname.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[5].Value.ToString();
                    
                    ped.update.Value = Convert.ToDateTime(this.DATADREDVIEPINTA.CurrentRow.Cells[6].Value);
                    ped.dateTimePicker1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[7].Value.ToString();



                    
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(nampan.SelectedValue);
                int docid = Convert.ToInt32(docname.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;



                ap.InsertAppointment(panid, docid, date.Value, selectedTime);


                MessageBox.Show("تم إضافة البيانات بنجاح");


                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void docname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nampan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
