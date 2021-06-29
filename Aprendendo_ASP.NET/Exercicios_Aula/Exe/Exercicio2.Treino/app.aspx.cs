using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio2.Treino {
    public partial class app : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            lbl_mensagem.Text = $"{Session["nome"]} nascem em {Session["data"]} é do género {Session["genero"]} e está inscrito no curso de {Session["curso"]} <br/> " +
                $" Já conhecia o Cinel? {Session["conhecia"]} <br/>" +
                $"Grau de satisfação: {Session["satisfacao"]}";
        }
    }
}