namespace MediHubDB.PL
{
    partial class DoctorEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorEditForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.idtex = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upcomboBox1 = new System.Windows.Forms.ComboBox();
            this.upaddresstext = new System.Windows.Forms.TextBox();
            this.upnumtext = new System.Windows.Forms.TextBox();
            this.upcontacttext = new System.Windows.Forms.TextBox();
            this.uplastnametext = new System.Windows.Forms.TextBox();
            this.upfirstnametext = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.idtex);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.upcomboBox1);
            this.panel2.Controls.Add(this.upaddresstext);
            this.panel2.Controls.Add(this.upnumtext);
            this.panel2.Controls.Add(this.upcontacttext);
            this.panel2.Controls.Add(this.uplastnametext);
            this.panel2.Controls.Add(this.upfirstnametext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(569, 485);
            this.panel2.TabIndex = 2;
            // 
            // idtex
            // 
            this.idtex.Location = new System.Drawing.Point(41, 25);
            this.idtex.Name = "idtex";
            this.idtex.Size = new System.Drawing.Size(350, 20);
            this.idtex.TabIndex = 13;
            this.idtex.Visible = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(123, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "تعديل";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "الاختصاص";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "عنوان العيادة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "الارضي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "موبايل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "الكنية";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم الطبيب";
            // 
            // upcomboBox1
            // 
            this.upcomboBox1.FormattingEnabled = true;
            this.upcomboBox1.Items.AddRange(new object[] {
            "جراحة عامة ",
            "جراحة عصبية",
            "داخلية",
            "اطفال ",
            "عصبية",
            "عظمية"});
            this.upcomboBox1.Location = new System.Drawing.Point(41, 378);
            this.upcomboBox1.Name = "upcomboBox1";
            this.upcomboBox1.Size = new System.Drawing.Size(347, 21);
            this.upcomboBox1.TabIndex = 5;
            // 
            // upaddresstext
            // 
            this.upaddresstext.Location = new System.Drawing.Point(41, 315);
            this.upaddresstext.Name = "upaddresstext";
            this.upaddresstext.Size = new System.Drawing.Size(347, 20);
            this.upaddresstext.TabIndex = 4;
            // 
            // upnumtext
            // 
            this.upnumtext.Location = new System.Drawing.Point(41, 260);
            this.upnumtext.Name = "upnumtext";
            this.upnumtext.Size = new System.Drawing.Size(350, 20);
            this.upnumtext.TabIndex = 3;
            // 
            // upcontacttext
            // 
            this.upcontacttext.Location = new System.Drawing.Point(41, 197);
            this.upcontacttext.Name = "upcontacttext";
            this.upcontacttext.Size = new System.Drawing.Size(350, 20);
            this.upcontacttext.TabIndex = 2;
            // 
            // uplastnametext
            // 
            this.uplastnametext.Location = new System.Drawing.Point(44, 127);
            this.uplastnametext.Name = "uplastnametext";
            this.uplastnametext.Size = new System.Drawing.Size(347, 20);
            this.uplastnametext.TabIndex = 1;
            // 
            // upfirstnametext
            // 
            this.upfirstnametext.Location = new System.Drawing.Point(44, 62);
            this.upfirstnametext.Name = "upfirstnametext";
            this.upfirstnametext.Size = new System.Drawing.Size(350, 20);
            this.upfirstnametext.TabIndex = 0;
            // 
            // DoctorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 485);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoctorEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox upcomboBox1;
        public System.Windows.Forms.TextBox upaddresstext;
        public System.Windows.Forms.TextBox upnumtext;
        public System.Windows.Forms.TextBox upcontacttext;
        public System.Windows.Forms.TextBox uplastnametext;
        public System.Windows.Forms.TextBox upfirstnametext;
        public System.Windows.Forms.TextBox idtex;
    }
}