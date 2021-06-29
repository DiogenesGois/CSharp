using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio2 {
    public partial class dados : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["conhecia"].ToString() == "Sim")
            {
                lbl_mensagem.Text = $"{Session["nome"]} nasceu a {Session["data"]}, é do genero {Session["genero"]} e frequenta o curso de {Session["curso"]}. <br/> Conhecia o Cinel? {Session["conhecia"]}. <br/>Grau de satisfação: {Session["satisfacao"]}";
            } else
            {
                lbl_mensagem.Text = $"{Session["nome"]} nasceu a {Session["data"]}, é do genero {Session["genero"]} e frequenta o curso de {Session["curso"]}. <br/> Conhecia o Cinel? {Session["conhecia"]}";
            }

            
        }
    }
}