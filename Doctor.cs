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
    public partial class Doctor : UserControl
    {
        public static string ImageName;
        public static string type;
        public static Image img;
        public Doctor()
        {
            InitializeComponent();
        }
        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec SelectionDoctro ", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                DoctorDataGrid.DataSource = da;
            }

        }

        public void Clears()
        {
            DocName.Text = "";
            DocUser.Text = "";
            DocPassword.Text = "";
            DocSecQue.Text ="";
            DocSecAns.Text = "";
            DocPhone.Text = "";
            comboSpec.Text = "";
            DocExp.Text = "";
            comboGender.Text = "";
            DocSalary.Text = "";
            picture.Image = null;



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

        private static Image getUserImage(int id)
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand command = new SqlCommand("searchTestimageDocotr", con);
                command.Parameters.AddWithValue("@doc_id", id);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                reader.Read();
                var img = getImage(reader[0]);
                return img;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string phone = DocPhone.Text;
            string salary = DocSalary.Text;
            using (SqlConnection con = conClass.Connect())
            {

                try
                {
                    if (DocName.Text.Trim().StartsWith("~") ||
                       DocName.Text.Trim().StartsWith("!") || DocName.Text.Trim().StartsWith("@") ||
                       DocName.Text.Trim().StartsWith("$") || DocName.Text.Trim().StartsWith("%") ||
                       DocName.Text.Trim().StartsWith("^") || DocName.Text.Trim().StartsWith("&") ||
                       DocName.Text.Trim().StartsWith("*") || DocName.Text.Trim().StartsWith("(") ||
                       DocName.Text.Trim().StartsWith(")") || DocName.Text.Trim().StartsWith("_") ||
                       DocName.Text.Trim().StartsWith("+") || DocName.Text.Trim().StartsWith(",") ||
                       DocName.Text.Trim().StartsWith(".") || DocName.Text.Trim().StartsWith("?") ||
                       DocName.Text.Trim().StartsWith(";") || DocName.Text.Trim().StartsWith("'") ||
                       DocName.Text.Trim().StartsWith("1") || DocName.Text.Trim().StartsWith("2") ||
                       DocName.Text.Trim().StartsWith("3") || DocName.Text.Trim().StartsWith("4") ||
                       DocName.Text.Trim().StartsWith("5") || DocName.Text.Trim().StartsWith("6") ||
                       DocName.Text.Trim().StartsWith("7") || DocName.Text.Trim().StartsWith("8") ||
                       DocName.Text.Trim().StartsWith("9"))
                    {  
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocName.Focus();
                    }
                    else if (DocUser.Text.Trim().StartsWith("~") || DocUser.Text.Trim().StartsWith("!") ||
                        DocUser.Text.Trim().StartsWith("@") || DocUser.Text.Trim().StartsWith("-") ||
                        DocUser.Text.Trim().StartsWith("#") || DocUser.Text.Trim().StartsWith(",") ||
                        DocUser.Text.Trim().StartsWith("$") || DocUser.Text.Trim().StartsWith(".") ||
                        DocUser.Text.Trim().StartsWith("%") || DocUser.Text.Trim().StartsWith("<") ||
                        DocUser.Text.Trim().StartsWith("^") || DocUser.Text.Trim().StartsWith(">") ||
                        DocUser.Text.Trim().StartsWith("&") || DocUser.Text.Trim().StartsWith(".") ||
                        DocUser.Text.Trim().StartsWith("*") || DocUser.Text.Trim().StartsWith("'") ||
                        DocUser.Text.Trim().StartsWith("(") || DocUser.Text.Trim().StartsWith("?") ||
                        DocUser.Text.Trim().StartsWith(")") || DocUser.Text.Trim().StartsWith("|") ||
                        DocUser.Text.Trim().StartsWith("_") || DocUser.Text.Trim().StartsWith("1") ||
                        DocUser.Text.Trim().StartsWith("=") || DocUser.Text.Trim().StartsWith("2") ||
                        DocUser.Text.Trim().StartsWith("+") || DocUser.Text.Trim().StartsWith("3") ||
                        DocUser.Text.Trim().StartsWith("4") || DocUser.Text.Trim().StartsWith("5") ||
                        DocUser.Text.Trim().StartsWith("6") || DocUser.Text.Trim().StartsWith("7") ||
                        DocUser.Text.Trim().StartsWith("8") || DocUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Doctor Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocUser.Focus();
                    }
                    else if (DocPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Doctor  password  never less than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPassword.Focus();
                    }
                    else if (DocPassword.Text.Length > 15)
                    {
                        MessageBox.Show(" Doctor  password  never greater than  with 15 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPassword.Focus();
                    }
                    else if (DocSecQue.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DocSecQue.Focus();
                    }
                    else if (DocSecAns.Text.Trim().Equals(" ")) 
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DocSecAns.Focus();
                    }
                    else if (DocPhone.Text.Length < 9)
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPhone.Focus();
                    }
                    else if (DocPhone.Text.Length > 14)
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPhone.Focus();
                    }
                    else if (HasCharacter(DocPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPhone.Focus();
                    }

                    else if(comboSpec.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboSpec.Focus();
                    }
                    else if (DocExp.Text.Trim().Equals(" "))
                    {
                            MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DocExp.Focus();
                    }
                    else if(comboGender.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboGender.Focus();
                    }
                    else if (DocSalary.Text == "")

                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocSalary.Focus();
                    }
                    else if (HasCharacter(DocSalary.Text))
                    {
                        MessageBox.Show(" Salary must be Digit", " salary number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocSalary.Focus();
                    }
                    else if (picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picture.Focus();
                    }
                    else
                    {
                        
                        SqlCommand cmd = new SqlCommand("insertDoctor", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doc_name", DocName.Text);
                        cmd.Parameters.AddWithValue("@doc_user", DocUser.Text);
                        cmd.Parameters.AddWithValue("@doc_pass", DocPassword.Text);
                        cmd.Parameters.AddWithValue("@doc_sec_que", DocSecQue.Text);
                        cmd.Parameters.AddWithValue("@doc_sec_ans", DocSecAns.Text);
                        cmd.Parameters.AddWithValue("@docPhone ", DocPhone.Text);
                        cmd.Parameters.AddWithValue("@doc_spec", comboSpec.Text);
                        cmd.Parameters.AddWithValue("@doc_exp", DocExp.Text);
                        cmd.Parameters.AddWithValue("@doc_gender", comboGender.Text);
                        cmd.Parameters.AddWithValue("@doc_salary", DocSalary.Text);
                        cmd.Parameters.AddWithValue("@doc_image", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Doctor Saved ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            int id = (int)DoctorDataGrid.SelectedRows[0].Cells[0].Value;
            string phone = DocPhone.Text;
            string salary = DocSalary.Text;
            using (SqlConnection con = conClass.Connect())
            {

                try
                {
                    if (DocName.Text.Trim().StartsWith("~") ||
                       DocName.Text.Trim().StartsWith("!") || DocName.Text.Trim().StartsWith("@") ||
                       DocName.Text.Trim().StartsWith("$") || DocName.Text.Trim().StartsWith("%") ||
                       DocName.Text.Trim().StartsWith("^") || DocName.Text.Trim().StartsWith("&") ||
                       DocName.Text.Trim().StartsWith("*") || DocName.Text.Trim().StartsWith("(") ||
                       DocName.Text.Trim().StartsWith(")") || DocName.Text.Trim().StartsWith("_") ||
                       DocName.Text.Trim().StartsWith("+") || DocName.Text.Trim().StartsWith(",") ||
                       DocName.Text.Trim().StartsWith(".") || DocName.Text.Trim().StartsWith("?") ||
                       DocName.Text.Trim().StartsWith(";") || DocName.Text.Trim().StartsWith("'") ||
                       DocName.Text.Trim().StartsWith("1") || DocName.Text.Trim().StartsWith("2") ||
                       DocName.Text.Trim().StartsWith("3") || DocName.Text.Trim().StartsWith("4") ||
                       DocName.Text.Trim().StartsWith("5") || DocName.Text.Trim().StartsWith("6") ||
                       DocName.Text.Trim().StartsWith("7") || DocName.Text.Trim().StartsWith("8") ||
                       DocName.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocName.Focus();
                    }
                    else if (DocUser.Text.Trim().StartsWith("~") || DocUser.Text.Trim().StartsWith("!") ||
                        DocUser.Text.Trim().StartsWith("@") || DocUser.Text.Trim().StartsWith("-") ||
                        DocUser.Text.Trim().StartsWith("#") || DocUser.Text.Trim().StartsWith(",") ||
                        DocUser.Text.Trim().StartsWith("$") || DocUser.Text.Trim().StartsWith(".") ||
                        DocUser.Text.Trim().StartsWith("%") || DocUser.Text.Trim().StartsWith("<") ||
                        DocUser.Text.Trim().StartsWith("^") || DocUser.Text.Trim().StartsWith(">") ||
                        DocUser.Text.Trim().StartsWith("&") || DocUser.Text.Trim().StartsWith(".") ||
                        DocUser.Text.Trim().StartsWith("*") || DocUser.Text.Trim().StartsWith("'") ||
                        DocUser.Text.Trim().StartsWith("(") || DocUser.Text.Trim().StartsWith("?") ||
                        DocUser.Text.Trim().StartsWith(")") || DocUser.Text.Trim().StartsWith("|") ||
                        DocUser.Text.Trim().StartsWith("_") || DocUser.Text.Trim().StartsWith("1") ||
                        DocUser.Text.Trim().StartsWith("=") || DocUser.Text.Trim().StartsWith("2") ||
                        DocUser.Text.Trim().StartsWith("+") || DocUser.Text.Trim().StartsWith("3") ||
                        DocUser.Text.Trim().StartsWith("4") || DocUser.Text.Trim().StartsWith("5") ||
                        DocUser.Text.Trim().StartsWith("6") || DocUser.Text.Trim().StartsWith("7") ||
                        DocUser.Text.Trim().StartsWith("8") || DocUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Doctor Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocUser.Focus();
                    }
                    else if (DocPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Doctor  password  never less than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPassword.Focus();
                    }
                    else if (DocPassword.Text.Length >15)
                    {
                        MessageBox.Show(" Doctor  password  never greater than  with 15 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPassword.Focus();
                    }
                    else if (DocSecQue.Text.Trim().Equals(""))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DocSecQue.Focus();
                    }
                    else if (DocSecAns.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DocSecAns.Focus();
                    }
                    else if (DocPhone.Text.Length < 9)
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPhone.Focus();
                    }
                    else if (DocPhone.Text.Length > 14)
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPhone.Focus();
                    }
                    else if (HasCharacter(DocPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocPhone.Focus();
                    }

                    else if (comboSpec.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboSpec.Focus();
                    }
                    else if (DocExp.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DocExp.Focus();
                    }
                    else if (comboGender.Text.Trim().Equals(" "))
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comboGender.Focus();
                    }
                    else if (DocSalary.Text == "")

                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocSalary.Focus();
                    }
                    else if (HasCharacter(DocSalary.Text))
                    {
                        MessageBox.Show(" Salary must be Digit", " salary number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DocSalary.Focus();
                    }
                    else if (picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        picture.Focus();
                    }
                    else
                    {

                        SqlCommand cmd = new SqlCommand("UpdateDoctor", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doc_id", id.ToString());
                        cmd.Parameters.AddWithValue("@doc_name", DocName.Text);
                        cmd.Parameters.AddWithValue("@doc_user", DocUser.Text);
                        cmd.Parameters.AddWithValue("@doc_pass", DocPassword.Text);
                        cmd.Parameters.AddWithValue("@doc_sec_que", DocSecQue.Text);
                        cmd.Parameters.AddWithValue("@doc_sec_ans", DocSecAns.Text);
                        cmd.Parameters.AddWithValue("@docPhone ", DocPhone.Text);
                        cmd.Parameters.AddWithValue("@doc_spec", comboSpec.Text);
                        cmd.Parameters.AddWithValue("@doc_exp", DocExp.Text);
                        cmd.Parameters.AddWithValue("@doc_gender", comboGender.Text);
                        cmd.Parameters.AddWithValue("@doc_salary", DocSalary.Text);
                        cmd.Parameters.AddWithValue("@doc_image", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Doctor updated ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            int id = (int)DoctorDataGrid.SelectedRows[0].Cells[0].Value;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DeleteDoctors", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@doc_id", id.ToString());
                    cmd.ExecuteNonQuery();
                    FilldataGrid();
                    Clears();
                    MessageBox.Show("Successfully Doctor Deleted  ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }

        private void DoctorDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DoctorDataGrid.SelectedRows[0].Cells[0].Value;
            DocName.Text = DoctorDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            DocUser.Text = DoctorDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            DocPassword.Text = DoctorDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            DocSecQue.Text = DoctorDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            DocSecAns.Text = DoctorDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            DocPhone.Text = DoctorDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            comboSpec.Text = DoctorDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            DocExp.Text = DoctorDataGrid.SelectedRows[0].Cells[8].Value.ToString();
            comboGender.Text = DoctorDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            DocSalary.Text = DoctorDataGrid.SelectedRows[0].Cells[11].Value.ToString();
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = getUserImage(id);
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            FilldataGrid();
            lblDisplay.Visible = false;
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

                SqlDataAdapter reader = new SqlDataAdapter(" select  doc_id, doc_name,doc_user,doc_pass,doc_sec_que,doc_sec_ans,docPhone,doc_spec,doc_exp,doc_gender,doc_user_type,doc_salary,doc_reg_Date from doctor where doc_id like   '" + txtSearch.Text + "' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    DoctorDataGrid.DataSource = dTable;
                    DoctorDataGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    DoctorDataGrid.Visible = false;
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
    }
}
