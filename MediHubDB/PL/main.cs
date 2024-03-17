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
    public partial class main : Form
    {   BL.Appointments pl=new BL.Appointments();
        BL.RecoveryTrackingform tr = new BL.RecoveryTrackingform();
        PL.login lo =new PL.login();    

        BL.Surgeries ser = new BL.Surgeries();
        private static main frm;


        static void frm_closed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static main getmsinform
        {

            get
            {


                if (frm == null)
                {

                    frm = new main();
                    frm.FormClosed += new FormClosedEventHandler(frm_closed);

                }

                return frm;

            }


        }








        public main()
        {
            InitializeComponent();




            if (frm == null)
            {
                frm = this;
            }
             
            this.button21.Enabled = false;
            this.button12.Enabled = false;
            this.button13.Enabled = false;
            this.button14.Enabled = false;
            this.button15.Enabled = false;

            this.button17.Enabled = false;
            this.button18.Enabled = false;
            this.button19.Enabled = false;
            this.button20.Enabled = false;
            this.button21.Enabled = false;
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
            this.button10.Enabled = false;
            this.button11.Enabled = false;
            this.button12.Enabled = false;
            this.button22.Enabled = false;
            this.button23.Enabled = false;
            this.button19.Enabled = false;
            this.button17.Enabled = false;
            this.button18.Enabled = false;
            this.button20.Enabled = false;
            this.button25.Enabled = false;
            this.button13.Enabled = false;
            this.button14.Enabled = false;
            this.button24.Enabled = false;







            label8.Text = pl.GetPatientAppointmentsCount().ToString();
            label4.Text = pl.GetPatientAppointmentsCount().ToString();
            label3.Text = tr.GetPatientTrackingCountForToday().ToString();
            label10.Text = ser.GetAllSurgeriesCountForToday().ToString();












        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            RecoveryTrackingform recoveryTrackingform = new RecoveryTrackingform();
            recoveryTrackingform.ShowDialog();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DoctorManagementForm doc = new DoctorManagementForm();  
            doc.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PatientManager patientManager = new PatientManager();   
            patientManager.ShowDialog();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm manageAppointmentsForm = new ManageAppointmentsForm();
            manageAppointmentsForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MedicationManagementForm medicationManagementForm = new MedicationManagementForm(); 
            medicationManagementForm.ShowDialog();  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MedicalImagingForm medicalImagingForm = new MedicalImagingForm();   
            medicalImagingForm.ShowDialog();    
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LabTestsForm labTestsForm = new LabTestsForm(); 
            labTestsForm.ShowDialog();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RecoveryTrackingform recoveryTrackingform = new RecoveryTrackingform();
                    recoveryTrackingform.ShowDialog();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prescriptionsmanagmentform prescriptionsmanagmentform = new Prescriptionsmanagmentform();
            prescriptionsmanagmentform.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Surgeriesform surgeriesform = new Surgeriesform();
            surgeriesform.ShowDialog(); 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MedicalReportsForm medicalReportsForm = new MedicalReportsForm();
            medicalReportsForm.ShowDialog();    
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hospitalsform hospitalsform = new Hospitalsform();
            hospitalsform.ShowDialog(); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            InvoiceManagerForm invoiceManagerForm = new InvoiceManagerForm();
            invoiceManagerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Backup File (*.bak)|*.bak";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = saveFileDialog.FileName;

                        // استدعاء الدالة وتمرير المسار
                        pl.BackupDatabase(backupPath);


                        //  MessageBox.Show("تم إنشاء نسخة احتياطية بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء عملية النسخ الاحتياطي: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            usermanagment us = new usermanagment(); 
            us.ShowDialog();    
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            label8.Text = pl.GetPatientAppointmentsCount().ToString();
            label4.Text = pl.GetPatientAppointmentsCount().ToString();
            label3.Text = tr.GetPatientTrackingCountForToday().ToString();
            label10.Text = ser.GetAllSurgeriesCountForToday().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            lo.ShowDialog();    
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Backup File (*.bak)|*.bak";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = saveFileDialog.FileName;

                        // استدعاء الدالة وتمرير المسار

                        pl.RestoreDatabase(backupPath);


                        //  MessageBox.Show("تم إنشاء نسخة احتياطية بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء عملية النسخ الاحتياطي: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            PatientManager patientManager = new PatientManager();
            patientManager.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ManageAppointmentsForm manageAppointmentsForm = new ManageAppointmentsForm();
            manageAppointmentsForm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Surgeriesform surgeriesform = new Surgeriesform();
            surgeriesform.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Prescriptionsmanagmentform prescriptionsmanagmentform = new Prescriptionsmanagmentform();
            prescriptionsmanagmentform.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            MedicalImagingForm medicalImagingForm = new MedicalImagingForm();
            medicalImagingForm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            LabTestsForm labTestsForm = new LabTestsForm();
            labTestsForm.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Prescriptionsmanagmentform prescriptionsmanagmentform = new Prescriptionsmanagmentform();
            prescriptionsmanagmentform.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
