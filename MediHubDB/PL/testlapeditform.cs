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
    public partial class testlapeditform : Form
    {
        BL.LabTestsForm mimg = new BL.LabTestsForm();
        BL.MedicalReportsForm med = new BL.MedicalReportsForm();
        BL.Appointments ap = new BL.Appointments();

        BL.LabTestsForm tl=new BL.LabTestsForm();   
        public testlapeditform()
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(comboBox1.SelectedValue);
                int panid1 = Convert.ToInt32(textBox1.Text);
                int docid = Convert.ToInt32(comboBox2.SelectedValue);



               
                
                tl.UpdateLabTest(panid1, panid, docid, dateTimePicker1.Value, richTextBox1.Text, richTextBox2.Text, filetect.Text);



                MessageBox.Show("تم إضافة البيانات بنجاح");

                this.Close();
                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات : {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ملفات PDF (*.pdf)|*.pdf|ملفات Word (*.doc;*.docx)|*.doc;*.docx|All Files (*.*)|*.*";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // وضع مسار الملف في عنصر TextBox
                filetect.Text = filePath;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
