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
    public partial class login : Form
    {    BL.User lo =new BL.User();
        public login()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = lo.Login(textBox1.Text, textBox3.Text, comboBox1.Text);
            if (dt.Rows.Count > 0 && comboBox1.Text == "admin")
            {


                MessageBox.Show("تم تسجيل الدخول كطبيب");

                main.getmsinform.button1.Enabled = true;
                main.getmsinform.button2.Enabled = true;
                main.getmsinform.button3.Enabled = true;
                main.getmsinform.button4.Enabled = true;
                main.getmsinform.button5.Enabled = true;
                main.getmsinform.button6.Enabled = true;
                main.getmsinform.button7.Enabled = true;
                main.getmsinform.button8.Enabled = true;
                main.getmsinform.button9.Enabled = true;
                main.getmsinform.button10.Enabled = true;
                main.getmsinform.button11.Enabled = true;
                main.getmsinform.button12.Enabled = true;
               
                
                main.getmsinform.button21.Enabled = true;
                main.getmsinform.button22.Enabled = true;
                main.getmsinform.button15.Enabled = true;
                main.getmsinform.button23.Enabled = true;
                main.getmsinform.button19.Enabled = true;
                main.getmsinform.button17.Enabled = true;
                main.getmsinform.button18.Enabled = true;
                main.getmsinform.button20.Enabled = true;
                main.getmsinform.button25.Enabled = true;
                main.getmsinform.button13.Enabled = true;
                main.getmsinform.button14.Enabled = true;
                main.getmsinform.button24.Enabled = true;
                Close();
            }


            else if (dt.Rows.Count > 0 && comboBox1.Text == "user")
            {
              
                main.getmsinform.button2.Enabled = true;
                main.getmsinform.button3.Enabled = true;
               
                main.getmsinform.button7.Enabled = true;
               
                main.getmsinform.button10.Enabled = true;
                main.getmsinform.button11.Enabled = true;
               


              
                main.getmsinform.button15.Enabled = true;
               

                MessageBox.Show("تم تسجيل الدخول مستخدم");

             

                Close();
            }
          
         

            else
            {
                MessageBox.Show("فشل تسجيل الدخول");

            }
        }
    }
}
