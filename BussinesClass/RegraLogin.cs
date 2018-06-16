using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesClass
{
    public class RegraLogin
    {
        SqlConnection con  = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLSERVER"].ConnectionString);


        public bool ValidateLogin(string login, string senha)
        {
            SqlCommand cmd = new SqlCommand("select count(1) from login where email = @login and senha = @senha");
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            //  cmd.ExecuteNonQuery();
            cmd.Connection = con;
            con.Open();
          //  con.Close();
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
