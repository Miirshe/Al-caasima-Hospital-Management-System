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
    public partial class Appointment : UserControl
    {
        public Appointment()
        {
            InitializeComponent();
        }

        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("proSelectionAppointmentss", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                AppointmentDataGrid.DataSource = da;
            }

        }
        public void Clears()
        {
            comboPatientID.Text = " ";
            PatName.Text = " ";
            comboPatGender.Text = " ";
            comboSpec.Text = "";
            DocName.Text = "";
            Card_Payment.Text = "";
            timeAppointment.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (comboPatientID.Text == "" || PatName.Text == "" || comboPatGender.Text == "" || comboSpec.Text == "" || DocName.Text == "" || Card_Payment.Text == "" || timeAppointment.Text == "")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec proAddAppointmentss '" + int.Parse(comboPatientID.Text) + "','" + PatName.Text+ "','" + comboPatGender.Text + "','" + comboSpec.Text + "' ,'" + DocName.Text + "','" + Card_Payment.Text + "','" + DateTime.Parse(timeAppointment.Text) + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Patient Appointment has been successfully saved ...✔✔...  ", "SavedInformation ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (comboPatientID.Text == "" || PatName.Text == "" || comboPatGender.Text == "" || comboSpec.Text == "" || DocName.Text == "" || Card_Payment.Text == "" || timeAppointment.Text == "")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec proUpdateAppointmentss '" + int.Parse(comboPatientID.Text) + "','" + PatName.Text + "','" + comboPatGender.Text + "','" + comboSpec.Text + "' ,'" + DocName.Text + "','" + Card_Payment.Text + "','" + DateTime.Parse(timeAppointment.Text) + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient Appointment has been successfully saved....✔✔...", "SavedInformation ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Please Enter Patient ID  to delete ");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(" exec  proDeleteAppointmentss '" + int.Parse(comboPatientID.Text) + "' ", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Patient Appointments has been successfully Deleted  ....  ✔✔ ....", "Saved Information ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void AppointmentDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboPatientID.Text = AppointmentDataGrid.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = AppointmentDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            comboPatGender.Text = AppointmentDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            comboSpec.Text = AppointmentDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            DocName.Text = AppointmentDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            Card_Payment.Text = AppointmentDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            timeAppointment.Text = AppointmentDataGrid.SelectedRows[0].Cells[6].Value.ToString();

        }

        public void DoctorSpec()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("exec SelectionDoctro", con);
                SqlDataReader dataReader;
                try
                {
                    DataTable dataTl = new DataTable();
                    dataTl.Columns.Add("doc_spec");
                    dataReader = cmd.ExecuteReader();
                    dataTl.Load(dataReader);
                    comboSpec.ValueMember = "doc_spec";
                    comboSpec.DataSource = dataTl;
                    FilldataGrid();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }


        String Pat_Name;

        void fillDataTxtDoctorName()
        {
            using (SqlConnection con = conClass.Connect())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand(" select * from doctor where doc_spec= '" + comboSpec.Text + "' ", con);
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

        private void comboSpec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillDataTxtDoctorName();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            DoctorSpec();
            FilldataGrid();
            fillDataComboPatientID();
            lblDisplay.Visible = false;
        }


        public void fillDataComboPatientID()
        {
            using (SqlConnection con  = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("exec  proSelectionPatients", con);
                SqlDataReader dataReader;
                try
                {

                    DataTable dataTl = new DataTable();
                    dataTl.Columns.Add("pat_id", typeof(int));
                    dataReader = cmd.ExecuteReader();
                    dataTl.Load(dataReader);
                    comboPatientID.ValueMember = "pat_id";
                    comboPatientID.DataSource = dataTl;
                    FilldataGrid();

                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }



        void fillDataTxtPatientName()
        {


            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(" select * from patient where pat_id=" + comboPatientID.Text + " ", con);
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


        public void fillData()
        {

            using (SqlConnection con = conClass.Connect())
            {
                try
                {

                    SqlCommand cmd = new SqlCommand("select * from patient where pat_id=" + comboPatientID.Text + " ", con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow drs in dt.Rows)
                    {
                        Pat_Name = drs["pat_Gender"].ToString();
                        comboPatGender.Text = Pat_Name;
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
            fillDataTxtPatientName();
            fillData();
        }

        private void comboPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public void SearchPatientAppointDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {

                SqlDataAdapter reader = new SqlDataAdapter(" select * from Appointmentss where pat_App_id like  '" + txtSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    AppointmentDataGrid.DataSource = dTable;
                    AppointmentDataGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    AppointmentDataGrid.Visible = false;
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
