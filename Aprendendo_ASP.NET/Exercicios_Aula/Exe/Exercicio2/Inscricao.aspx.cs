using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio2 {
    public partial class Inscricao : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            Session["nome"] = tb_nome.Text;
            Session["data"] = tb_data.Text;
            Session["genero"] = rbl_genero.Text;
            Session["curso"] = ddl_curso.Text;
            Session["conhecia"] = ddl_conhecia.Text;
            Session["satisfacao"] = rbl_satisfacao.Text;
            Response.Redirect("dados.aspx");
        }

        protected void rbl_genero_SelectedIndexChanged(object sender, EventArgs e) {

            ddl_curso.Items.Clear();

            if (rbl_genero.SelectedItem.ToString() == "Masculino")
            {
                ddl_curso.Items.Add("Barbearia");
                ddl_curso.Items.Add("Agricultura");
                ddl_curso.Items.Add("Soldadura");
                ddl_curso.Items.Add("Mecatrónica");

            }else
            {
                ddl_curso.Items.Add("Manicure");
                ddl_curso.Items.Add("Pedicure");
                ddl_curso.Items.Add("Cabeleireiro");
            }
        }

        protected void ddl_conhecia_SelectedIndexChanged(object sender, EventArgs e) {

            if (ddl_conhecia.SelectedItem.ToString() == "Sim")
            {
                Panel1.Visible = true;
            }else
            {
                Panel1.Visible = false;
            }
        }
    }
}