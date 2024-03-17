namespace MediHubDB.PL
{
    partial class printreportform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printreportform));
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.docname = new System.Windows.Forms.Label();
            this.spesv = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idtex = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.age1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.phon = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.addres = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sex1 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pantname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(244, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "طباعة";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(511, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "مشاهدة";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F);
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(86, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 34);
            this.label9.TabIndex = 3;
            this.label9.Text = "الاختصاص";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(547, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = ": الدكتور";
            // 
            // docname
            // 
            this.docname.AutoSize = true;
            this.docname.BackColor = System.Drawing.Color.White;
            this.docname.Font = new System.Drawing.Font("Old Antic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.docname.ForeColor = System.Drawing.Color.Black;
            this.docname.Location = new System.Drawing.Point(546, 62);
            this.docname.Name = "docname";
            this.docname.Size = new System.Drawing.Size(80, 40);
            this.docname.TabIndex = 1;
            this.docname.Text = ": الدكتور";
            // 
            // spesv
            // 
            this.spesv.AutoSize = true;
            this.spesv.BackColor = System.Drawing.Color.White;
            this.spesv.Font = new System.Drawing.Font("Old Antic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.spesv.ForeColor = System.Drawing.Color.Black;
            this.spesv.Location = new System.Drawing.Point(62, 62);
            this.spesv.Name = "spesv";
            this.spesv.Size = new System.Drawing.Size(80, 40);
            this.spesv.TabIndex = 2;
            this.spesv.Text = "الاختصاص";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.idtex);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.docname);
            this.panel4.Controls.Add(this.spesv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(669, 121);
            this.panel4.TabIndex = 9;
            // 
            // idtex
            // 
            this.idtex.Location = new System.Drawing.Point(239, 62);
            this.idtex.Name = "idtex";
            this.idtex.Size = new System.Drawing.Size(100, 24);
            this.idtex.TabIndex = 4;
            this.idtex.Visible = false;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(385, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "اعدادات";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(-1, 54);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(669, 1);
            this.panel7.TabIndex = 13;
            // 
            // age1
            // 
            this.age1.AutoSize = true;
            this.age1.BackColor = System.Drawing.Color.White;
            this.age1.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.age1.ForeColor = System.Drawing.Color.Black;
            this.age1.Location = new System.Drawing.Point(447, 40);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(58, 29);
            this.age1.TabIndex = 12;
            this.age1.Text = ": الدكتور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(307, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "التشخيص";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.BackColor = System.Drawing.Color.White;
            this.sex.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.sex.ForeColor = System.Drawing.Color.Black;
            this.sex.Location = new System.Drawing.Point(319, 117);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(48, 29);
            this.sex.TabIndex = 10;
            this.sex.Text = "stat";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(97, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 685);
            this.panel3.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 284);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(669, 319);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.mobile);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.phon);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.addres);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 603);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(669, 82);
            this.panel6.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(203, -520);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 35);
            this.label17.TabIndex = 3;
            this.label17.Text = "الاختصاص";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.BackColor = System.Drawing.Color.White;
            this.mobile.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.mobile.ForeColor = System.Drawing.Color.Black;
            this.mobile.Location = new System.Drawing.Point(54, 46);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(58, 29);
            this.mobile.TabIndex = 18;
            this.mobile.Text = ": الدكتور";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mudir MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(594, -521);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 35);
            this.label16.TabIndex = 0;
            this.label16.Text = ": الدكتور";
            // 
            // phon
            // 
            this.phon.AutoSize = true;
            this.phon.BackColor = System.Drawing.Color.White;
            this.phon.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.phon.ForeColor = System.Drawing.Color.Black;
            this.phon.Location = new System.Drawing.Point(282, 46);
            this.phon.Name = "phon";
            this.phon.Size = new System.Drawing.Size(58, 29);
            this.phon.TabIndex = 17;
            this.phon.Text = ": الدكتور";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(57, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 34);
            this.label13.TabIndex = 16;
            this.label13.Text = "رقم الطبيب";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(293, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 34);
            this.label12.TabIndex = 15;
            this.label12.Text = "رقم العيادة";
            // 
            // addres
            // 
            this.addres.AutoSize = true;
            this.addres.BackColor = System.Drawing.Color.White;
            this.addres.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.addres.ForeColor = System.Drawing.Color.Black;
            this.addres.Location = new System.Drawing.Point(510, 46);
            this.addres.Name = "addres";
            this.addres.Size = new System.Drawing.Size(58, 29);
            this.addres.TabIndex = 14;
            this.addres.Text = ": الدكتور";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(551, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 34);
            this.label11.TabIndex = 13;
            this.label11.Text = "عنوان العيادة";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.sex1);
            this.panel5.Controls.Add(this.c);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.age1);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.sex);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.statu);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.pantname);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 121);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(669, 163);
            this.panel5.TabIndex = 10;
            // 
            // sex1
            // 
            this.sex1.AutoSize = true;
            this.sex1.BackColor = System.Drawing.Color.White;
            this.sex1.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.sex1.ForeColor = System.Drawing.Color.Black;
            this.sex1.Location = new System.Drawing.Point(166, 40);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(58, 29);
            this.sex1.TabIndex = 15;
            this.sex1.Text = ": الدكتور";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.c.Location = new System.Drawing.Point(177, 6);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(51, 34);
            this.c.TabIndex = 14;
            this.c.Text = "الجنس";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(458, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = " العمر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F);
            this.label5.Location = new System.Drawing.Point(567, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "اسم المريض";
            // 
            // statu
            // 
            this.statu.AutoSize = true;
            this.statu.BackColor = System.Drawing.Color.White;
            this.statu.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.statu.ForeColor = System.Drawing.Color.Black;
            this.statu.Location = new System.Drawing.Point(28, 40);
            this.statu.Name = "statu";
            this.statu.Size = new System.Drawing.Size(58, 29);
            this.statu.TabIndex = 8;
            this.statu.Text = ": الدكتور";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Old Antic Outline Shaded", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(15, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 34);
            this.label8.TabIndex = 7;
            this.label8.Text = "رقم الاضبارة";
            // 
            // pantname
            // 
            this.pantname.AutoSize = true;
            this.pantname.BackColor = System.Drawing.Color.White;
            this.pantname.Font = new System.Drawing.Font("Old Antic Bold", 11.25F);
            this.pantname.ForeColor = System.Drawing.Color.Black;
            this.pantname.Location = new System.Drawing.Point(593, 40);
            this.pantname.Name = "pantname";
            this.pantname.Size = new System.Drawing.Size(32, 29);
            this.pantname.TabIndex = 5;
            this.pantname.Text = "العمر";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 759);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 60);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 62);
            this.panel1.TabIndex = 3;
            // 
            // printreportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 819);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "printreportform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "printreportform";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label docname;
        public System.Windows.Forms.Label spesv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label age1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label sex;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label phon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label addres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label statu;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label pantname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox idtex;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label sex1;
        private System.Windows.Forms.Label c;
    }
}