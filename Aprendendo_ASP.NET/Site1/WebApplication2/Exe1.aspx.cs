using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2 {
    public partial class Exe1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_mostrar_Click(object sender, EventArgs e) {
            Response.Write($"Olá {tb_nome.Text}");
        }

      
      

        protected void ddl_curso_SelectedIndexChanged1(object sender, EventArgs e) {

            ddl_modulos.Items.Clear();

            if (ddl_curso.SelectedItem.ToString() == "CETTPSI")
            {
                ddl_modulos.Items.Add("Algoritmo");
                ddl_modulos.Items.Add("POO");
                ddl_modulos.Items.Add("Programação estruturada");

            } else if (ddl_curso.SelectedItem.ToString() == "CETREDES")
            {
                ddl_modulos.Items.Add("Topologia de redes");
                ddl_modulos.Items.Add("Sistemas Operativos");
                ddl_modulos.Items.Add("Encriptação");

            } else if (ddl_curso.SelectedItem.ToString() == "CETMultimedia")
            {
                ddl_modulos.Items.Add("Audio");
                ddl_modulos.Items.Add("Video");
                ddl_modulos.Items.Add("Design");
            }
        }
    }
}