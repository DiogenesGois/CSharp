using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class Destino2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            lbl_mensagem.Text = $"Bem-vindo {Request.Form["tb_nome"]}";
        }
    }
}