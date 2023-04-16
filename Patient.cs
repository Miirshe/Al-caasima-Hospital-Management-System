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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Patient : UserControl
    {
        public Patient()
        {
            InitializeComponent();
        }
        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec proSelectionPatients", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                PatientDataGrid.DataSource = da;
            }

        }

        public void Clears()
        {
            PatName.Text = " ";
            PatPhone.Text = " ";
            comboPatGender.Text = " ";
            comboBlood.Text = " ";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = conClass.Connect())
            {

                try
                {
                    if (PatName.Text==""|| PatPhone.Text==""|| comboPatGender.Text==""|| comboBlood.Text==" ")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("proInsertPatient", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pat_name", PatName.Text);
                        cmd.Parameters.AddWithValue("@pat_phone", PatPhone.Text);
                        cmd.Parameters.AddWithValue("@pat_Gender", comboPatGender.Text);
                        cmd.Parameters.AddWithValue("@pat_blood", comboBlood.Text);
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Patient Saved ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            int pat_id = (int)PatientDataGrid.SelectedRows[0].Cells[0].Value;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (PatName.Text == "" || PatPhone.Text == "" || comboPatGender.Text == "" || comboBlood.Text == " ")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {
                        SqlCommand cmd = new SqlCommand("proUpdatePatient", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pat_name", PatName.Text);
                        cmd.Parameters.AddWithValue("@pat_phone", PatPhone.Text);
                        cmd.Parameters.AddWithValue("@pat_Gender", comboPatGender.Text);
                        cmd.Parameters.AddWithValue("@pat_blood", comboBlood.Text);
                        cmd.Parameters.AddWithValue("@pat_id", pat_id.ToString());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Patient Updated ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            int pat_id = (int)PatientDataGrid.SelectedRows[0].Cells[0].Value;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("proDeletPatient", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pat_id", pat_id.ToString());
                    cmd.ExecuteNonQuery();
                    FilldataGrid();
                    Clears();
                    MessageBox.Show("Successfully  Ptient  Deleted ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }

        private void PatientDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int pat_id = (int)PatientDataGrid.SelectedRows[0].Cells[0].Value;
            PatName.Text = PatientDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            PatPhone.Text = PatientDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            comboPatGender.Text = PatientDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            comboBlood.Text = PatientDataGrid.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            FilldataGrid();
            lblDisplay.Visible = false;
        }
        public void SearchPatientAppointDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {

                SqlDataAdapter reader = new SqlDataAdapter(" select * from patient where pat_id like '" + txtSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    PatientDataGrid.DataSource = dTable;
                    PatientDataGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    PatientDataGrid.Visible = false;
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
    }
}
