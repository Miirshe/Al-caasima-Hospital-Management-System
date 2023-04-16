using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public static string user;

        public Dashboard()
        {
            InitializeComponent();
        }
        //public Dashboard(string username, string type, Image img)
        //{
        //    InitializeComponent();
        //    lblPrintName.Text = username.ToUpper();
        //    lblPrintUser.Text = type.ToUpper();
        //    user = lblPrintName.Text;

        //}

        private void Dashboard_Load(object sender, EventArgs e)
        {
            home1.BringToFront();

        }

        private void panelSideLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            admin1.BringToFront();
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            nurse1.BringToFront();
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            reception1.BringToFront();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            doctor1.BringToFront();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            patient1.BringToFront();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            appointment1.BringToFront();
        }

        private void btnDocAppointment_Click(object sender, EventArgs e)
        {
            docApp1.BringToFront();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            diagnosis1.BringToFront();
        }

        private void btnResultDiagnosis_Click(object sender, EventArgs e)
        {
            re_diagnosis1.BringToFront();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            pharmacy1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResultDiagnosis_Click_1(object sender, EventArgs e)
        {
            re_diagnosis1.BringToFront();
        }

        private void btnDocAppointment_Click_1(object sender, EventArgs e)
        {
            docApp1.BringToFront();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            admin1.BringToFront();
        }

        private void btnDoctor_Click_1(object sender, EventArgs e)
        {
            doctor1.BringToFront();
        }

        private void btnNurse_Click_1(object sender, EventArgs e)
        {
            nurse1.BringToFront();
        }

        private void btnReception_Click_1(object sender, EventArgs e)
        {
            reception1.BringToFront();
        }

        private void btnPatient_Click_1(object sender, EventArgs e)
        {
            patient1.BringToFront();
        }

        private void btnAppointment_Click_1(object sender, EventArgs e)
        {
            appointment1.BringToFront();
        }

        private void btnDiagnosis_Click_1(object sender, EventArgs e)
        {
            diagnosis1.BringToFront();
        }

        private void btnPharmacy_Click_1(object sender, EventArgs e)
        {
            pharmacy1.BringToFront();
        }

        //private void ButtonColorChangeclick(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, Button btn7, Button btn8, Button btn9, Button btn10, Button btn11)
        //{
        //    btn1.BackColor = Color.FromArgb(85, 239, 196);
        //    btn2.BackColor = Color.FromArgb(48, 51, 107);
        //    btn3.BackColor = Color.FromArgb(48, 51, 107);
        //    btn4.BackColor = Color.FromArgb(48, 51, 107);
        //    btn5.BackColor = Color.FromArgb(48, 51, 107);
        //    btn6.BackColor = Color.FromArgb(48, 51, 107);
        //    btn7.BackColor = Color.FromArgb(48, 51, 107);
        //    btn8.BackColor = Color.FromArgb(48, 51, 107);
        //    btn9.BackColor = Color.FromArgb(48, 51, 107);
        //    btn10.BackColor = Color.FromArgb(48, 51, 107);
        //    btn11.BackColor = Color.FromArgb(48, 51, 107);

        //}

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            home1.BringToFront();
            //ButtonColorChangeclick(btnHome, btnAdmin, btnDoctor, btnNurse, btnReception, btnPatient, btnAppointment, btnDocAppointment, btnDiagnosis, btnResultDiagnosis, btnPharmacy);
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            AllPateint();
        }

        public void AllPateint()
        {
            using (SqlConnection conn = conClass.Connect())
            {
                
               
                SqlCommand cmd = new SqlCommand("readAllRDiag", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", int.Parse(comBoxMemberId.Text));
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable d_table = new DataTable();
                reader.Fill(d_table);
                CrAllPatein cr = new CrAllPatein();
                cr.SetDataSource(d_table);

                myPrints prl = new myPrints();
                prl.CRPrint.ReportSource = cr;
                prl.Show();

                conn.Close();
            }
                
           
        }

        public void SubPateint()
        {
            using (SqlConnection conn = conClass.Connect())
            {


                SqlCommand cmd = new SqlCommand("readSpecialRDiag", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id", int.Parse(comBoxMemberId.Text));
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable d_table = new DataTable();
                reader.Fill(d_table);
                CrAllPatein cr = new CrAllPatein();
                cr.SetDataSource(d_table);

                myPrints prl = new myPrints();
                prl.CRPrint.ReportSource = cr;
                prl.Show();

                conn.Close();
            }


        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void changeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatedProfile update = new UpdatedProfile();
            update.ShowDialog();
        }

        private void printAll1_Load(object sender, EventArgs e)
        {

        }
    }
}
