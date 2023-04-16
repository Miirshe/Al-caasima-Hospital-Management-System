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
    public partial class Admin : UserControl
    {
        public static string ImageName;
        public static string type;
        public static Image img;
        public Admin()
        {
            InitializeComponent();
        }
        public void FilldataGrid()
        {

            using (SqlConnection con = conClass.Connect())
            {
                SqlDataAdapter dt = new SqlDataAdapter("exec SelectedAdmin", con);
                DataTable da = new DataTable();
                dt.Fill(da);
                AdminDataGrid.DataSource = da;
            }

        }

        public void Clears()
        {
            AdminName.Text = " ";
            AdminUser.Text = "";
            AdminPassword.Text = "";
            AdminSecQue.Text = "";
            AdminSecAns.Text = "";
            AdminPhone.Text = "";
            comboGender.SelectedItem = " ";
            AdminSalary.Text = "";
            picture.Image = null;

        }
        private void Admin_Load(object sender, EventArgs e)
        {
            FilldataGrid();
            lblDisplay.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = conClass.Connect())
            {
               
                try
                {

                    if (AdminName.Text.Trim().StartsWith("~") ||
                        AdminName.Text.Trim().StartsWith("!") || AdminName.Text.Trim().StartsWith("@") ||
                        AdminName.Text.Trim().StartsWith("$") || AdminName.Text.Trim().StartsWith("%") ||
                        AdminName.Text.Trim().StartsWith("^") || AdminName.Text.Trim().StartsWith("&") ||
                        AdminName.Text.Trim().StartsWith("*") || AdminName.Text.Trim().StartsWith("(") ||
                        AdminName.Text.Trim().StartsWith(")") || AdminName.Text.Trim().StartsWith("_") ||
                        AdminName.Text.Trim().StartsWith("+") || AdminName.Text.Trim().StartsWith(",") ||
                        AdminName.Text.Trim().StartsWith(".") || AdminName.Text.Trim().StartsWith("?") ||
                        AdminName.Text.Trim().StartsWith(";") || AdminName.Text.Trim().StartsWith("'") ||
                        AdminName.Text.Trim().StartsWith("1") || AdminName.Text.Trim().StartsWith("2") ||
                        AdminName.Text.Trim().StartsWith("3") || AdminName.Text.Trim().StartsWith("4") ||
                        AdminName.Text.Trim().StartsWith("5") || AdminName.Text.Trim().StartsWith("6") ||
                        AdminName.Text.Trim().StartsWith("7") || AdminName.Text.Trim().StartsWith("8") ||
                        AdminName.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminName.Focus();
                    }
                    else if (AdminUser.Text.Trim().StartsWith("~") || AdminUser.Text.Trim().StartsWith("!") ||
                        AdminUser.Text.Trim().StartsWith("@") || AdminUser.Text.Trim().StartsWith("-") ||
                        AdminUser.Text.Trim().StartsWith("#") || AdminUser.Text.Trim().StartsWith(",") ||
                        AdminUser.Text.Trim().StartsWith("$") || AdminUser.Text.Trim().StartsWith(".") ||
                        AdminUser.Text.Trim().StartsWith("%") || AdminUser.Text.Trim().StartsWith("<") ||
                        AdminUser.Text.Trim().StartsWith("^") || AdminUser.Text.Trim().StartsWith(">") ||
                        AdminUser.Text.Trim().StartsWith("&") || AdminUser.Text.Trim().StartsWith(".") ||
                        AdminUser.Text.Trim().StartsWith("*") || AdminUser.Text.Trim().StartsWith("'") ||
                        AdminUser.Text.Trim().StartsWith("(") || AdminUser.Text.Trim().StartsWith("?") ||
                        AdminUser.Text.Trim().StartsWith(")") || AdminUser.Text.Trim().StartsWith("|") ||
                        AdminUser.Text.Trim().StartsWith("_") || AdminUser.Text.Trim().StartsWith("1") ||
                        AdminUser.Text.Trim().StartsWith("=") || AdminUser.Text.Trim().StartsWith("2") ||
                        AdminUser.Text.Trim().StartsWith("+") || AdminUser.Text.Trim().StartsWith("3") ||
                        AdminUser.Text.Trim().StartsWith("4") || AdminUser.Text.Trim().StartsWith("5") ||
                        AdminUser.Text.Trim().StartsWith("6") || AdminUser.Text.Trim().StartsWith("7") ||
                        AdminUser.Text.Trim().StartsWith("8") || AdminUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Admin Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminUser.Focus();
                    }
                    else if (AdminPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Admin password  never less than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPassword.Focus();
                    }
                    else if (AdminPassword.Text.Length >15)
                    {
                        MessageBox.Show(" Admin password  never greater than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPassword.Focus();
                    }
                    else if (AdminSecQue.Text == " ")
                    {
                        MessageBox.Show(" Please fill text box blank .", " Admin Question Textbox ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSecQue.Focus();

                    }
                    else if (AdminSecAns.Text == " ")
                    {
                        MessageBox.Show(" Please fill text box blank .", " Admin Answer Textbox ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSecAns.Focus();
                    }
                    else if (AdminPhone.Text.Length < 9)
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPhone.Focus();
                    }
                    else if (AdminPhone.Text.Length > 14 )
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPhone.Focus();
                    }

                    else if (HasCharacter(AdminPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPhone.Focus();
                    }
                    else if (comboGender.Text.Trim().Equals(""))
                    {
                        MessageBox.Show(" Please fill text box blank .", " Admin Gender Textbox ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboGender.Focus();
                    }
                    else if(AdminSalary.Text==" ")
                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSalary.Focus();
                    }
                    else if (HasCharacter(AdminSalary.Text))
                    {
                        MessageBox.Show(" salary must be Digit", " salary number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSalary.Focus();
                    }

                    else if (picture.Image == null)
                    {
                        MessageBox.Show(" Please fill Picture box blank .", " Admin Image Picture box ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picture.Focus();
                    }


                    else
                    {
                        SqlCommand cmd = new SqlCommand("InsertAdmin", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@adm_name", AdminName.Text);
                        cmd.Parameters.AddWithValue("@adm_user", AdminUser.Text);
                        cmd.Parameters.AddWithValue("@adm_pass", AdminPassword.Text);
                        cmd.Parameters.AddWithValue("@adm_sec_que", AdminSecQue.Text);
                        cmd.Parameters.AddWithValue("@adm_sec_ans", AdminSecAns.Text);
                        cmd.Parameters.AddWithValue("@adm_phone ", AdminPhone.Text);
                        cmd.Parameters.AddWithValue("@adm_gender ", comboGender.Text);
                        cmd.Parameters.AddWithValue("@adm_salary ", AdminSalary.Text);
                        cmd.Parameters.AddWithValue("@admin_photo", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Admin Saved ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                    
                catch(Exception exec)
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
                SqlCommand command = new SqlCommand("searchTestimage", con);
                command.Parameters.AddWithValue("@adm_id", id);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                reader.Read();
                var img = getImage(reader[0]);
                return img;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String phone = AdminPhone.Text;
            String salary = AdminSalary.Text;
            
            int id = (int)AdminDataGrid.SelectedRows[0].Cells[0].Value;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {

                    if (AdminName.Text.Trim().StartsWith("~") ||
                        AdminName.Text.Trim().StartsWith("!") || AdminName.Text.Trim().StartsWith("@") ||
                        AdminName.Text.Trim().StartsWith("$") || AdminName.Text.Trim().StartsWith("%") ||
                        AdminName.Text.Trim().StartsWith("^") || AdminName.Text.Trim().StartsWith("&") ||
                        AdminName.Text.Trim().StartsWith("*") || AdminName.Text.Trim().StartsWith("(") ||
                        AdminName.Text.Trim().StartsWith(")") || AdminName.Text.Trim().StartsWith("_") ||
                        AdminName.Text.Trim().StartsWith("+") || AdminName.Text.Trim().StartsWith(",") ||
                        AdminName.Text.Trim().StartsWith(".") || AdminName.Text.Trim().StartsWith("?") ||
                        AdminName.Text.Trim().StartsWith(";") || AdminName.Text.Trim().StartsWith("'") ||
                        AdminName.Text.Trim().StartsWith("1") || AdminName.Text.Trim().StartsWith("2") ||
                        AdminName.Text.Trim().StartsWith("3") || AdminName.Text.Trim().StartsWith("4") ||
                        AdminName.Text.Trim().StartsWith("5") || AdminName.Text.Trim().StartsWith("6") ||
                        AdminName.Text.Trim().StartsWith("7") || AdminName.Text.Trim().StartsWith("8") ||
                        AdminName.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show("Full Name  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminName.Focus();
                    }
                    else if (AdminUser.Text.Trim().StartsWith("~") || AdminUser.Text.Trim().StartsWith("!") ||
                        AdminUser.Text.Trim().StartsWith("@") || AdminUser.Text.Trim().StartsWith("-") ||
                        AdminUser.Text.Trim().StartsWith("#") || AdminUser.Text.Trim().StartsWith(",") ||
                        AdminUser.Text.Trim().StartsWith("$") || AdminUser.Text.Trim().StartsWith(".") ||
                        AdminUser.Text.Trim().StartsWith("%") || AdminUser.Text.Trim().StartsWith("<") ||
                        AdminUser.Text.Trim().StartsWith("^") || AdminUser.Text.Trim().StartsWith(">") ||
                        AdminUser.Text.Trim().StartsWith("&") || AdminUser.Text.Trim().StartsWith(".") ||
                        AdminUser.Text.Trim().StartsWith("*") || AdminUser.Text.Trim().StartsWith("'") ||
                        AdminUser.Text.Trim().StartsWith("(") || AdminUser.Text.Trim().StartsWith("?") ||
                        AdminUser.Text.Trim().StartsWith(")") || AdminUser.Text.Trim().StartsWith("|") ||
                        AdminUser.Text.Trim().StartsWith("_") || AdminUser.Text.Trim().StartsWith("1") ||
                        AdminUser.Text.Trim().StartsWith("=") || AdminUser.Text.Trim().StartsWith("2") ||
                        AdminUser.Text.Trim().StartsWith("+") || AdminUser.Text.Trim().StartsWith("3") ||
                        AdminUser.Text.Trim().StartsWith("4") || AdminUser.Text.Trim().StartsWith("5") ||
                        AdminUser.Text.Trim().StartsWith("6") || AdminUser.Text.Trim().StartsWith("7") ||
                        AdminUser.Text.Trim().StartsWith("8") || AdminUser.Text.Trim().StartsWith("9"))
                    {
                        MessageBox.Show(" Admin Username  never start with any digit .", "Name Must be characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminUser.Focus();
                    }
                    else if (AdminPassword.Text.Length < 8)
                    {
                        MessageBox.Show(" Admin password  never less than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPassword.Focus();
                    }
                    else if (AdminPassword.Text.Length > 15)
                    {
                        MessageBox.Show(" Admin password  never greater than  with 8 characters or numbers .", " Password never less than  with 8 characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPassword.Focus();
                    }
                    else if (AdminSecQue.Text == " ")
                    {
                        MessageBox.Show(" Please fill text box blank .", " Admin Question Textbox ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSecQue.Focus();

                    }
                    else if (AdminSecAns.Text == " ")
                    {
                        MessageBox.Show(" Please fill text box blank .", " Admin Answer Textbox ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSecAns.Focus();
                    }
                    else if (AdminPhone.Text.Length < 9 )
                    {
                        MessageBox.Show(" The length Phone number never less than 9 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPhone.Focus();
                    }
                    else if (AdminPhone.Text.Length > 14)
                    {
                        MessageBox.Show(" The length Phone number never greater than 14 ", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPhone.Focus();
                    }
                    else if (HasCharacter(AdminPhone.Text))
                    {
                        MessageBox.Show(" Phone must be Digit", " Phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminPhone.Focus();
                    }


                    else if (comboGender.Text.Trim().Equals(""))
                    {
                        MessageBox.Show(" Please fill text box blank .", " Admin Gender Textbox ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboGender.Focus();
                    }
                    else if (AdminSalary.Text=="")

                    {
                        MessageBox.Show(" Please fill Empty blank  .", "  Text box Salary  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSalary.Focus();
                    }
                    else if (HasCharacter(AdminSalary.Text))
                    {
                        MessageBox.Show(" Salary must be Digit", " salary number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AdminSalary.Focus();
                    }


                    else if (picture.Image == null)
                    {
                        MessageBox.Show(" Please fill Picture box blank .", " Admin Image Picture box ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picture.Focus();
                    }


                    else
                    {
                        SqlCommand cmd = new SqlCommand("UpdateAdmin", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@adm_id", id.ToString());
                        cmd.Parameters.AddWithValue("@adm_name", AdminName.Text);
                        cmd.Parameters.AddWithValue("@adm_user", AdminUser.Text);
                        cmd.Parameters.AddWithValue("@adm_pass", AdminPassword.Text);
                        cmd.Parameters.AddWithValue("@adm_sec_que", AdminSecQue.Text);
                        cmd.Parameters.AddWithValue("@adm_sec_ans", AdminSecAns.Text);
                        cmd.Parameters.AddWithValue("@adm_phone ", AdminPhone.Text);
                        cmd.Parameters.AddWithValue("@adm_gender ", comboGender.Text);
                        cmd.Parameters.AddWithValue("@adm_salary ", AdminSalary.Text);
                        cmd.Parameters.AddWithValue("@admin_photo", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        FilldataGrid();
                        Clears();
                        MessageBox.Show("Successfully Admin Saved ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
            int id = (int)AdminDataGrid.SelectedRows[0].Cells[0].Value;
            using (SqlConnection con = conClass.Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DeleteAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@adm_id", id.ToString());
                    cmd.ExecuteNonQuery();
                    FilldataGrid();
                    Clears();
                    MessageBox.Show("Successfully Deleted Admin ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
        }

        private void AdminDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)AdminDataGrid.SelectedRows[0].Cells[0].Value;
            AdminName.Text = AdminDataGrid.SelectedRows[0].Cells[1].Value.ToString();
            AdminUser.Text = AdminDataGrid.SelectedRows[0].Cells[2].Value.ToString();
            AdminPassword.Text = AdminDataGrid.SelectedRows[0].Cells[3].Value.ToString();
            AdminSecQue.Text = AdminDataGrid.SelectedRows[0].Cells[4].Value.ToString();
            AdminSecAns.Text = AdminDataGrid.SelectedRows[0].Cells[5].Value.ToString();
            AdminPhone.Text = AdminDataGrid.SelectedRows[0].Cells[6].Value.ToString();
            comboGender.Text = AdminDataGrid.SelectedRows[0].Cells[7].Value.ToString();
            AdminSalary.Text = AdminDataGrid.SelectedRows[0].Cells[9].Value.ToString();
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Image = getUserImage(id);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public bool HasCharacter(string phone)
        {
            for(int i=0; i<phone.Length; i++)
            {
                if(!char.IsDigit(phone, i))
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

                SqlDataAdapter reader = new SqlDataAdapter("  select  adm_name,adm_user,adm_pass,adm_sec_que ,adm_sec_ans,adm_phone, adm_gender , adm_user_type,adm_salary  from admin where  adm_id  like   '" + txtSearch.Text+"' ", con);
                DataTable dTable = new DataTable();
                reader.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    AdminDataGrid.DataSource = dTable;
                    AdminDataGrid.Visible = true;
                    lblDisplay.Visible = false;
                }
                else
                {
                    AdminDataGrid.Visible = false;
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
