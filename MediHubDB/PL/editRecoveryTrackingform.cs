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
    public partial class editRecoveryTrackingform : Form
    {
        BL.RecoveryTrackingform re = new BL.RecoveryTrackingform();

        BL.Appointments ap = new BL.Appointments();
        public editRecoveryTrackingform()
        {
            InitializeComponent();
            DataTable allapand = ap.GetPatientsData();
            upnampan.DataSource = allapand;
            upnampan.DisplayMember = "الاسم الأول";
            upnampan.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            docname.DataSource = alldoc;
            docname.DisplayMember = "الاسم الأول";
            docname.ValueMember = "رقم الطبيب";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {







                int panid = Convert.ToInt32(textBox1.Text);
                int namepan = Convert.ToInt32(upnampan.SelectedValue);
                int namdoc = Convert.ToInt32(docname.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;

                 
                re.UpdateRecoveryTracking(panid, namepan, namdoc, update.Value, selectedTime, textBox2.Text);
               


                MessageBox.Show("تم إضافة البيانات بنجاح");
                this.Close();

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void upnampan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_ValueChanged(object sender, EventArgs e)
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
    }
}
