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
    public partial class editPrescriptionform : Form
    {  BL.Prescriptions pr=new BL.Prescriptions();
        BL.Appointments ap = new BL.Appointments();   
        public editPrescriptionform()
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

        private void editPrescriptionform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {







                int panid = Convert.ToInt32(textBox1.Text);
                int namepan = Convert.ToInt32(upnampan.SelectedValue);
                int namdoc = Convert.ToInt32(docname.SelectedValue);
              
 
                pr.UpdatePrescription(panid, namepan, namdoc, update.Value, textBox2.Text);



                MessageBox.Show("تم تعديل البيانات بنجاح ");
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
