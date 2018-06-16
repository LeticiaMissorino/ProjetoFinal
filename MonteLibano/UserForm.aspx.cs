using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonteLibano
{
    public partial class UserForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    if (!string.IsNullOrEmpty(Request.QueryString["Email"].ToString()))
            //    {
            //        Controller.ControllerPessoa con = new Controller.ControllerPessoa();
            //        con.Listar(Request.QueryString["Email"].ToString());
            //    }
            //}

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Model.Pessoa pessoa = new Model.Pessoa();
            Controller.ControllerPessoa con = new Controller.ControllerPessoa();
            Controller.ControllerLogin log = new Controller.ControllerLogin();

            pessoa.nome = fullname.Text;
            pessoa.cnpj = cpf.Text;
            pessoa.rg = rg.Text;
            pessoa.cep = cep.Text;
            pessoa.logradouro = logradouro.Text;
            pessoa.numero = Convert.ToInt32(numero.Text);
            pessoa.complemento = complemento.Text;
            pessoa.bairro = bairro.Text;
            pessoa.dtNasc = DateTime.Now;
            pessoa.email = Request.QueryString["Email"].ToString();
            pessoa.passaporte = "";
            pessoa.nomeSocial = "";
            pessoa.rne = "";
            pessoa.isGravida = false;
            pessoa.isPrimeira = false;
            pessoa.facebook = "";
            pessoa.status = "";
            pessoa.idEstadoCivil = 0;
            pessoa.idNacionalidade = 0;
            pessoa.idSexo = 0;
            pessoa.isMenor = false;
            pessoa.respMenor = "";
            pessoa.localidade = "";
            pessoa.uf = "";
            pessoa.pais = "";


            if (con.InsertPessoa(pessoa))
            {
                log.AtualizarLogin(pessoa.email, pessoa.cnpj);
                Session.Add("CPF", pessoa.cnpj);
                Response.Write("<script>alert('Registro inserido com sucesso');</script>");
                Response.Redirect("~/Event.aspx");
            }
            else
                Response.Redirect("~/Default.aspx");


        }
    }
}