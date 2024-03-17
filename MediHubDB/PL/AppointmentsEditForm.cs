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
    public partial class AppointmentsDoctorEditForm : Form
    {  BL.Appointments ap=new BL.Appointments();    
        public AppointmentsDoctorEditForm()
        {
            InitializeComponent();


            DataTable allapand = ap.GetPatientsData();
            upnampan.DataSource = allapand;
            upnampan.DisplayMember = "الاسم الأول";
            upnampan.ValueMember = "معرف المريض";

            DataTable alldoc = ap.GetDoctorsData();
            updocname.DataSource = alldoc;
            updocname.DisplayMember = "الاسم الأول";
            updocname.ValueMember = "رقم الطبيب";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 

                int panid = Convert.ToInt32(textBox1.Text);
                int namepan = Convert.ToInt32(updocname.SelectedValue);
                int namdoc = Convert.ToInt32(updocname.SelectedValue);
                TimeSpan selectedTime = updateTimePicker1.Value.TimeOfDay;

                ap.UpdateAppointment(panid, namepan, namdoc,update.Value, selectedTime);

               

                MessageBox.Show("تم إضافة البيانات بنجاح");


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
    }
}
