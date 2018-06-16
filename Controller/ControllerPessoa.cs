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
    public class ControllerPessoa
    {
        SqlConnection con;

        public ControllerPessoa()
        {
            con = new SqlConnection
                (ConfigurationManager.ConnectionStrings["SQLSERVER"].
                ConnectionString);
            //con.Open();
        }

        public bool InsertPessoa(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            //proc para adicionar o evento 
            cmd.CommandText = "InsertPessoa";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@Cpf", pessoa.cnpj));
            cmd.Parameters.Add(new SqlParameter("@Email", pessoa.email));
            cmd.Parameters.Add(new SqlParameter("@Rg", pessoa.rg));
            cmd.Parameters.Add(new SqlParameter("@Passaporte", pessoa.passaporte));
            cmd.Parameters.Add(new SqlParameter("@Nome", pessoa.nome));
            cmd.Parameters.Add(new SqlParameter("@nomeSocial", pessoa.nomeSocial));
            cmd.Parameters.Add(new SqlParameter("@Rne", pessoa.rne));
            cmd.Parameters.Add(new SqlParameter("@isGravida", pessoa.isGravida));
            cmd.Parameters.Add(new SqlParameter("@isPrimeira", pessoa.isPrimeira));
            cmd.Parameters.Add(new SqlParameter("@Facebook", pessoa.facebook));
            cmd.Parameters.Add(new SqlParameter("@Status", pessoa.status));
            cmd.Parameters.Add(new SqlParameter("@Localidade", pessoa.localidade));
            cmd.Parameters.Add(new SqlParameter("@Logradouro", pessoa.logradouro));
            cmd.Parameters.Add(new SqlParameter("@Complemento", pessoa.complemento));
            cmd.Parameters.Add(new SqlParameter("@Bairro", pessoa.bairro));
            cmd.Parameters.Add(new SqlParameter("@Cep", pessoa.cep));
            cmd.Parameters.Add(new SqlParameter("@Uf", pessoa.uf));
            cmd.Parameters.Add(new SqlParameter("@Pais", pessoa.pais));
            cmd.Parameters.Add(new SqlParameter("@Numero", pessoa.numero));
            cmd.Parameters.Add(new SqlParameter("@idEstadoCivil", pessoa.idEstadoCivil));
            cmd.Parameters.Add(new SqlParameter("@idSexo", pessoa.idSexo));
            cmd.Parameters.Add(new SqlParameter("@idNacionalidade", pessoa.idNacionalidade));
            cmd.Parameters.Add(new SqlParameter("@dtNasc", pessoa.dtNasc));
            cmd.Parameters.Add(new SqlParameter("@isMenor", pessoa.isMenor));
            cmd.Parameters.Add(new SqlParameter("@respMenor", pessoa.respMenor));

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }

        public bool UpdatePessoa(Pessoa pessoa)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            //proc para adicionar o evento 
            cmd.CommandText = "";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@descricao", pessoa.cnpj));

            con.Open();
            //cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            return true;
        }
        
        public void Listar(String pessoa)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "upSelecionarPessoa";

            //parametros da proc 
            cmd.Parameters.Add(new SqlParameter("@email", pessoa));

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            
        }

        private DataTable RetornoDataTable()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;

        }

        //public string UsuarioLogado(string login) {
        //    SqlCommand cmd = new SqlCommand();

        //    cmd.CommandType = CommandType.Text;

        //    //proc para adicionar o evento 
        //    cmd.CommandText = "select cpf from login where @email";
        //    cmd.Parameters.Add(new SqlParameter("@email", login));

        //    con.Open();
        //    //cmd.Connection = con;
        //    cmd.ExecuteNonQuery();
    
        //    con.Close();
            
        //   return teste;

        //}
    }
}
