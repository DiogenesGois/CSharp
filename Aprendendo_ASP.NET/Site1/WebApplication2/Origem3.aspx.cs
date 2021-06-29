using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2 {
    public partial class Origem3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void bto_enviar_Click(object sender, EventArgs e) {

            Session["nome"] = tb_nome.Text;
            Response.Redirect("Destino3.aspx");
        }
    }
}