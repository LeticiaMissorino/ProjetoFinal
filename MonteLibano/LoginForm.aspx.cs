using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonteLibano
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastrar2_onClick(object sender, EventArgs e)
        {
            Model.Login login = new Model.Login();
            Controller.ControllerLogin con = new Controller.ControllerLogin();
            string senha1= txtpassword1.Text;
            string senha2= txtpasswordrepeat1.Text;

            if (senha1 != senha2)
            {
                Response.Write("<script>alert('Senhas incompatives!');</script>");
            }
            else {

                login.email = txtusername1.Text;
                login.senha = senha1;
                login.cnpj ="";
               
            }

            if (login.email != null)
            {

                if (con.InsertLogin(login))
                {
                    Response.Redirect("~/UserForm.aspx?Email=" + login.email);
                }
                else
                {
                    Response.Write("<script>alert('ERRO');</script>");
                }
            }
        }

    }
}