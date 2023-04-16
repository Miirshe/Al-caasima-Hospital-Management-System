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
    public partial class Nurse : UserControl
    {

        public static string ImageName;
        public static string type;
        public static Image img;
        public Nurse()
        {
            InitializeComponent();
        }
        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec SelectionNurse ", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                NurseDataGrid.DataSource = da;
            }

        }

        public void Clears()
        {
            NurName.Text = " ";
            NurUser.Text = " "; 
            NurPassword.Text = "";
            NurSecQue.Text = "";
            NurSecAns.Text = "";
            NurPhone.Text = "";
            comboGender.Text = "";
            NurSalary.Text = "";
            comboSpec.Text = "";
            picture.Image = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (NurName.Text.Trim().StartsWith("~") ||
                       NurName.Text.Trim().StartsWith("!") || NurName.Text.Trim().StartsWith("@") ||
                       NurName.Text.Trim().StartsWith("$") || NurName.Text.Trim().StartsWith("%") ||
                       NurName.Text.Trim().StartsWith("^") || NurName.Text.Trim().StartsWith("&") ||
                       NurName.Text.Trim().StartsWith("*") || NurName.Text.Trim().StartsWith("(") ||
                       NurName.Text.Trim().StartsWith(")") || NurName.Text.Trim().StartsWith("_") ||
                       NurName.Text.Trim().StartsWith("+") || NurName.Text.Trim().StartsWith(",") ||
                       NurName.Text.Trim().StartsWith(".") || NurName.Text.Trim().StartsWith("?") ||
                       NurName.Text.Trim().StartsWith(";") || NurName.Text.Trim().StartsWith("'") ||
                       NurName.Text.Trim().StartsWith("1") || NurName.Text.Trim().StartsWith("2") ||
                       NurName.Text.Trim().StartsWith("3") || NurName.Text.Trim().StartsWith("4") ||
                       NurName.Text.Trim().StartsWith("5") || NurName.Text.Trim().StartsWith("6") ||
                       NurName.Text.Trim().StartsWith("7") || NurName.Text.Trim().StartsWith("8") ||
                       NurName.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurName.Focus();
                    }
                    else if (NurUser.Text.Trim().StartsWith("~") || NurUser.Text.Trim().StartsWith("!") ||
                       NurUser.Text.Trim().StartsWith("@") || NurUser.Text.Trim().StartsWith("-") ||
                       NurUser.Text.Trim().StartsWith("#") || NurUser.Text.Trim().StartsWith(",") ||
                       NurUser.Text.Trim().StartsWith("$") || NurUser.Text.Trim().StartsWith(".") ||
                       NurUser.Text.Trim().StartsWith("%") || NurUser.Text.Trim().StartsWith("<") ||
                       NurUser.Text.Trim().StartsWith("^") || NurUser.Text.Trim().StartsWith(">") ||
                       NurUser.Text.Trim().StartsWith("&") || NurUser.Text.Trim().StartsWith(".") ||
                       NurUser.Text.Trim().StartsWith("*") || NurUser.Text.Trim().StartsWith("'") ||
                       NurUser.Text.Trim().StartsWith("(") || NurUser.Text.Trim().StartsWith("?") ||
                       NurUser.Text.Trim().StartsWith(")") || NurUser.Text.Trim().StartsWith("|") ||
                       NurUser.Text.Trim().StartsWith("_") || NurUser.Text.Trim().StartsWith("1") ||
                       NurUser.Text.Trim().StartsWith("=") || NurUser.Text.Trim().StartsWith("2") ||
                       NurUser.Text.Trim().StartsWith("+") || NurUser.Text.Trim().StartsWith("3") ||
                       NurUser.Text.Trim().StartsWith("4") || NurUser.Text.Trim().StartsWith("5") ||
                       NurUser.Text.Trim().StartsWith("6") || NurUser.Text.Trim().StartsWith("7") ||
                       NurUser.Text.Trim().StartsWith("8") || NurUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Nurse Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurUser.Focus();
                    }
                    else if (NurPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Nurse  password  never less than   8  with characters or numbers .", " Password never less than  with 8 or greater than 15  characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPassword.Focus();

                    }
                    else if (NurPassword.Text.Length > 15)
                    {
                        MessageBox.Show(" Nurse  password  never greater than  15 with characters or numbers .", " Password never less than  with 8 or greater than 15  characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPassword.Focus();
                    }
                    else if (NurSecQue.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NurSecQue.Focus();
                    }
                    else if (NurSecAns.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NurSecAns.Focus();
                    }
                    else if (NurPhone.Text.Length < 9)
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPhone.Focus();
                    }
                    else if (NurPhone.Text.Length > 14)
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPhone.Focus();
                    }
                    else if (HasCharacter(NurPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPhone.Focus();
                    }
                    else if (comboGender.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboGender.Focus();
                    }
                    else if (NurSalary.Text == "")

                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurSalary.Focus();
                    }
                    else if (HasCharacter(NurSalary.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurSalary.Focus();
                    }

                    else if (comboSpec.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboSpec.Focus();
                    }
                    else if (picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picture.Focus();
                    }


                    else
                    {
                        SqlCommand cmd = new SqlCommand("InsertNurse", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nur_name", NurName.Text);
                        cmd.Parameters.AddWithValue("@nur_user", NurUser.Text);
                        cmd.Parameters.AddWithValue("@nur_pass", NurPassword.Text);
                        cmd.Parameters.AddWithValue("@nur_sec_que", NurSecQue.Text);
                        cmd.Parameters.AddWithValue("@nur_sec_ans", NurSecAns.Text);
                        cmd.Parameters.AddWithValue("@nur_phone ", NurPhone.Text);
                        cmd.Parameters.AddWithValue("@nur_gender", comboGender.Text);
                        cmd.Parameters.AddWithValue("@nur_salary", NurSalary.Text);
                        cmd.Parameters.AddWithValue("@nur_spec", comboSpec.Text);
                        cmd.Parameters.AddWithValue("@nur_image", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Nurse Updated   ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                SqlCommand command = new SqlCommand("searchTestimageNurse", con);
                command.Parameters.AddWithValue("@nur_id", id);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                reader.Read();
                var img = getImage(reader[0]);
                return img;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)NurseDataGrid.SelectedRows[0].Cells[0].Value;        
            string phone = NurPhone.Text;
            string salary = NurSalary.Text;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    if (NurName.Text.Trim().StartsWith("~") ||
                       NurName.Text.Trim().StartsWith("!") || NurName.Text.Trim().StartsWith("@") ||
                       NurName.Text.Trim().StartsWith("$") || NurName.Text.Trim().StartsWith("%") ||
                       NurName.Text.Trim().StartsWith("^") || NurName.Text.Trim().StartsWith("&") ||
                       NurName.Text.Trim().StartsWith("*") || NurName.Text.Trim().StartsWith("(") ||
                       NurName.Text.Trim().StartsWith(")") || NurName.Text.Trim().StartsWith("_") ||
                       NurName.Text.Trim().StartsWith("+") || NurName.Text.Trim().StartsWith(",") ||
                       NurName.Text.Trim().StartsWith(".") || NurName.Text.Trim().StartsWith("?") ||
                       NurName.Text.Trim().StartsWith(";") || NurName.Text.Trim().StartsWith("'") ||
                       NurName.Text.Trim().StartsWith("1") || NurName.Text.Trim().StartsWith("2") ||
                       NurName.Text.Trim().StartsWith("3") || NurName.Text.Trim().StartsWith("4") ||
                       NurName.Text.Trim().StartsWith("5") || NurName.Text.Trim().StartsWith("6") ||
                       NurName.Text.Trim().StartsWith("7") || NurName.Text.Trim().StartsWith("8") ||
                       NurName.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurName.Focus();
                    }
                    else if (NurUser.Text.Trim().StartsWith("~") || NurUser.Text.Trim().StartsWith("!") ||
                       NurUser.Text.Trim().StartsWith("@") || NurUser.Text.Trim().StartsWith("-") ||
                       NurUser.Text.Trim().StartsWith("#") || NurUser.Text.Trim().StartsWith(",") ||
                       NurUser.Text.Trim().StartsWith("$") || NurUser.Text.Trim().StartsWith(".") ||
                       NurUser.Text.Trim().StartsWith("%") || NurUser.Text.Trim().StartsWith("<") ||
                       NurUser.Text.Trim().StartsWith("^") || NurUser.Text.Trim().StartsWith(">") ||
                       NurUser.Text.Trim().StartsWith("&") || NurUser.Text.Trim().StartsWith(".") ||
                       NurUser.Text.Trim().StartsWith("*") || NurUser.Text.Trim().StartsWith("'") ||
                       NurUser.Text.Trim().StartsWith("(") || NurUser.Text.Trim().StartsWith("?") ||
                       NurUser.Text.Trim().StartsWith(")") || NurUser.Text.Trim().StartsWith("|") ||
                       NurUser.Text.Trim().StartsWith("_") || NurUser.Text.Trim().StartsWith("1") ||
                       NurUser.Text.Trim().StartsWith("=") || NurUser.Text.Trim().StartsWith("2") ||
                       NurUser.Text.Trim().StartsWith("+") || NurUser.Text.Trim().StartsWith("3") ||
                       NurUser.Text.Trim().StartsWith("4") || NurUser.Text.Trim().StartsWith("5") ||
                       NurUser.Text.Trim().StartsWith("6") || NurUser.Text.Trim().StartsWith("7") ||
                       NurUser.Text.Trim().StartsWith("8") || NurUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Nurse Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurUser.Focus();
                    }
                    else if (NurPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Nurse  password  never less than   8  with characters or numbers .", " Password never less than  with 8 or greater than 15  characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPassword.Focus();
   
                    }
                    else if(NurPassword.Text.Length > 15)
                    {
                        MessageBox.Show(" Nurse  password  never greater than  15 with characters or numbers .", " Password never less than  with 8 or greater than 15  characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPassword.Focus();
                    }
                    else if (NurSecQue.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NurSecQue.Focus();
                    }
                    else if (NurSecAns.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NurSecAns.Focus();
                    }
                    else if (NurPhone.Text.Length < 9)
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPhone.Focus();
                    }
                    else if (NurPhone.Text.Length > 14)
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPhone.Focus();
                    }
                    else if (HasCharacter(NurPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurPhone.Focus();
                    }
                    else if (comboGender.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboGender.Focus();
                    }
                    else if (NurSalary.Text == "")

                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurSalary.Focus();
                    }
                    else if (HasCharacter(NurSalary.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NurSalary.Focus();
                    }

                    else if (comboSpec.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboSpec.Focus();
                    }
                    else if (picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picture.Focus();
                    }


                    else
                    {
                        SqlCommand cmd = new SqlCommand("UpdateNurse", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nur_id", id.ToString());
                        cmd.Parameters.AddWithValue("@nur_name", NurName.Text);
                        cmd.Parameters.AddWithValue("@nur_user", NurUser.Text);
                        cmd.Parameters.AddWithValue("@nur_pass", NurPassword.Text);
                        cmd.Parameters.AddWithValue("@nur_sec_que", NurSecQue.Text);
                        cmd.Parameters.AddWithValue("@nur_sec_ans", NurSecAns.Text);
                        cmd.Parameters.AddWithValue("@nur_phone ", NurPhone.Text);
                        cmd.Parameters.AddWithValue("@nur_gender", comboGender.Text);
                        cmd.Parameters.AddWithValue("@nur_salary", NurSalary.Text);
                        cmd.Parameters.AddWithValue("@nur_spec", comboSpec.Text);
                        cmd.Parameters.AddWithValue("@nur_image", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Nurse Updated   ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }


        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            FilldataGrid();
            lblDisplay.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)NurseDataGrid.SelectedRows[0].Cells[0].Value;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DeleteNurse", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nur_id", id.ToString());
                    cmd.ExecuteNonQuery();
                    FilldataGrid();
                    Clears();
                    MessageBox.Show("Successfully Nurse Deleted ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }

        private void NurseDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)NurseDataGrid.SelectedRows[0].Cells[0].Value;
            NurName.Text = NurseDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            NurUser.Text = NurseDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            NurPassword.Text = NurseDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            NurSecQue.Text = NurseDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            NurSecAns.Text = NurseDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            NurPhone.Text = NurseDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            comboGender.Text = NurseDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            NurSalary.Text = NurseDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            comboSpec.Text = NurseDataGrid.SelectedRows[0].Cells[10].Value.ToString();
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = getUserImage(id);
        }

        public bool HasCharacter(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (!char.IsDigit(phone, i))
                {
                    return true;
                }

            }
            return false;
        }

        public void SearchPatientAppointDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {

                SqlDataAdapter reader = new SqlDataAdapter(" select nur_id ,nur_name,nur_user,nur_pass,nur_sec_que,nur_sec_ans,nur_phone,nur_gender,nur_user_type,nur_salary,nur_spec from nurse where nur_id like '" + txtSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    NurseDataGrid.DataSource = dTable;
                    NurseDataGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    NurseDataGrid.Visible = false;
                    lblDisplay.Visible = true;
                }

            }

        }

        private void DoctorSearch_Enter(object sender, EventArgs e)
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
