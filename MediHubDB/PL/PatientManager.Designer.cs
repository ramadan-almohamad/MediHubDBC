namespace MediHubDB.PL
{
    partial class PatientManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxserch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DATADREDVIEPINTA = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adresstext = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dateperth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gendertext = new System.Windows.Forms.TextBox();
            this.contacttext = new System.Windows.Forms.TextBox();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.firstnametext = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATADREDVIEPINTA)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxserch);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1570, 72);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxserch
            // 
            this.textBoxserch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxserch.Location = new System.Drawing.Point(12, 35);
            this.textBoxserch.Name = "textBoxserch";
            this.textBoxserch.Size = new System.Drawing.Size(1162, 24);
            this.textBoxserch.TabIndex = 1;
            this.textBoxserch.Text = "بحث";
            this.textBoxserch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxserch.TextChanged += new System.EventHandler(this.textBoxserch_TextChanged);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1230, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "تحديث";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(1340, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 52);
            this.button6.TabIndex = 6;
            this.button6.Text = "حذف";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(1450, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 52);
            this.button5.TabIndex = 5;
            this.button5.Text = "تعديل";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DATADREDVIEPINTA
            // 
            this.DATADREDVIEPINTA.AllowUserToOrderColumns = true;
            this.DATADREDVIEPINTA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATADREDVIEPINTA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DATADREDVIEPINTA.BackgroundColor = System.Drawing.Color.White;
            this.DATADREDVIEPINTA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DATADREDVIEPINTA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DATADREDVIEPINTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATADREDVIEPINTA.Dock = System.Windows.Forms.DockStyle.Left;
            this.DATADREDVIEPINTA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DATADREDVIEPINTA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DATADREDVIEPINTA.Location = new System.Drawing.Point(0, 72);
            this.DATADREDVIEPINTA.Name = "DATADREDVIEPINTA";
            this.DATADREDVIEPINTA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DATADREDVIEPINTA.Size = new System.Drawing.Size(1178, 535);
            this.DATADREDVIEPINTA.TabIndex = 4;
            this.DATADREDVIEPINTA.TabStop = false;
            this.DATADREDVIEPINTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATADREDVIEPINTA_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.adresstext);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.dateperth);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.gendertext);
            this.panel2.Controls.Add(this.contacttext);
            this.panel2.Controls.Add(this.lastnametext);
            this.panel2.Controls.Add(this.firstnametext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(1187, 72);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(383, 535);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "رقم الاضبارة";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // adresstext
            // 
            this.adresstext.Location = new System.Drawing.Point(42, 432);
            this.adresstext.Multiline = true;
            this.adresstext.Name = "adresstext";
            this.adresstext.Size = new System.Drawing.Size(300, 45);
            this.adresstext.TabIndex = 13;
            this.adresstext.TextChanged += new System.EventHandler(this.adresstext_TextChanged);
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(153, 483);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 52);
            this.button7.TabIndex = 5;
            this.button7.Text = "أدخال جديد";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dateperth
            // 
            this.dateperth.Location = new System.Drawing.Point(16, 365);
            this.dateperth.Name = "dateperth";
            this.dateperth.Size = new System.Drawing.Size(317, 20);
            this.dateperth.TabIndex = 12;
            this.dateperth.ValueChanged += new System.EventHandler(this.dateperth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "العنوان";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "الميلاد";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "الجنس";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "رقم التوصل";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "اسم العائلة";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "اسم المريض";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gendertext
            // 
            this.gendertext.Location = new System.Drawing.Point(3, 301);
            this.gendertext.Name = "gendertext";
            this.gendertext.Size = new System.Drawing.Size(350, 20);
            this.gendertext.TabIndex = 3;
            this.gendertext.TextChanged += new System.EventHandler(this.gendertext_TextChanged);
            // 
            // contacttext
            // 
            this.contacttext.Location = new System.Drawing.Point(-3, 247);
            this.contacttext.Name = "contacttext";
            this.contacttext.Size = new System.Drawing.Size(350, 20);
            this.contacttext.TabIndex = 2;
            this.contacttext.TextChanged += new System.EventHandler(this.contacttext_TextChanged);
            // 
            // lastnametext
            // 
            this.lastnametext.Location = new System.Drawing.Point(14, 177);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(347, 20);
            this.lastnametext.TabIndex = 1;
            this.lastnametext.TextChanged += new System.EventHandler(this.lastnametext_TextChanged);
            // 
            // firstnametext
            // 
            this.firstnametext.Location = new System.Drawing.Point(-3, 108);
            this.firstnametext.Name = "firstnametext";
            this.firstnametext.Size = new System.Drawing.Size(350, 20);
            this.firstnametext.TabIndex = 0;
            this.firstnametext.TextChanged += new System.EventHandler(this.firstnametext_TextChanged);
            // 
            // PatientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1570, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DATADREDVIEPINTA);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATADREDVIEPINTA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView DATADREDVIEPINTA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox gendertext;
        public System.Windows.Forms.TextBox contacttext;
        public System.Windows.Forms.TextBox lastnametext;
        public System.Windows.Forms.TextBox firstnametext;
        private System.Windows.Forms.TextBox adresstext;
        public System.Windows.Forms.DateTimePicker dateperth;
        public System.Windows.Forms.TextBox textBoxserch;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
    }
}