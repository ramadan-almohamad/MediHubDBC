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
    public partial class RecoveryTrackingform : Form
    {
         
        BL.Appointments ap = new BL.Appointments();
        BL.RecoveryTrackingform tr=new BL.RecoveryTrackingform();   
        public RecoveryTrackingform()
        {
            InitializeComponent();

            this.DATADREDVIEPINTA.DataSource =tr.GetAllRecoveryTrackingData();

            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }


            this.dataGridViewdate.DataSource =tr.GetRecoveryTrackingRegisteredToday();

            //this.dataGridViewdate.Columns[0].Visible = false;
            //this.dataGridViewdate.Columns[3].Visible = false;
            //this.dataGridViewdate.Columns[4].Visible = false;

            //this.DATADREDVIEPINTA.Columns[0].Visible = false;
            //this.DATADREDVIEPINTA.Columns[3].Visible = false;
            //this.DATADREDVIEPINTA.Columns[4].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewdate.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }


            label4.Text = tr.GetPatientTrackingCountForToday().ToString();



            DataTable allapand = ap.GetPatientsData();
            nampan.DataSource = allapand;
            nampan.DisplayMember = "الاسم الأول";
            nampan.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            docname.DataSource = alldoc;
            docname.DisplayMember = "الاسم الأول";
            docname.ValueMember = "رقم الطبيب";
        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(nampan.SelectedValue);
                int docid = Convert.ToInt32(docname.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;



                
                tr.InsertRecoveryTracking(panid, docid, date.Value, selectedTime, richTextBox1.Text);

                MessageBox.Show("تم إضافة البيانات بنجاح");
                this.DATADREDVIEPINTA.DataSource = tr.GetAllRecoveryTrackingData();

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int panid = Convert.ToInt32(nampan.SelectedValue);
                int docid = Convert.ToInt32(docname.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;



             
                tr.InsertRecoveryTracking(panid, docid, date.Value, selectedTime, richTextBox1.Text);

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
            this.DATADREDVIEPINTA.DataSource = tr.GetAllRecoveryTrackingData();
           
            this.dataGridViewdate.DataSource = tr.GetRecoveryTrackingRegisteredToday();
            this.dataGridViewdate.Columns[7].Width =500;
            this.DATADREDVIEPINTA.Columns[7].Width = 500;
            
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();



            dt = tr.SearchRecoveryTracking(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);




              
                tr.DeleteRecoveryTrackingByAppointmentID(docID);    

                MessageBox.Show("تمت عمليةالحذف بنجاح");

                this.DATADREDVIEPINTA.DataSource = tr.GetAllRecoveryTrackingData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {

                    //AppointmentsDoctorEditForm ped =new AppointmentsDoctorEditForm();
                   
                    editRecoveryTrackingform ped = new editRecoveryTrackingform();  




                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    ped.textBox1.Text = docid.ToString();
                    ped.upnampan.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                     ped.docname.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();
                    ped.textBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[7].Value.ToString();
                    ped.update.Value = Convert.ToDateTime(this.DATADREDVIEPINTA.CurrentRow.Cells[5].Value);
                    ped.dateTimePicker1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[6].Value.ToString();




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
    }
}
