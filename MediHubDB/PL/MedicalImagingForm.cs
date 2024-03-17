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
    public partial class MedicalImagingForm : Form
    {  BL.MedicalImaging mimg=new BL.MedicalImaging();
        BL.MedicalReportsForm med = new BL.MedicalReportsForm();
        BL.Appointments ap = new BL.Appointments();
        public MedicalImagingForm()
        {
            InitializeComponent();


            this.DATADREDVIEPINTA.DataSource = mimg.GetAllMedicalImagingData();


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

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                int panid = Convert.ToInt32(comboBox1.SelectedValue);
                int docid = Convert.ToInt32(comboBox2.SelectedValue);

                
                mimg.InsertMedicalImaging(panid, docid, dateTimePicker1.Value, richTextBox1.Text, richTextBox2.Text, filetect.Text);





                MessageBox.Show("تم إضافة البيانات بنجاح");

                this.DATADREDVIEPINTA.DataSource = mimg.GetAllMedicalImagingData();
                // تفريغ الحقول بعد الإضافة بنجاح

            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء إضافة البيانات ضع المؤشر في حقل الباركود: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف السجل   المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int docID = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);





               
                mimg.DeleteMedicalImaging(docID);

                MessageBox.Show("تمت عمليةالحذف بنجاح");


                this.DATADREDVIEPINTA.DataSource = mimg.GetAllMedicalImagingData();

            }

            else
            {
                MessageBox.Show("تم الغاء العملية");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (DATADREDVIEPINTA.CurrentRow != null)
                {

                    
                    iamgeeditform im =new iamgeeditform();

                  

                    int docid = Convert.ToInt32(this.DATADREDVIEPINTA.CurrentRow.Cells[0].Value);
                    im.textBox1.Text = docid.ToString();
                    im.comboBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[2].Value.ToString();
                    im.comboBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[4].Value.ToString();
                    im.dateTimePicker1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[5].Value.ToString();
                    im.richTextBox1.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[6].Value.ToString();
                    im.richTextBox2.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[7].Value.ToString();
                    im.filetect.Text = this.DATADREDVIEPINTA.CurrentRow.Cells[9].Value.ToString();
                    im.ShowDialog();


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
            this.DATADREDVIEPINTA.DataSource = mimg.GetAllMedicalImagingData();
        }

        private void textBoxserch_TextChanged(object sender, EventArgs e)
        {

            System.Data.DataTable dt = new System.Data.DataTable();


            dt = mimg.Searchimage(textBoxserch.Text);
            this.DATADREDVIEPINTA.DataSource = dt;
        }
    }
}
