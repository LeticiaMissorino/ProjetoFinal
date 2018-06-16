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
    public class ControllerEvento
    {
        SqlConnection con;

        public ControllerEvento()
        {
            con = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLSERVER"].
                ConnectionString);
            //con.Open();
        }

        public bool InsertEvento(Evento evento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            //proc para adicionar o evento 
            cmd.CommandText = "upInsertEvento";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@Cnpj", evento.cnpj));
            cmd.Parameters.Add(new SqlParameter("@Nome", evento.nome));
            cmd.Parameters.Add(new SqlParameter("@Dtevento", evento.dtEvento));
            cmd.Parameters.Add(new SqlParameter("@Local", evento.local));
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public bool UpdateEvento(Evento evento)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            //proc para adicionar o evento 
            cmd.CommandText = "";
            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@descricao", evento.nome));

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
