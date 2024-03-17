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
    public partial class DoctorEditForm : Form
    {   BL.DoctorHandler d=new BL.DoctorHandler();
          
        public DoctorEditForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // استخراج معرف الطبيب من TextBox
                int doctorId = Convert.ToInt32(idtex.Text);

                // تحديث بيانات الطبيب باستخدام الدالة UpdateDoctor
                d.UpdateDoctor(doctorId, upfirstnametext.Text, uplastnametext.Text, upcontacttext.Text, upnumtext.Text, upaddresstext.Text, upcomboBox1.Text);

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
