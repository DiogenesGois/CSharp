using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class Destino3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            lbl_mensagem.Text = $"Bem-vindo {Session["nome"]} tem {Session["idade"]}";
        }

        protected void bto_sair_Click(object sender, EventArgs e) {

            Session.Abandon();
            Session.Clear();
            Response.Redirect("Origem3.aspx");
        }
    }
}