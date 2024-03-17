using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediHubDB.PL
{
    public partial class editeSurgeriesform : Form
    {
        BL.Surgeries ser = new BL.Surgeries();
        BL.Appointments ap = new BL.Appointments();
        BL.Hospital hp = new BL.Hospital();

        public editeSurgeriesform()
        {
            InitializeComponent();


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
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(nampan.SelectedValue);
                int panid1 = Convert.ToInt32(textBox1.Text);
                int docid = Convert.ToInt32(docname.SelectedValue);
                int hopid = Convert.ToInt32(hopnamecompo.SelectedValue);
                TimeSpan selectedTime = dateTimePicker1.Value.TimeOfDay;





                ser.UpdateSurgery(panid1,panid, docid, hopid, date.Value, selectedTime, textBoxtype.Text, richTextBox1.Text);
              
                MessageBox.Show("تم  تحديث البيانات بنجاح");
                this.Close();

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات  : {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
