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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            if (check_User())
            {

            }
            else if (check_UserDoctor())
            {

            }
            else if (check_UserReception())
            {

            }


            else
            {
                MessageBox.Show(" Invalid Username Please try again......", "Invalid Username ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clears();
            }
        }


        private bool check_User()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select adm_sec_que from admin   where adm_user='"+Username.Text+"'", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                         GetQuestion.Text= reader[0].ToString();
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
                SqlCommand cmd = new SqlCommand("select doc_sec_que from doctor where doc_user='" + Username.Text + "'", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        GetQuestion.Text = reader[0].ToString();
                        return true;
                    }

                }
            }

            return false;
        }


        private bool check_UserReception()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand(" select recep_sec_que from receptions where recep_user='" + Username.Text + "'", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        GetQuestion.Text = reader[0].ToString();
                        return true;
                    }

                }
            }

            return false;
        }


        private bool check_UserPassword()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select adm_sec_ans, adm_pass from admin   where adm_user='" + Username.Text+"' and  adm_sec_que='"+ GetQuestion.Text+ "' and adm_sec_ans='"+ EnterAnswer.Text + "'", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        string answer= reader[0].ToString();
                        if (EnterAnswer.Text == answer)
                        {
                            lblPrintPassword.Text = reader[1].ToString();

                        }
                        
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Answer Please try again......", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
            }

            return false;
        }


        private bool check_DoctorPassword()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand(" select  doc_sec_ans , doc_pass from doctor where doc_user='"+Username.Text+"' and doc_sec_que='"+GetQuestion.Text+"' and doc_sec_ans='"+EnterAnswer.Text+"'", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        string answer = reader[0].ToString();
                        if (EnterAnswer.Text == answer)
                        {
                            lblPrintPassword.Text = reader[1].ToString();

                        }

                        return true;
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Answer Please try again......", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
            }

            return false;
        }


        private bool check_ReceptionPassword()
        {
            using (SqlConnection con = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("  select   recep_sec_ans , recep_pass from receptions where recep_user='"+Username.Text+"' and recep_sec_que='"+GetQuestion.Text+"' and   recep_sec_ans='"+EnterAnswer.Text+"'", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    if (reader.HasRows)
                    {
                        string answer = reader[0].ToString();
                        if (EnterAnswer.Text == answer)
                        {
                            lblPrintPassword.Text = reader[1].ToString();

                        }

                        return true;
                    }
                    else
                    {
                        MessageBox.Show(" Invalid Answer Please try again......", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
            }

            return false;
        }



        private void GetPassword_Click(object sender, EventArgs e)
        {

            if (isBlank())
            {
                if (check_UserPassword())
                {

                }
                else if (check_DoctorPassword())
                {

                }
                else if (check_ReceptionPassword())
                {

                }

                else
                {
                    MessageBox.Show(" Invalid Answer Please try again......", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool isBlank()
        {
            if (Username.Text.Trim().Equals("") || GetQuestion.Text.Trim().Equals("") || EnterAnswer.Text.Trim().Equals(""))
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

        public void Clears()
        {
            GetQuestion.Text = " ";
            EnterAnswer.Text = " ";
            Username.Text = " ";
        }

        private void btnForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login fr = new Login();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clears();
        }
    }
}
