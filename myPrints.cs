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
    public partial class myPrints : Form
    {
        public myPrints()
        {
            InitializeComponent();
        }

        private void myPrints_Load(object sender, EventArgs e)
        {
            comboChoose.SelectedItem = "All";
            comboSubPaitient.SelectedItem = "Select Item";
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            SubPateint();
        }


        public void PatientName()
        {
            using(SqlConnection conn = conClass.Connect())
            {
                SqlCommand cmd = new SqlCommand("select* from ResultDiagnosis", conn);
                SqlDataAdapter reader = new SqlDataAdapter(cmd);
                DataSet d_table = new DataSet();
                reader.Fill(d_table);
                comboSubPaitient.DataSource = d_table.Tables[0];
                comboSubPaitient.DisplayMember = "p_name";
                comboSubPaitient.ValueMember = "p_id";

            }
            
        }

        private void comboChoose_TextChanged(object sender, EventArgs e)
        {
            if (comboChoose.SelectedItem == "All")
            {
                comboSubPaitient.Enabled = false;
                Generate.Enabled = false;

            }
            else if (comboChoose.SelectedItem == "Custom")
            {
                comboSubPaitient.Enabled = true;
                Generate.Enabled = true;
                PatientName();


            }

        }

        private void CRPrint_Load(object sender, EventArgs e)
        {

        }
        public void SubPateint()
        {
            using (SqlConnection conn = conClass.Connect())
            {


                try
                {
                    SqlCommand cmd = new SqlCommand("readSpecialRDiag", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", comboSubPaitient.Text);
                    SqlDataAdapter reader = new SqlDataAdapter(cmd);
                    DataTable d_table = new DataTable();
                    reader.Fill(d_table);
                    CrAllPatein cr = new CrAllPatein();
                    cr.SetDataSource(d_table);

                    myPrints prl = new myPrints();
                    prl.CRPrint.ReportSource = cr;
                    prl.Show();
                }
                catch(Exception exec)
                {
                    MessageBox.Show(exec.Message);
                }

            
            }


        }
    }
}
