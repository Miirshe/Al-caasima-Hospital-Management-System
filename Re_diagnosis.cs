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
    public partial class Re_diagnosis : UserControl
    {
        public Re_diagnosis()
        {
            InitializeComponent();
        }

        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec proSelectionResultDiagnosis ", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                DiagnosisDataGrid.DataSource = da;
            }

        }
        public void Clears()
        {
            comboPatientID.Text = " ";
            PatName.Text = " ";
            DocName.Text = "";
            ComboDiagDisease.Text = " ";
            comboPatStatus.Text = " ";
            txtPatientSysmptoms.Text = " ";
            txtPatMedicine.Text = " ";

        }

        private void DiagnosisDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboPatientID.Text = DiagnosisDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = DiagnosisDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            DocName.Text = DiagnosisDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            ComboDiagDisease.Text = DiagnosisDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            comboPatStatus.Text = DiagnosisDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            txtPatientSysmptoms.Text = DiagnosisDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            txtPatMedicine.Text= DiagnosisDataGrid.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (comboPatientID.Text == "" || PatName.Text == "" ||  DocName.Text == "" || ComboDiagDisease.Text == "" || comboPatStatus.Text == " " || txtPatientSysmptoms.Text == ""|| txtPatMedicine.Text==" ")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec proInsertResultDiagnosis '" + int.Parse(comboPatientID.Text) + "','" + PatName.Text + "' ,'" + DocName.Text + "','" + ComboDiagDisease.Text + "','" + comboPatStatus.Text + "','" + txtPatientSysmptoms.Text + "','"+txtPatMedicine.Text+"'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Result Diagonsis has been successfully saved....✔✔....", "SavedInformation ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (comboPatientID.Text == "" || PatName.Text == "" || DocName.Text == "" || ComboDiagDisease.Text == "" || comboPatStatus.Text == " " || txtPatientSysmptoms.Text == "" || txtPatMedicine.Text == " ")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec  proUpdateResultDiagnosis '" + int.Parse(comboPatientID.Text) + "','" + PatName.Text + "','" + DocName.Text + "','" + ComboDiagDisease.Text + "','" + comboPatStatus.Text + "','" + txtPatientSysmptoms.Text + "','" + txtPatMedicine.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Result Diagonsis  has been successfully Updated....✔✔....", "SavedInformation ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Please Enter Result Diagnosis ID  to delete ");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec  proDeleteResultDiagnosis  '" + int.Parse(comboPatientID.Text) + "' ", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Result Diagonsis has been successfully Deleted....✔✔.....", "Saved Information ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void fillDataComboPatientID()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select * from Diagnosis", con);
                SqlDataReader dataReader;
                try
                {
                    DataTable dataTl = new DataTable();
                    dataTl.Columns.Add("app_id", typeof(int));
                    dataReader = cmd.ExecuteReader();
                    dataTl.Load(dataReader);
                    comboPatientID.ValueMember = "app_id";
                    comboPatientID.DataSource = dataTl;

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void Re_diagnosis_Load(object sender, EventArgs e)
        {
            fillDataComboPatientID();
            FilldataGrid();
            lblDisplay.Visible = false;
        }

        String Pat_Name;

        void fillDataPatientName()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select * from Diagnosis where app_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["pat_name"].ToString();
                        PatName.Text = Pat_Name;
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
                    SqlCommand cmd = new SqlCommand(" select * from  Diagnosis where app_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["doc_name"].ToString();
                        DocName.Text = Pat_Name;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }


        void fillDataPatientDiagnosis()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from  Diagnosis where app_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["pat_Diagnosis_disease"].ToString();
                        ComboDiagDisease.Text = Pat_Name;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }


        void fillDataPatientStatus()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from  Diagnosis where app_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["pat_status"].ToString();
                        comboPatStatus.Text = Pat_Name;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }


        void fillDataPatientsysptoms()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from  Diagnosis where app_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["pat_symptoms"].ToString();
                        txtPatientSysmptoms.Text = Pat_Name;
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
            fillDataDoctorName();
            fillDataPatientDiagnosis();
            fillDataPatientsysptoms();
            fillDataPatientDiagnosis();
            fillDataPatientStatus();
        }

        private void PatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientSysmptoms_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPatStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboDiagDisease_TextChanged(object sender, EventArgs e)
        {

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

        public void SearchPatientAppointDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {

                SqlDataAdapter reader = new SqlDataAdapter("    select * from ResultDiagnosis where p_id like   '" + txtSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    DiagnosisDataGrid.DataSource = dTable;
                    DiagnosisDataGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    DiagnosisDataGrid.Visible = false;
                    lblDisplay.Visible = true;
                }

            }
        }

    }
}
