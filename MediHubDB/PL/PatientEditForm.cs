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
    public partial class PatientEditForm : Form
    {  BL.PatientManager pen=new BL.PatientManager();
        public PatientEditForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // استخراج معرف الطبيب من TextBox
                int patinrId = Convert.ToInt32(penid.Text);

                // تحديث بيانات الطبيب باستخدام الدالة UpdateDoctor
               
                pen.UpdatePatient(patinrId, upfirstnametext.Text, uplastnametext.Text, upgendertext.Text,updateperth.Value, upcontacttext.Text, upadresstext.Text);

                MessageBox.Show("تم تعديل البيانات بنجاح");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تعديل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
