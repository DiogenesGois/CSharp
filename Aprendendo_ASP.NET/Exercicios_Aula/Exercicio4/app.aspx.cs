using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio4 {
    public partial class app : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_enviar_Click(object sender, EventArgs e) {
            Session["nome"] = tb_nome.Text;
            Session["morada"] = tb_morada.Text;
            Session["email"] = tb_email.Text;
            Session["data"] = tb_data.Text;
            Session["genero"] = rbl_genero.Text;

            Session["log"] = "log";

            Response.Redirect("backoffice.aspx");
        }
    }
}