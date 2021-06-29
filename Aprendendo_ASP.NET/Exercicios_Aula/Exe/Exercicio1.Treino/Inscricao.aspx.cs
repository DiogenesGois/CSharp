using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio1.Treino {
    public partial class Inscricao : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void rbl_genero_SelectedIndexChanged(object sender, EventArgs e) {
            
            ddl_curso.Items.Clear();

            if (rbl_genero.SelectedItem.ToString() == "Masculino")
            {
                ddl_curso.Items.Add("---------");
                ddl_curso.Items.Add("Barbearia");
                ddl_curso.Items.Add("Agricultura");
                ddl_curso.Items.Add("Soldadura");
                ddl_curso.Items.Add("Mecatrónica");

            } else
            {
                ddl_curso.Items.Add("---------");
                ddl_curso.Items.Add("Manicure");
                ddl_curso.Items.Add("Pedicure");
                ddl_curso.Items.Add("Cabeleireiro");
            }
        }

        protected void ddl_conhecia_SelectedIndexChanged(object sender, EventArgs e) {

            if (ddl_conhecia.SelectedItem.ToString() == "Sim")
            {
                Panel1.Visible = true;
            } else
            {
                Panel1.Visible = false;
                cbl_onde.Items.Clear();
                rbl_satisfacao.Items.Clear();
            }
        }

        protected void bto_enviar_Click(object sender, EventArgs e) {

            lb_out.Text = $"{tb_nome.Text} nasceu em {tb_data.Text} é do género {rbl_genero.Text} e está inscrito no curso de {ddl_curso.Text}";
        }
    }
}