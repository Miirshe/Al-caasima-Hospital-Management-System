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
    public partial class DocApp : UserControl
    {
        public static string doc_spec;
        public DocApp()
        {
            InitializeComponent();
        }

        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec proSelectionDocApp ", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                DocAppDataGrid.DataSource = da;
            }

        }

        public void FilldataGridPatient()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("  select pat_App_id,pat_App_name,pat_App_Gender,doc_App_name from Appointmentss where doc_App_Spec='"+doc_spec+"' ", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                PatientGrid.DataSource = da;
            }

        }

        public void Clears()
        {
            comboPatientID.Text = " ";
            PatName.Text = " ";
            comboPatGender.Text = " ";
            comboSpec.Text = "";
            DocName.Text = "";
            ComboDiagDisease.SelectedItem = " ";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (comboPatientID.Text == "" || PatName.Text == "" || comboPatGender.Text == "" || comboSpec.Text == "" || DocName.Text == "" || ComboDiagDisease.Text == "")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec  proInsertDocApp '" + int.Parse(comboPatientID.Text) + "','" + PatName.Text + "','" + comboPatGender.Text + "','" + comboSpec.Text + "' ,'" + DocName.Text + "','"+ComboDiagDisease.Text+"'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Appointment has been successfully saved.....✔✔....", "SavedInformation ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FilldataGrid();
                        Clears();
                    }


                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (comboPatientID.Text == "" || PatName.Text == "" || comboPatGender.Text == "" || comboSpec.Text == "" || DocName.Text == "" || ComboDiagDisease.Text == "")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec  proUpdateDocApp '" + int.Parse(comboPatientID.Text) + "','" + PatName.Text + "','" + comboPatGender.Text + "','" + comboSpec.Text + "' ,'" + DocName.Text + "','" + ComboDiagDisease.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Appointment has been successfully Updated....✔✔.....", "SavedInformation ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FilldataGrid();
                        Clears();
                    }


                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = conClass.Connect())
                {
                    if (comboPatientID.Text == "")
                    {
                        MessageBox.Show("Please Enter Nurse ID  to delete ");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec  proDeleteDocApps '" + int.Parse(comboPatientID.Text) + "' ", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Patient Appointments has been successfully Deleted....✔✔.....", "Saved Information ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FilldataGrid();
                        Clears();

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DocAppDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboPatientID.Text =DocAppDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = DocAppDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            comboPatGender.Text = DocAppDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            comboSpec.Text = DocAppDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            DocName.Text = DocAppDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            ComboDiagDisease.Text = DocAppDataGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void DocApp_Load(object sender, EventArgs e)
        {
            FilldataGrid();
            fillDataComboPatientID();
            FilldataGridPatient();
            lblDisplay.Visible = false;
        }
        public void fillDataComboPatientID()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("SubSelectionAppointmentss", con);
                cmd.CommandType = CommandType.StoredProcedure;
                if (doc_spec == null)
                {
                    cmd.Parameters.AddWithValue("@docType", "null");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@docType",doc_spec);
                }
                
                SqlDataReader dataReader;
                try
                {

                    DataTable dataTl = new DataTable();
                    dataTl.Columns.Add("pat_App_id", typeof(int));
                    dataReader = cmd.ExecuteReader();
                    dataTl.Load(dataReader);
                    comboPatientID.ValueMember = "pat_App_id";
                    comboPatientID.DataSource = dataTl;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }


        String Pat_Name;

        void fillDataPatientName()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from Appointmentss where pat_App_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["pat_App_name"].ToString();
                        PatName.Text = Pat_Name;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }




        void fillDataPatientGender()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from Appointmentss where pat_App_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["pat_App_Gender"].ToString();
                        comboPatGender.Text = Pat_Name;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }



        void fillDataDoctorSpec()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from Appointmentss where pat_App_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["doc_App_Spec"].ToString();
                        comboSpec.Text = Pat_Name;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }



        void fillDataDoctorName()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from Appointmentss where pat_App_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["doc_App_name"].ToString();
                        DocName.Text = Pat_Name;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void comboPatientID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillDataPatientName();
            fillDataPatientGender();
            fillDataDoctorSpec();
            fillDataDoctorName();
            lblDisplay.Visible = false;
        }

        private void PatientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboPatientID.Text = PatientGrid.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGrid.SelectedRows[0].Cells[1].Value.ToString();
            comboPatGender.Text = PatientGrid.SelectedRows[0].Cells[2].Value.ToString();
            comboSpec.Text = PatientGrid.SelectedRows[0].Cells[3].Value.ToString();
            DocName.Text = PatientGrid.SelectedRows[0].Cells[4].Value.ToString();
        }


        public void SearchPatientAppointDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {

                SqlDataAdapter reader = new SqlDataAdapter("  select  pat_App_id,pat_App_name,pat_App_Gender ,doc_App_Spec,doc_App_name from Appointmentss where pat_App_id like  '" + txtSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    PatientGrid.DataSource = dTable;
                    PatientGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    PatientGrid.Visible = false;
                    lblDisplay.Visible = true;
                }

            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                SearchPatientAppointDoctor();
            }
            else
            {
                lblDisplay.Visible = false;
                txtSearch.Visible = true;
            }
        }

        private void comboPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
