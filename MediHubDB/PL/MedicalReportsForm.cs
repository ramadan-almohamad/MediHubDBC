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
    public partial class MedicalReportsForm : Form
    {       BL.MedicalReportsForm med = new BL.MedicalReportsForm();
        BL.Appointments ap = new BL.Appointments();
        public MedicalReportsForm()
        {
            InitializeComponent();
            DATADREDVIEPINTA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // يجعل الصفوف تتكيف بحسب حجم النص
            DATADREDVIEPINTA.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // يجعل النص يلتف في الخلايا
            DataTable allapand = ap.GetPatientsData();
            comboBox1.DataSource = allapand;
            comboBox1.DisplayMember = "الاسم الأول";
            comboBox1.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            comboBox2.DataSource = alldoc;
            comboBox2.DisplayMember = "الاسم الأول";
            comboBox2.ValueMember = "رقم الطبيب";


              this.DATADREDVIEPINTA.DataSource = med.GetAllReportsData();


            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            this.DATADREDVIEPINTA.Columns[0].Visible = false;
            //this.DATADREDVIEPINTA.Columns[1].Visible = false;
            this.DATADREDVIEPINTA.Columns[3].Visible = false;
            this.DATADREDVIEPINTA.Columns[5].Visible = false;
            this.DATADREDVIEPINTA.Columns[6].Visible = false;
            this.DATADREDVIEPINTA.Columns[7].Visible = false;
            this.DATADREDVIEPINTA.Columns[8].Visible = false;
            this.DATADREDVIEPINTA.Columns[9].Visible = false;
            this.DATADREDVIEPINTA.Columns[10].Visible = false;
            this.DATADREDVIEPINTA.Columns[11].Visible = false;
            DATADREDVIEPINTA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // يجعل الصفوف تتكيف بحسب حجم النص
            DATADREDVIEPINTA.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // يجعل النص يلتف في الخلايا

            // يمكنك أيضا تحديد WrapMode على مستوى العمود إذا أردت تطبيقه لعمود محدد
            // dataGridView1.Columns["اسم_العمود"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(comboBox1.SelectedValue);
                int docid = Convert.ToInt32(comboBox2.SelectedValue);
                
                med.InsertReport(panid, docid,dateTimePicker1.Value,richTextBox1.Text,richTextBox2.Text);



              


                MessageBox.Show("تم إضافة البيانات بنجاح");

                this.DATADREDVIEPINTA.DataSource = med.GetAllReportsData();
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);



 
                med.DeleteReport(docID);


                MessageBox.Show("تمت عمليةالحذف بنجاح");
                this.DATADREDVIEPINTA.DataSource = med.GetAllReportsData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {



            //this.DATADREDVIEPINTA.DataSource = med.GetAllReportsData();
            printreportform prin = new printreportform();
            





            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {


                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    prin.idtex.Text = docid.ToString();
                    prin.docname.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();
                    prin.statu.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[1].Value.ToString();
                    prin.pantname.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    prin.spesv.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[11].Value.ToString();
                    
                    prin.age1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[16].Value.ToString();
                    prin.addres.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();
                    prin.phon.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[9].Value.ToString();
                    prin.mobile.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[8].Value.ToString();
                    prin.richTextBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[14].Value.ToString();
                    prin.sex.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[13].Value.ToString();
                    prin.sex1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[15].Value.ToString();
                    prin.sex.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[13].Value.ToString();
                    prin.ShowDialog();


                }
                else
                {
                    MessageBox.Show("الرجاء تحديد صف لتعديل البيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void MedicalReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {

                    //int panid = Convert.ToInt32(comboBox1.SelectedValue);
                    //int docid = Convert.ToInt32(comboBox2.SelectedValue);

                    //med.InsertReport(panid, docid, dateTimePicker1.Value, richTextBox1.Text, richTextBox2.Text);



                    //ser.InsertSurgery(panid, docid, hopid, date.Value, selectedTime, textBoxtype.Text, richTextBox1.Text);


                    editereportForm ped = new editereportForm();




                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    ped.docid.Text = docid.ToString();
                    ped.comboBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    ped.comboBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();
                   
                    ped.dateTimePicker1.Value = Convert.ToDateTime(this.DATADREDVIEPINTA.CurrentRow.Cells[12].Value);
                  
                    ped.richTextBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[13].Value.ToString();
                    ped.richTextBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[14].Value.ToString();
 


                    ped.ShowDialog();


                }
                else
                {
                    MessageBox.Show("الرجاء تحديد صف لتعديل البيانات.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();



            dt = med.SearchSreport(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
        }

        private void DATADREDVIEPINTA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.DATADREDVIEPINTA.Columns[13].Width = 200;
            this.DATADREDVIEPINTA.Columns[14].Width = 400;
        }
    }
}
