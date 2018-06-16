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
    public class ControllerAnamnese
    {
        SqlConnection con;

        public ControllerAnamnese()
        {
            con = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLSERVER"].
                ConnectionString);
            //con.Open();
        }

        public bool InsertAnamnese(Anamnese anamnese)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            //proc para adicionar o evento 
            cmd.CommandText = "upInsertAnamnese";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@Cpf", anamnese.cpf));
            cmd.Parameters.Add(new SqlParameter("@Obs", anamnese.obs));
            cmd.Parameters.Add(new SqlParameter("@idEvento", anamnese.idEvento));
            cmd.Parameters.Add(new SqlParameter("@Presenca", anamnese.presenca));
            cmd.Parameters.Add(new SqlParameter("@statusEmocional", anamnese.statusemocional));
            cmd.Parameters.Add(new SqlParameter("@Aceite", anamnese.aceite));
            cmd.Parameters.Add(new SqlParameter("@Status ", anamnese.status));
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        
        public bool UpdateAnamnese(Anamnese anamnese)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            //proc para adicionar o evento 
            cmd.CommandText = "";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@descricao", anamnese.obs));

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public void Listar()
        {

        }


    }
}
