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
    public partial class Login : Form
    {
        public static string username;
        public static Image img;
        public static string type;
        public static string doc_type;
        public Login()
        {
            InitializeComponent();
            if (Properties.Settings.Default.username != string.Empty)
            {
                user.Text = Properties.Settings.Default.username;
                Password.Text = Properties.Settings.Default.password;
                remenberMe.Checked = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (isBlank())
            {

                if (check_User())
                {
                    successLogin();
                }
                else if (check_Reception())
                {
                    successLoginReception();
                }
                else if (check_UserDoctor())
                {
                    successLoginDoctor();
                }
                


                else
                {
                    MessageBox.Show("Incorrect Username Or Password. Please try again.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    makeEmpty();
                }


            }
        }
        private void makeEmpty()
        {
            user.Text = "";
            Password.Text = "";
            user.Focus();
        }


        private bool check_User()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select adm_user_type,adm_user,admin_photo from admin  where  adm_user='" + user.Text + "' and  adm_pass = '" + Password.Text + "' ", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        type = reader[0].ToString();
                        username = reader[1].ToString();
                        img = getImage(reader[2]);
                        return true;
                    }

                }
            }

            return false;
        }


        private bool check_Reception()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select * from receptions where recep_user = '" + user.Text+"' and recep_pass = '"+Password.Text+"'", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        type = reader["recep_user_type"].ToString();
                        username = reader["recep_user"].ToString();
                        img = getImage(reader["recep_image"]);
                        Dashboard dash = new Dashboard();
                        dash.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        return true;
                    }

                }
            }

            return false;
        }


        private bool check_UserDoctor()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select doc_user_type, doc_user , doc_image ,doc_spec from doctor  where doc_user='" + user.Text + "' and  doc_pass ='" + Password.Text + "'; ", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        type = reader[0].ToString();
                        username = reader[1].ToString();
                        img = getImage(reader[2]);
                        DocApp.doc_spec= reader[3].ToString();
                        Dashboard dash = new Dashboard();
                        dash.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                        return true;
                    }

                }
            }

            return false;
        }
    


        private bool isBlank()
        {
            if (user.Text.Trim().Equals("") || Password.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Fields Are Required.!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                makeEmpty();
                return false;
            }
            else
            {

                return true;
            }
        }
        private void successLogin()
        {
            
            Dashboard dash = new Dashboard();
            dash.lblPrintName.Text = username;
            dash.lblPrintUser.Text = type;
            dash.pictureBox1.Image = img;
            dash.ShowDialog();
            this.Hide();
        }

        private void successLoginReception()
        {

            Dashboard dash = new Dashboard();
            dash.lblPrintName.Text = username;
            dash.lblPrintUser.Text = type;
            dash.pictureBox1.Image = img;
            DocApp.doc_spec = doc_type;
            dash.btnAdmin.Visible = false;
            dash.btnDoctor.Visible = false;
            dash.btnReception.Visible = false;
            dash.btnNurse.Visible = false;
            dash.btnDocAppointment.Visible = false;
            dash.btnResultDiagnosis.Visible = false;
            dash.ShowDialog();
            this.Hide();
        }

        private void successLoginDoctor()
        {

            Dashboard dash = new Dashboard();
            dash.lblPrintName.Text = username;
            dash.lblPrintUser.Text = type;
            dash.pictureBox1.Image = img;
            dash.btnAdmin.Visible=false;
            dash.btnDoctor.Visible = false;
            dash.btnReception.Visible = false;
            dash.btnPatient.Visible = false;
            dash.btnAppointment.Visible = false;
            dash.btnDiagnosis.Visible = false;
            dash.btnPharmacy.Visible = false;
            dash.btnNurse.Visible = false;
            dash.ShowDialog();

            this.Hide();
        }

        

        private Image getImage(object reader)
        {

            var ms = new MemoryStream((byte[])reader);
            Image img = Image.FromStream(ms);
            return img;
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_show_Click(object sender, EventArgs e)
        {
            Password.PasswordChar = '\0';
            pic_hide.BringToFront();
        }

        private void pic_hide_Click(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
            pic_show.BringToFront();
        }

        private void btnForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void remenberMe_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void remenberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (remenberMe.Checked)
            {
                string username = user.Text; ;
                string password = Password.Text;
                Properties.Settings.Default.username = username;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fr = new ForgetPassword();
            fr.Show();
            this.Hide();
        }
    }
}
