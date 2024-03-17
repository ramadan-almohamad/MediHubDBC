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
    public partial class MedicationManagementForm : Form
    {    BL.Medication md=new BL.Medication();  
        public MedicationManagementForm()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = md.GetAllMedicationsData();


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                //int inputid = Convert.ToInt32(textBoxid.Text);
                //int supid = Convert.ToInt32(saplyercombo.SelectedValue);
                //string barcodin = barcodinputtext.Text;
                //decimal quan = decimal.Parse(quantext.Text);
                //string file = filetect.Text;
                //string status = statecombo.Text;
                //string cardnum = cardnumtext.Text;


                
                md.InsertMedication(name.Text,type.Text);
                MessageBox.Show("تم إضافة البيانات بنجاح");
                this.dataGridView1.DataSource = md.GetAllMedicationsData();

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            name.Text = "";
            type.Text = "";
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);




                md.DeleteMedication(docID);


                MessageBox.Show("تمت عمليةالحذف بنجاح");
                this.dataGridView1.DataSource = md.GetAllMedicationsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }
    }
}
