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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        public void FilldataGridNurse()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("select count(*) from nurse", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                lblPrintNurse.Text += da.Rows[0][0].ToString();
            }

        }

        public void FilldataGridReception()
        {

            using (SqlConnection con =conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("select count(*) from receptions", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                lblPrintReception.Text += da.Rows[0][0].ToString();
            }

        }

        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("select count(*) from doctor", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                lblPrintDoctor.Text = da.Rows[0][0].ToString();
            }

        }
        public void FilldataGridPatient()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("select count(*) from patient", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                lblPrintPatient.Text += da.Rows[0][0].ToString();
            }

        }


        public void FilldataGridDiagnosis()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("select count(*) from Diagnosis", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                lblPrintDiagnosis.Text += da.Rows[0][0].ToString();
            }

        }


        public void FilldataGridAppointments()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("select count(*) from Appointmentss", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                lblprintAppointment.Text += da.Rows[0][0].ToString();
            }

        }


        private void Home_Load(object sender, EventArgs e)
        {
            FilldataGrid();
            FilldataGridNurse();
            FilldataGridPatient();
            FilldataGridReception();
            SubDoctorDataGrid();
            SubDoctorAppDataGrid();
            FilldataGridDiagnosis();
            FilldataGridAppointments();
            lbl_display.Visible = false;
            patientPointmentDisplay.Visible = false;
        }
        public void SubDoctorDataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec proSelectedTotalDoctor", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                DiagnosisDataGrid.DataSource = da;
            }

        }

        public void SubDoctorAppDataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec proSelectionSubAppointmentssPatient ", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                AppointDataGrid.DataSource = da;
            }

        }

        public void SearchDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select doc_id ,doc_name, doc_spec from doctor where  doc_id LIKE'" + DoctorSearch.Text + "' ", con);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    DiagnosisDataGrid.DataSource = dTable;
                    DiagnosisDataGrid.Visible = true;
                    lbl_display.Visible = false;
                }
                else
                {
                    DiagnosisDataGrid.Visible = false;
                    lbl_display.Visible = true;
                }



                cmd.ExecuteNonQuery();


            }
        }
        

        public void SearchPatientAppointDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {
                
                SqlDataAdapter reader = new SqlDataAdapter("select   pat_App_id,pat_App_name, doc_App_name from Appointmentss where   pat_App_id  LIKE'" + AppointmentSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    AppointDataGrid.DataSource = dTable;
                    AppointDataGrid.Visible = true;
                    patientPointmentDisplay.Visible = false;
                }
                else
                {
                    AppointDataGrid.Visible = false;
                    patientPointmentDisplay.Visible = true;
                }

            }

        }
        
        private void DoctorSearch_TextChanged(object sender, EventArgs e)
        {
            if (DoctorSearch.Text != "")
            {
                SearchDoctor();
            }
            else
            {
                lbl_display.Visible = false;
                DoctorSearch.Visible = true;
            }


            
        }

        private void AppointmentSearch_TextChanged(object sender, EventArgs e)
        {

            if (AppointmentSearch.Text != "")
            {
                SearchPatientAppointDoctor();
            }
            else
            {
                lbl_display.Visible = false;
                DoctorSearch.Visible = true;
            }
            
        }

        private void AppointDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoctorSearch_Enter(object sender, EventArgs e)
        {
            if (DoctorSearch.Text == "Search")
            {
                DoctorSearch.Clear();
                DoctorSearch.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void DoctorSearch_Leave(object sender, EventArgs e)
        {
            if (DoctorSearch.Text == "")
            {
                DoctorSearch.Text = "Search";
                DoctorSearch.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void AppointmentSearch_Enter(object sender, EventArgs e)
        {
            if (AppointmentSearch.Text == "Search")
            {
                AppointmentSearch.Clear();
                AppointmentSearch.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void AppointmentSearch_Leave(object sender, EventArgs e)
        {
            if (AppointmentSearch.Text == "")
            {
                AppointmentSearch.Text = "Search";
                AppointmentSearch.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void lbl_display_Click(object sender, EventArgs e)
        {

        }
    }
}
