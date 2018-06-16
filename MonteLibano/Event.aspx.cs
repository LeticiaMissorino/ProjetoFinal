using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonteLibano
{
    public partial class Event : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Controller.ConnectionSQLServer conn = new Controller.ConnectionSQLServer();

            //DataSet ds = new DataSet();

            //string cmdstr = "Select Id, CONCAT(CONVERT(varchar(10), Dtevento) + '- ' , Nome)  AS NOME, * from evento";

            //SqlDataAdapter adp = new SqlDataAdapter(cmdstr, conn.getConnectionSQlServer());

            //adp.Fill(ds);

            //customRadio.DataSource = ds;

            //customRadio.DataTextField = "nome";

            //customRadio.DataValueField = "id";

            //customRadio.DataBind();
        }

        protected void btnConfirmarPresenca_onClick(object sender, EventArgs e)
        {
            Model.Anamnese objan = new Model.Anamnese();
            objan.idEvento = Convert.ToInt32(drop.SelectedValue);
            string cpf = Session["CPF"].ToString();
            objan.cpf = cpf;
            objan.obs = "";
            objan.presenca = false;
            objan.statusemocional = "";
            objan.status = "";
         
            Controller.ControllerAnamnese an = new Controller.ControllerAnamnese();
            if (an.InsertAnamnese(objan))
            {
                Response.Write("<script>alert('Inscrição Confirmada!');</script>");
                
            }
            else
                Response.Write("<script>alert(' ERRO na Inscrição !');</script>");
        }
    }
}