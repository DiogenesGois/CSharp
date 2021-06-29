using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio1 {
    public partial class Inscricao : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e) {
            ddl_curso.Items.Clear();

            if (rbl_genero.SelectedItem.ToString() == "Masculino")
            {
                ddl_curso.Items.Add("Barbearia");
                ddl_curso.Items.Add("Agricultura");
                ddl_curso.Items.Add("Soldadura");
                ddl_curso.Items.Add("Mecatrónica");
            } else
            {
                ddl_curso.Items.Add("Manicure");
                ddl_curso.Items.Add("Pedicure");
                ddl_curso.Items.Add("Cabelereiro");
            }

        }

        protected void ddl_conhecia_SelectedIndexChanged(object sender, EventArgs e) {

            if (ddl_conhecia.SelectedItem.ToString() == "Sim")
            {
                Panel1.Visible = true;
            } else
            {
                Panel1.Visible = false;

            }
        }

        protected void bto_enviar_Click(object sender, EventArgs e) {

            if (tb_nome.Text == "")
            {
                Response.Write("Preencha o campo nome");
            }else if (tb_data.Text == "")
            {
                Response.Write("Preencha o campo data de nascimento");
            }else if (rbl_genero.Text == "")
            {
                Response.Write("Preencha o campo género");
            }else if (ddl_curso.Text == "")
            {
                Response.Write("Preencha o campo cursos");
            } else
            {
                lb_out.Text = $"{tb_nome.Text} nasceu a {tb_data.Text}, é do género {rbl_genero.Text} e frequenta o curso de {ddl_curso.Text}";
            }

            
        }
    }
}