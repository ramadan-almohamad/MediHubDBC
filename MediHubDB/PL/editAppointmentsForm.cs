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
    public partial class editAppointmentsForm : Form
    {


                    BL.Appointments ap = new BL.Appointments();
        public editAppointmentsForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {




                 


                int panid = Convert.ToInt32(textBox1.Text);
                int namepan = Convert.ToInt32(upnampan.SelectedValue);
                int namdoc = Convert.ToInt32(docname.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;

                ap.UpdateAppointment(panid, namepan, namdoc, update.Value, selectedTime);



                MessageBox.Show("تم إضافة البيانات بنجاح");
                this.Close();

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
