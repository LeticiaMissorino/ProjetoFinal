using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ControllerLogin
    {
        SqlConnection con;

        public ControllerLogin()
        {
            con = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLSERVER"].
                ConnectionString);
            //con.Open();
        }

        public bool InsertLogin(Login login)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            //proc para adicionar o evento 
            cmd.CommandText = "upInsertLogin";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@Cpf", login.cnpj));
            cmd.Parameters.Add(new SqlParameter("@Senha", login.senha));
            cmd.Parameters.Add(new SqlParameter("@email", login.email));
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        
        public bool AtualizarLogin(string email, string cpf)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            //proc para adicionar o evento 
            cmd.CommandText = "updateLogin";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@Cpf", cpf));
            cmd.Parameters.Add(new SqlParameter("@email", email));
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }


        public void Listar(Login login)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "upSelectEvento";

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

        }


    }
}
