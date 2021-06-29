using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio1 {
    public partial class exercicio2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void imgb_circulo_Click(object sender, ImageClickEventArgs e) {

            
            imgb_out.Visible = true;
            imgb_out.ImageUrl = imgb_circulo.ImageUrl;
        }

        protected void imgb_quadrado_Click(object sender, ImageClickEventArgs e) {
            
            imgb_out.Visible = true;
            imgb_out.ImageUrl = imgb_quadrado.ImageUrl;
            //imgb_out.Width = imgb_quadrado.Width;
        }

        protected void imgb_triangulo_Click(object sender, ImageClickEventArgs e) {

            imgb_out.Visible = true;
            imgb_out.ImageUrl = imgb_triangulo.ImageUrl;
            //imgb_out.Width = imgb_triangulo.Width;
        }

        protected void imgb_out_Click(object sender, ImageClickEventArgs e) {

            imgb_out.Visible = false;
            imgb_out.ImageUrl = "";

        }
    }
}