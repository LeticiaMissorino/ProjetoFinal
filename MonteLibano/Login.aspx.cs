using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonteLibano
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               
           
        }

        protected void btnEntrar_onClick(object sender, EventArgs e)
        {
            BussinesClass.RegraLogin regra = new BussinesClass.RegraLogin();
            bool loginOK= regra.ValidateLogin(txtusername.Text, txtpassword.Text);
            if (loginOK) {
                 Session.Add("CPF", "");
                Response.Redirect("~/Default.aspx?Email=" + txtusername.Text);
            } else {
                lblLoginInvalido.Visible = true;
            }
        }

        protected void btnCadastrar2_onClick(object sender, EventArgs e)
        {
            Model.Login login = new Model.Login();
            Controller.ControllerLogin con = new Controller.ControllerLogin();

            login.email = "";
            login.senha = "345";

            login.cnpj = "";

            if (con.InsertLogin(login))
            {
                Response.Redirect("~/UserForm.aspx");
            }
            else {
                Response.Write("<script>alert('ERRO');</script>");
            }
        }

        protected void btnCadastrar_onClick(object sender, EventArgs e) {

            Response.Redirect("~/LoginForm.aspx");
                
         }

    }
}