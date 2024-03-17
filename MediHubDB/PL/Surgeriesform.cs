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
    public partial class Surgeriesform : Form
    {
        BL.Surgeries ser = new BL.Surgeries();
        public Surgeriesform()
        {
            InitializeComponent();

            BL.Appointments ap = new BL.Appointments();
            BL.RecoveryTrackingform tr = new BL.RecoveryTrackingform();
            BL.Hospital hp= new BL.Hospital();



            UpdateTime();

            this.DATADREDVIEPINTA.DataSource =ser.GetAllSurgeriesData();

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
            DataTable allhop = hp.GetHospitalsData();
            hopnamecompo.DataSource = allhop;
            hopnamecompo.DisplayMember = "اسم المشفى";
            hopnamecompo.ValueMember = "رقم المشفى";



            this.dataGridViewdate.DataSource = ser.GetAllSurgeriesDataToday();


            this.dataGridViewdate.Columns[0].Visible = false;
            this.dataGridViewdate.Columns[3].Visible = false;
            this.dataGridViewdate.Columns[5].Visible = false;

            this.DATADREDVIEPINTA.Columns[0].Visible = false;
            this.DATADREDVIEPINTA.Columns[3].Visible = false;
            this.DATADREDVIEPINTA.Columns[5].Visible = false;

            foreach (DataGridViewColumn column in dataGridViewdate.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            DATADREDVIEPINTA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // يجعل الصفوف تتكيف بحسب حجم النص
            DATADREDVIEPINTA.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // يجعل النص يلتف في الخلايا


            label4.Text = ser.GetAllSurgeriesCountForToday().ToString();

        }

        private void UpdateTime()
        {
            // الحصول على الوقت الحالي
            DateTime currentTime = DateTime.Now;

            // تحويل الوقت إلى سلسلة نصية بالصيغة المطلوبة (مثلاً: "HH:mm:ss")
            string formattedTime = currentTime.ToString("HH:mm:ss");

            // عرض الوقت في Label
            label3.Text = formattedTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // استدعاء الدالة بانتظام كل ثانية (يمكنك استخدام توقيت لتحديث الوقت بشكل دوري)
            UpdateTime();
        }
        private void dataGridViewdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int panid = Convert.ToInt32(nampan.SelectedValue);
                int docid = Convert.ToInt32(docname.SelectedValue);
                int hopid = Convert.ToInt32(hopnamecompo.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;




              
                ser.InsertSurgery(panid, docid, hopid, date.Value, selectedTime, textBoxtype.Text, richTextBox1.Text);
                MessageBox.Show("تم إضافة البيانات بنجاح");

                this.dataGridViewdate.DataSource = ser.GetAllSurgeriesDataToday();
                this.DATADREDVIEPINTA.DataSource = ser.GetAllSurgeriesData();

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);





               
                ser.DeleteSurgery(docID);  

                MessageBox.Show("تمت عمليةالحذف بنجاح");


                this.dataGridViewdate.DataSource = ser.GetAllSurgeriesDataToday();
                this.DATADREDVIEPINTA.DataSource = ser.GetAllSurgeriesData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();



             dt=ser.SearchSurgeries(textBoxserch.Text);    
            this.DATADREDVIEPINTA.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridViewdate.DataSource = ser.GetAllSurgeriesDataToday();
            this.DATADREDVIEPINTA.DataSource = ser.GetAllSurgeriesData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {

                    //AppointmentsDoctorEditForm ped =new AppointmentsDoctorEditForm();

                    //int panid = Convert.ToInt32(nampan.SelectedValue);
                    //int docid = Convert.ToInt32(docname.SelectedValue);
                    //int hopid = Convert.ToInt32(hopnamecompo.SelectedValue);
                    //TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;





                    //ser.InsertSurgery(panid, docid, hopid, date.Value, selectedTime, textBoxtype.Text, richTextBox1.Text);


                    editeSurgeriesform ped =new editeSurgeriesform();




                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    ped.textBox1.Text = docid.ToString();
                    ped.nampan.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    ped.docname.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();
                    ped.hopnamecompo.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[6].Value.ToString();
                    ped.date.Value = Convert.ToDateTime(this.DATADREDVIEPINTA.CurrentRow.Cells[8].Value);
                    ped.dateTimePicker1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[9].Value.ToString();
                    ped.textBoxtype.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[7].Value.ToString();
                    ped.richTextBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[10].Value.ToString();




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
