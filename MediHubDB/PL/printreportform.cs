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
    public partial class printreportform : Form
    { 
        public printreportform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             

            printPreviewDialog1.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
    }
}
