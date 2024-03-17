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
    public partial class print : Form
    {
        BL.PrescriptionDetails pre = new BL.PrescriptionDetails();
        public print()
        {
            InitializeComponent();


            DATADREDVIEPINTA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // يجعل الصفوف تتكيف بحسب حجم النص
            DATADREDVIEPINTA.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // يجعل النص يلتف في الخلايا


        }

        private void print_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int panid = Convert.ToInt32(num.Text);
            this.DATADREDVIEPINTA.DataSource = pre.GetPrescriptionDetailsByPrescriptionID(panid);
            this.DATADREDVIEPINTA.Columns[0].Visible = false;
            this.DATADREDVIEPINTA.Columns[1].Visible = false;
            this.DATADREDVIEPINTA.Columns[2].Visible = false;
            this.DATADREDVIEPINTA.Columns[3].Visible = false;

            foreach (DataGridViewColumn column in DATADREDVIEPINTA.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }


            this.DATADREDVIEPINTA.Columns[9].Width = 220;
            this.DATADREDVIEPINTA.Columns[6].Width = 65;
            this.DATADREDVIEPINTA.Columns[7].Width = 65;
            this.DATADREDVIEPINTA.Columns[8].Width = 65;
            this.DATADREDVIEPINTA.Columns[4].Width = 110;

            printPreviewDialog1.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap img = new Bitmap(panel3.Width, panel3.Height);
            panel3.DrawToBitmap(img, new Rectangle(Point.Empty, panel3.Size));

            // حساب الإحداثيات لتوسيط الصورة في الورقة
            //int x = (e.MarginBounds.Width - img.Width) / 2;
            //int y = (e.MarginBounds.Height - img.Height) / 2;

            // رسم الصورة في منتصف الورقة
            e.Graphics.DrawImage(img, 100, 100);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DATADREDVIEPINTA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
