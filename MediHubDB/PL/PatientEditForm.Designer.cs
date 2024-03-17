namespace MediHubDB.PL
{
    partial class PatientEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientEditForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.penid = new System.Windows.Forms.TextBox();
            this.upadresstext = new System.Windows.Forms.TextBox();
            this.updateperth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upgendertext = new System.Windows.Forms.TextBox();
            this.upcontacttext = new System.Windows.Forms.TextBox();
            this.uplastnametext = new System.Windows.Forms.TextBox();
            this.upfirstnametext = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.penid);
            this.panel2.Controls.Add(this.upadresstext);
            this.panel2.Controls.Add(this.updateperth);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.upgendertext);
            this.panel2.Controls.Add(this.upcontacttext);
            this.panel2.Controls.Add(this.uplastnametext);
            this.panel2.Controls.Add(this.upfirstnametext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(526, 540);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(157, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 45);
            this.button2.TabIndex = 15;
            this.button2.Text = "تعديل";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // penid
            // 
            this.penid.Location = new System.Drawing.Point(64, 12);
            this.penid.Name = "penid";
            this.penid.Size = new System.Drawing.Size(350, 20);
            this.penid.TabIndex = 14;
            // 
            // upadresstext
            // 
            this.upadresstext.Location = new System.Drawing.Point(78, 367);
            this.upadresstext.Multiline = true;
            this.upadresstext.Name = "upadresstext";
            this.upadresstext.Size = new System.Drawing.Size(352, 45);
            this.upadresstext.TabIndex = 13;
            // 
            // updateperth
            // 
            this.updateperth.Location = new System.Drawing.Point(97, 322);
            this.updateperth.Name = "updateperth";
            this.updateperth.Size = new System.Drawing.Size(317, 20);
            this.updateperth.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "العنوان";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "الميلاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "الجنس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "رقم التوصل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "اسم العائلة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المريض";
            // 
            // upgendertext
            // 
            this.upgendertext.Location = new System.Drawing.Point(64, 276);
            this.upgendertext.Name = "upgendertext";
            this.upgendertext.Size = new System.Drawing.Size(350, 20);
            this.upgendertext.TabIndex = 3;
            // 
            // upcontacttext
            // 
            this.upcontacttext.Location = new System.Drawing.Point(64, 203);
            this.upcontacttext.Name = "upcontacttext";
            this.upcontacttext.Size = new System.Drawing.Size(350, 20);
            this.upcontacttext.TabIndex = 2;
            // 
            // uplastnametext
            // 
            this.uplastnametext.Location = new System.Drawing.Point(64, 126);
            this.uplastnametext.Name = "uplastnametext";
            this.uplastnametext.Size = new System.Drawing.Size(347, 20);
            this.uplastnametext.TabIndex = 1;
            // 
            // upfirstnametext
            // 
            this.upfirstnametext.Location = new System.Drawing.Point(64, 52);
            this.upfirstnametext.Name = "upfirstnametext";
            this.upfirstnametext.Size = new System.Drawing.Size(350, 20);
            this.upfirstnametext.TabIndex = 0;
            // 
            // PatientEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 540);
            this.Controls.Add(this.panel2);
            this.Name = "PatientEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientEditForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DateTimePicker updateperth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox upgendertext;
        public System.Windows.Forms.TextBox upcontacttext;
        public System.Windows.Forms.TextBox uplastnametext;
        public System.Windows.Forms.TextBox upfirstnametext;
        public System.Windows.Forms.TextBox penid;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox upadresstext;
    }
}