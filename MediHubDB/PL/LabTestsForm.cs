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
    public partial class LabTestsForm : Form
    {
      
        BL.LabTestsForm mimg=new BL.LabTestsForm();
        BL.MedicalReportsForm med = new BL.MedicalReportsForm();
        BL.Appointments ap = new BL.Appointments();
        public LabTestsForm()
        {
            InitializeComponent();
            this.DATADREDVIEPINTA.DataSource = mimg.GetAllLabTestsData();


            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }

            DataTable allapand = ap.GetPatientsData();
            comboBox1.DataSource = allapand;
            comboBox1.DisplayMember = "الاسم الأول";
            comboBox1.ValueMember = "رقم الاضبارة";

            DataTable alldoc = ap.GetDoctorsData();
            comboBox2.DataSource = alldoc;
            comboBox2.DisplayMember = "الاسم الأول";
            comboBox2.ValueMember = "رقم الطبيب";



            DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn();
            linkColumn.Name = "ملف";
            linkColumn.HeaderText = "ملف";
            linkColumn.DataPropertyName = "ملف";
            DATADREDVIEPINTA.Columns.Add(linkColumn);

            DATADREDVIEPINTA.CellContentClick += datagridviewitems_CellContentClick;
             this.DATADREDVIEPINTA.Columns[0].Visible = false;
            //this.DATADREDVIEPINTA.Columns[1].Visible = false;
            this.DATADREDVIEPINTA.Columns[3].Visible = false;
             this.DATADREDVIEPINTA.Columns[8].Visible = false;
            DATADREDVIEPINTA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // يجعل الصفوف تتكيف بحسب حجم النص
            DATADREDVIEPINTA.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // يجعل النص يلتف في الخلايا
        }
        private void datagridviewitems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (DATADREDVIEPINTA.Columns[e.ColumnIndex] is DataGridViewLinkColumn && DATADREDVIEPINTA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string filePath = DATADREDVIEPINTA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    // فتح الملف باستخدام التطبيق الافتراضي لتلك الامتدادات
                    System.Diagnostics.Process.Start(filePath);
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(comboBox1.SelectedValue);
                int docid = Convert.ToInt32(comboBox2.SelectedValue);


                 
                mimg.InsertLabTest(panid, docid, dateTimePicker1.Value, richTextBox1.Text, richTextBox2.Text, filetect.Text);




                MessageBox.Show("تم إضافة البيانات بنجاح");

                this.DATADREDVIEPINTA.DataSource = mimg.GetAllLabTestsData();
                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);






                
                mimg.DeleteLabTest(docID);

                MessageBox.Show("تمت عمليةالحذف بنجاح");



                this.DATADREDVIEPINTA.DataSource = mimg.GetAllLabTestsData();
            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();

 
            dt = mimg.SearchLabTests(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {

                    testlapeditform ded = new testlapeditform();

                    //int BonusID1 = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    ////int BonusID2 = Convert.ToInt32(this.datagridviewitems.CurrentRow.Cells[0].Value);
                    //edf.textBoxid.Text = BonusID1.ToString();
                    ////edf.textBoxid1.Text = BonusID2.ToString();
                    //edf.saplyercombo.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    ////  edf.barcodinputtext.Text = this.datagridviewitems.CurrentRow.Cells[1].Value.ToString();
                    //// edf.nameitemtextup.Text = this.datagridviewitems.CurrentRow.Cells[2].Value.ToString();
                    //edf.quantext.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    //edf.filetect.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    //edf.statecombo.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    //edf.cardnumtext.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();

                    //edf.ShowDialog();

                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    ded.textBox1.Text = docid.ToString();
                    ded.comboBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    ded.comboBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();
                    ded.dateTimePicker1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[5].Value.ToString();
                    ded.richTextBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[6].Value.ToString();
                    ded.richTextBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[7].Value.ToString();
                    ded.filetect.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[9].Value.ToString();
                    ded.ShowDialog();


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

        private void button3_Click(object sender, EventArgs e)
        {
            this.DATADREDVIEPINTA.DataSource = mimg.GetAllLabTestsData();
        }
    }
}
