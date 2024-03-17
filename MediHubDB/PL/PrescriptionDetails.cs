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
    public partial class PrescriptionDetails : Form
    {
        BL.Medication md = new BL.Medication();
        BL.PrescriptionDetails pre=new BL.PrescriptionDetails();
        public PrescriptionDetails()
        {
            InitializeComponent();

           
            DataTable allapand = md.GetAllMedicationsData();
            comboBox1.DataSource = allapand;
            comboBox1.DisplayMember = "اسم الدواء";
            comboBox1.ValueMember = "معرف الدواء";



            this.DATADREDVIEPINTA.DataSource = pre.GetAllPrescriptionDetailsData();
            this.DATADREDVIEPINTA.Columns[0].Visible = false;
            //this.DATADREDVIEPINTA.Columns[1].Visible = false;
            //this.DATADREDVIEPINTA.Columns[2].Visible = false;
            //this.DATADREDVIEPINTA.Columns[3].Visible = false;

            DATADREDVIEPINTA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // يجعل الصفوف تتكيف بحسب حجم النص
            DATADREDVIEPINTA.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // يجعل النص يلتف في الخلايا



            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {



        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {

                int panid = Convert.ToInt32(textBox1.Text);
                int docid = Convert.ToInt32(comboBox1.SelectedValue);

                pre.InsertPrescription(panid, docid, textBox3.Text, textBox5.Text, comboBox3.Text, textBox6.Text, textBox7.Text);


      





                MessageBox.Show("تم إضافة البيانات بنجاح");


                this.DATADREDVIEPINTA.DataSource = pre.GetPrescriptionDetailsByPrescriptionID(panid);

                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);




               
                pre.DeletePrescription(docID);


                MessageBox.Show("تمت عمليةالحذف بنجاح");
                this.DATADREDVIEPINTA.DataSource = pre.GetAllPrescriptionDetailsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            int panid = Convert.ToInt32(textBox1.Text);
            this.DATADREDVIEPINTA.DataSource = pre.GetPrescriptionDetailsByPrescriptionID(panid);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            print prin=new print();
            prin.num.Text = this.textBox1.Text;
            prin.docname.Text = this.textBox8.Text;
            prin.pantname.Text=this.textBox2.Text;
            prin.label3.Text = this.text2.Text;
            prin.label4.Text = this.text5.Text;
            prin.label7.Text = this.text6.Text;
            prin.label10.Text = this.text4.Text;
            prin.label14.Text = this.text3.Text;
            prin.label15.Text = this.text1.Text;
            prin.ShowDialog();



        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DATADREDVIEPINTA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // يجعل الصفوف تتكيف بحسب حجم النص
            DATADREDVIEPINTA.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // يجعل النص يلتف في الخلايا

        }
    }
}
