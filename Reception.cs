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
    public partial class Reception : UserControl
    {
        public static string ImageName;
        public static string type;
        public static Image img;
        public Reception()
        {
            InitializeComponent();
        }
        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec Selectionreception ", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                ReceptionDataGrid.DataSource = da;
            }

        }
        public void Clears()
        {
            RecepName.Text = ""; 
            RecepUser.Text = " ";
            RecepPassword.Text = " ";
            RecepSecQue.Text = "";
            RecepSecAns.Text = " ";
            RecepPhone.Text = "";
            comboGender.SelectedValue = "";
            RecepSalary.Text = " ";
            picture.Image = null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string phone = RecepPhone.Text;
            string salary = RecepSalary.Text;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (RecepName.Text.Trim().StartsWith("~") ||
                      RecepName.Text.Trim().StartsWith("!") || RecepName.Text.Trim().StartsWith("@") ||
                      RecepName.Text.Trim().StartsWith("$") || RecepName.Text.Trim().StartsWith("%") ||
                      RecepName.Text.Trim().StartsWith("^") || RecepName.Text.Trim().StartsWith("&") ||
                      RecepName.Text.Trim().StartsWith("*") || RecepName.Text.Trim().StartsWith("(") ||
                      RecepName.Text.Trim().StartsWith(")") || RecepName.Text.Trim().StartsWith("_") ||
                      RecepName.Text.Trim().StartsWith("+") || RecepName.Text.Trim().StartsWith(",") ||
                      RecepName.Text.Trim().StartsWith(".") || RecepName.Text.Trim().StartsWith("?") ||
                      RecepName.Text.Trim().StartsWith(";") || RecepName.Text.Trim().StartsWith("'") ||
                      RecepName.Text.Trim().StartsWith("1") || RecepName.Text.Trim().StartsWith("2") ||
                      RecepName.Text.Trim().StartsWith("3") || RecepName.Text.Trim().StartsWith("4") ||
                      RecepName.Text.Trim().StartsWith("5") || RecepName.Text.Trim().StartsWith("6") ||
                      RecepName.Text.Trim().StartsWith("7") || RecepName.Text.Trim().StartsWith("8") ||
                      RecepName.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepName.Focus();
                    }
                    else if (RecepUser.Text.Trim().StartsWith("~") || RecepUser.Text.Trim().StartsWith("!") ||
                      RecepUser.Text.Trim().StartsWith("@") || RecepUser.Text.Trim().StartsWith("-") ||
                      RecepUser.Text.Trim().StartsWith("#") || RecepUser.Text.Trim().StartsWith(",") ||
                      RecepUser.Text.Trim().StartsWith("$") || RecepUser.Text.Trim().StartsWith(".") ||
                      RecepUser.Text.Trim().StartsWith("%") || RecepUser.Text.Trim().StartsWith("<") ||
                      RecepUser.Text.Trim().StartsWith("^") || RecepUser.Text.Trim().StartsWith(">") ||
                      RecepUser.Text.Trim().StartsWith("&") || RecepUser.Text.Trim().StartsWith(".") ||
                      RecepUser.Text.Trim().StartsWith("*") || RecepUser.Text.Trim().StartsWith("'") ||
                      RecepUser.Text.Trim().StartsWith("(") || RecepUser.Text.Trim().StartsWith("?") ||
                      RecepUser.Text.Trim().StartsWith(")") || RecepUser.Text.Trim().StartsWith("|") ||
                      RecepUser.Text.Trim().StartsWith("_") || RecepUser.Text.Trim().StartsWith("1") ||
                      RecepUser.Text.Trim().StartsWith("=") || RecepUser.Text.Trim().StartsWith("2") ||
                      RecepUser.Text.Trim().StartsWith("+") || RecepUser.Text.Trim().StartsWith("3") ||
                      RecepUser.Text.Trim().StartsWith("4") || RecepUser.Text.Trim().StartsWith("5") ||
                      RecepUser.Text.Trim().StartsWith("6") || RecepUser.Text.Trim().StartsWith("7") ||
                      RecepUser.Text.Trim().StartsWith("8") || RecepUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Nurse Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepUser.Focus();
                    }
                    else if (RecepPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Reception  password  never less than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPassword.Focus();
                    }
                    else if (RecepPassword.Text.Length > 15)
                    {
                        MessageBox.Show(" Reception  password  never greater than  with 15 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPassword.Focus();
                    }
                    else if (RecepSecQue.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecepSecQue.Focus();
                    }
                    else if (RecepSecAns.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecepSecAns.Focus();
                    }

                    else if (RecepPhone.Text.Length < 9)
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPhone.Focus();
                    }
                    else if (RecepPhone.Text.Length > 14)
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPhone.Focus();
                    }
                    else if (HasCharacter(RecepPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPhone.Focus();
                    }
                    else if (comboGender.Text == "")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboGender.Focus();
                    }

                    else if (RecepSalary.Text == "")

                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepSalary.Focus();
                    }
                    else if (HasCharacter(RecepSalary.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepSalary.Focus();
                    }

                    else if (picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picture.Focus();
                    }

                    else
                    {
                        SqlCommand cmd = new SqlCommand("InsertReception", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recep_name", RecepName.Text);
                        cmd.Parameters.AddWithValue("@recep_user", RecepUser.Text);
                        cmd.Parameters.AddWithValue("@recep_pass", RecepPassword.Text);
                        cmd.Parameters.AddWithValue("@recep_sec_que", RecepSecQue.Text);
                        cmd.Parameters.AddWithValue("@recep_sec_ans", RecepSecAns.Text);
                        cmd.Parameters.AddWithValue("@recep_phone", RecepPhone.Text);
                        cmd.Parameters.AddWithValue("@recep_gender", comboGender.Text);
                        cmd.Parameters.AddWithValue("@recep_salary", RecepSalary.Text);
                        cmd.Parameters.AddWithValue("@recep_image", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Reception Updated ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "Image File(*.jpg;*.jpeg;*.bmo;*.gif;*.png;*.jfif;) | *.jpg;*.jpeg;*.bmo;*.gif;*.png*.jfif;";
            try
            {
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    ImageName = fd.FileName;
                    Bitmap newImg = new Bitmap(ImageName);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Image = (Image)newImg;
                }
                fd = null;
            }
            catch (System.ArgumentException ae)
            {
                ImageName = " ";
                MessageBox.Show(ae.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static MemoryStream ImageToStreem(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms;

        }


        public static Image getImage(object reader)
        {

            var ms = new MemoryStream((byte[])reader);
            Image img = Image.FromStream(ms);
            return img;
        }

        private Image getUserImage(int id)
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand command = new SqlCommand("searchTestimageReception", con);
                command.Parameters.AddWithValue("@recep_id", id);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                reader.Read();
                var img = getImage(reader[0]);
                return img;
            }
        }

        private void ReceptionDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)ReceptionDataGrid.SelectedRows[0].Cells[0].Value;
            RecepName.Text = ReceptionDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            RecepUser.Text = ReceptionDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            RecepPassword.Text = ReceptionDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            RecepSecQue.Text = ReceptionDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            RecepSecAns.Text = ReceptionDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            RecepPhone.Text = ReceptionDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            comboGender.Text = ReceptionDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            RecepSalary.Text = ReceptionDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = getUserImage(id);







        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)ReceptionDataGrid.SelectedRows[0].Cells[0].Value;
            string phone = RecepPhone.Text;
            string salary = RecepSalary.Text;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (RecepName.Text.Trim().StartsWith("~") ||
                      RecepName.Text.Trim().StartsWith("!") || RecepName.Text.Trim().StartsWith("@") ||
                      RecepName.Text.Trim().StartsWith("$") || RecepName.Text.Trim().StartsWith("%") ||
                      RecepName.Text.Trim().StartsWith("^") || RecepName.Text.Trim().StartsWith("&") ||
                      RecepName.Text.Trim().StartsWith("*") || RecepName.Text.Trim().StartsWith("(") ||
                      RecepName.Text.Trim().StartsWith(")") || RecepName.Text.Trim().StartsWith("_") ||
                      RecepName.Text.Trim().StartsWith("+") || RecepName.Text.Trim().StartsWith(",") ||
                      RecepName.Text.Trim().StartsWith(".") || RecepName.Text.Trim().StartsWith("?") ||
                      RecepName.Text.Trim().StartsWith(";") || RecepName.Text.Trim().StartsWith("'") ||
                      RecepName.Text.Trim().StartsWith("1") || RecepName.Text.Trim().StartsWith("2") ||
                      RecepName.Text.Trim().StartsWith("3") || RecepName.Text.Trim().StartsWith("4") ||
                      RecepName.Text.Trim().StartsWith("5") || RecepName.Text.Trim().StartsWith("6") ||
                      RecepName.Text.Trim().StartsWith("7") || RecepName.Text.Trim().StartsWith("8") ||
                      RecepName.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepName.Focus();
                    }
                    else if (RecepUser.Text.Trim().StartsWith("~") || RecepUser.Text.Trim().StartsWith("!") ||
                      RecepUser.Text.Trim().StartsWith("@") || RecepUser.Text.Trim().StartsWith("-") ||
                      RecepUser.Text.Trim().StartsWith("#") || RecepUser.Text.Trim().StartsWith(",") ||
                      RecepUser.Text.Trim().StartsWith("$") || RecepUser.Text.Trim().StartsWith(".") ||
                      RecepUser.Text.Trim().StartsWith("%") || RecepUser.Text.Trim().StartsWith("<") ||
                      RecepUser.Text.Trim().StartsWith("^") || RecepUser.Text.Trim().StartsWith(">") ||
                      RecepUser.Text.Trim().StartsWith("&") || RecepUser.Text.Trim().StartsWith(".") ||
                      RecepUser.Text.Trim().StartsWith("*") || RecepUser.Text.Trim().StartsWith("'") ||
                      RecepUser.Text.Trim().StartsWith("(") || RecepUser.Text.Trim().StartsWith("?") ||
                      RecepUser.Text.Trim().StartsWith(")") || RecepUser.Text.Trim().StartsWith("|") ||
                      RecepUser.Text.Trim().StartsWith("_") || RecepUser.Text.Trim().StartsWith("1") ||
                      RecepUser.Text.Trim().StartsWith("=") || RecepUser.Text.Trim().StartsWith("2") ||
                      RecepUser.Text.Trim().StartsWith("+") || RecepUser.Text.Trim().StartsWith("3") ||
                      RecepUser.Text.Trim().StartsWith("4") || RecepUser.Text.Trim().StartsWith("5") ||
                      RecepUser.Text.Trim().StartsWith("6") || RecepUser.Text.Trim().StartsWith("7") ||
                      RecepUser.Text.Trim().StartsWith("8") || RecepUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Nurse Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepUser.Focus();
                    }
                    else if (RecepPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Reception  password  never less than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPassword.Focus();
                    }
                    else if(RecepPassword.Text.Length > 15)
                    {
                        MessageBox.Show(" Reception  password  never greater than  with 15 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPassword.Focus();
                    }
                    else if (RecepSecQue.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecepSecQue.Focus();
                    }
                    else if (RecepSecAns.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RecepSecAns.Focus();
                    }

                    else if (RecepPhone.Text.Length < 9)
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPhone.Focus();
                    }
                    else if (RecepPhone.Text.Length > 14)
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPhone.Focus();
                    }
                    else if (HasCharacter(RecepPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepPhone.Focus();
                    }
                    else if (comboGender.Text=="")
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboGender.Focus();
                    }

                    else if (RecepSalary.Text == "")

                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepSalary.Focus();
                    }
                    else if (HasCharacter(RecepSalary.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        RecepSalary.Focus();
                    }

                    else if (picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picture.Focus();
                    }

                    else
                    {
                        SqlCommand cmd = new SqlCommand("UpdateReception", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@recep_id", id.ToString());
                        cmd.Parameters.AddWithValue("@recep_name", RecepName.Text);
                        cmd.Parameters.AddWithValue("@recep_user", RecepUser.Text);
                        cmd.Parameters.AddWithValue("@recep_pass", RecepPassword.Text);
                        cmd.Parameters.AddWithValue("@recep_sec_que", RecepSecQue.Text);
                        cmd.Parameters.AddWithValue("@recep_sec_ans", RecepSecAns.Text);
                        cmd.Parameters.AddWithValue("@recep_phone", RecepPhone.Text);
                        cmd.Parameters.AddWithValue("@recep_gender", comboGender.Text);
                        cmd.Parameters.AddWithValue("@recep_salary", RecepSalary.Text);
                        cmd.Parameters.AddWithValue("@recep_image", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Reception Updated ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            int id = (int)ReceptionDataGrid.SelectedRows[0].Cells[0].Value;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Deleteeception", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@recep_id", id.ToString());
                    cmd.ExecuteNonQuery();
                    FilldataGrid();
                    Clears();
                    MessageBox.Show("Successfully Reception Deletd ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }

        private void Reception_Load(object sender, EventArgs e)
        {
            FilldataGrid();
            lblDisplay.Visible = false;
        }

        public bool HasCharacter(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone, i)||phone.Length<9 &&phone.Length>14)
                {
                    return true;
                }

            }
            return false;
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        public void SearchPatientAppointDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {

                SqlDataAdapter reader = new SqlDataAdapter(" select recep_id,recep_name,recep_user ,recep_pass,recep_sec_que,recep_sec_ans,recep_phone,recep_gender,recep_user_type,recep_salary from receptions where recep_id like'" + txtSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    ReceptionDataGrid.DataSource = dTable;
                    ReceptionDataGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    ReceptionDataGrid.Visible = false;
                    lblDisplay.Visible = true;
                }

            }

        }

        private void Reception_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void Reception_Leave(object sender, EventArgs e)
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
