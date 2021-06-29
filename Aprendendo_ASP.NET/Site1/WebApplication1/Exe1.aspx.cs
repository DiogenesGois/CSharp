using System;

namespace WebApplication1 {
    public partial class Exe1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button1_Click(object sender, EventArgs e) {
            Response.Write($"Olá {txtBox1.Text}");
        }

        protected void ddl_curso_SelectedIndexChanged(object sender, EventArgs e) {

            ddl_modulos.Items.Clear();

            if (ddl_curso.SelectedItem.ToString() == "CetTPSI")
            {
                ddl_modulos.Items.Add("Algoritmos");
                ddl_modulos.Items.Add("POO");
                ddl_modulos.Items.Add("Programação estruturada");
                ddl_modulos.Items.Add("Base de dados");

            }else if (ddl_curso.SelectedItem.ToString() == "CETredes")
            {
                ddl_modulos.Items.Add("Topologia de redes");
                ddl_modulos.Items.Add("Sistemas Operativos");
                ddl_modulos.Items.Add("Encriptação");

            }else if (ddl_curso.SelectedItem.ToString() == "CETMultimedia")
            {
                ddl_modulos.Items.Add("Audio");
                ddl_modulos.Items.Add("Video");
                ddl_modulos.Items.Add("Design");
            }

        }
    }
}