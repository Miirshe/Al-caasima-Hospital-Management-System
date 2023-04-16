using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class conClass
    {
        public static SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=AL_CAASIMA_HOSPTAL_MANAGEMENTS;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
