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
    public partial class UpdatedProfile : Form
    {
        public static string ImageName;
        public static string type;
        public static Image img;
        public UpdatedProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        public MemoryStream ImageToStreem(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms;

        }


        public Image getImage(object reader)
        {

            var ms = new MemoryStream((byte[])reader);
            Image img = Image.FromStream(ms);
            return img;
        }

        private Image getUserImage(string admin)
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand command = new SqlCommand("UpateProfileimage", con);
                command.Parameters.AddWithValue("@adm_user", admin);
                command.CommandType = CommandType.StoredProcedure;
                var reader = command.ExecuteReader();
                reader.Read();
                var img = getImage(reader[0]);
                return img;
            }
        }

        private void btnChange_Click_1(object sender, EventArgs e)
        {
            if (isBlank())
            {
               
                if (adminProfile()) 
                {
                    DialogResult res = MessageBox.Show("Are You Want To Refresh The System To See Event Changed!", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.HasFlag(DialogResult.No)) { return; }
                    else
                    {
                        Application.Restart();
                    }
                }
                else if (DoctorProfile())
                {
                    DialogResult res = MessageBox.Show("Are You Want To Refresh The System To See Event Changed!", "Confiramtion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.HasFlag(DialogResult.No)) { return; }
                    else
                    {
                        Application.Restart();
                    }
                }

            }
            else
            {
                MessageBox.Show("Incorrect Username . Please try again.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clears();
            }
        }

        public void Clears()
        {
            Username.Text = "";
            Password.Text = " ";
            ConFirm.Text = " ";
        }

        private bool adminProfile()
        {
            using (SqlConnection con = conClass.Connect())
            {

                try
                {
                   

                    if (Username.Text == "" || Password.Text == " " || ConFirm.Text == "" || picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Dashboard dash = new Dashboard();
                        Username.Text = dash.lblPrintName.Text;
                        picture.Image = dash.pictureBox1.Image;
                        SqlCommand cmd = new SqlCommand("passwordUpdateAdmin", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@adm_user", Username.Text);
                        cmd.Parameters.AddWithValue("@adm_pass", Password.Text);
                        cmd.Parameters.AddWithValue("@admin_photo", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        Clears();
                        MessageBox.Show("Successfully Admin Profile Updated ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                }

                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
            return false;
        }





        private bool DoctorProfile()
        {
            using (SqlConnection con = conClass.Connect())
            {

                try
                {
                    if (Username.Text == "" || Password.Text == " " || ConFirm.Text == "" || picture.Image == null)
                    {
                        MessageBox.Show("Please fill the empty fields....", "Empty Info ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Dashboard dash = new Dashboard();
                        Username.Text = dash.lblPrintName.Text;
                        picture.Image = dash.pictureBox1.Image;
                        SqlCommand cmd = new SqlCommand("passwordUpdateDoctor", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@doc_user", Username.Text);
                        cmd.Parameters.AddWithValue("@doc_pass", Password.Text);
                        cmd.Parameters.AddWithValue("@doc_image", ImageToStreem(picture.Image).ToArray());
                        cmd.ExecuteNonQuery();
                        Clears();
                        MessageBox.Show("Successfully Doctor Profile Updated ✔✔", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                }

                catch (Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }
            }
            return false;
        }



        private bool isBlank()
        {
            if (Username.Text.Trim().Equals("") || Password.Text.Trim().Equals("")|| ConFirm.Text.Trim().Equals(""))
            {
                MessageBox.Show("All Fields Are Required.!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clears();
                return false;
            }
            else
            {

                return true;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdatedProfile_Load(object sender, EventArgs e)
        {

        }
            
    }
}
