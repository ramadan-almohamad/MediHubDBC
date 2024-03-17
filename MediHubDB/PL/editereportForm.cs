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
    public partial class editereportForm : Form
    {
        BL.Surgeries ser = new BL.Surgeries();
        BL.Appointments ap = new BL.Appointments();
        BL.Hospital hp = new BL.Hospital();
       
        BL.MedicalReportsForm rep=new BL.MedicalReportsForm();  
        public editereportForm()
        {
            InitializeComponent();

            DataTable allapand = ap.GetPatientsData();
            comboBox1.DataSource = allapand;
            comboBox1.DisplayMember = "الاسم الأول";
            comboBox1.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            comboBox2.DataSource = alldoc;
            comboBox2.DisplayMember = "الاسم الأول";
            comboBox2.ValueMember = "رقم الطبيب";
        }

        private void editereportForm_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int panid1 = Convert.ToInt32(docid.Text);
                int panid = Convert.ToInt32(comboBox1.SelectedValue);
                int docid2 = Convert.ToInt32(comboBox2.SelectedValue);
                
 
                    rep.UpdateReport(panid1,panid, docid2, dateTimePicker1.Value, richTextBox1.Text, richTextBox2.Text);






                MessageBox.Show("تم تحديث البيانات بنجاح");
                this.Close();
              
                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء    تعديل البيانات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
