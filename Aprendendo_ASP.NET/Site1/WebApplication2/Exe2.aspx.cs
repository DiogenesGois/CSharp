using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2 {
    public partial class Exe2 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void bto_mostrar_Click(object sender, EventArgs e) {

            lbl_mensagem.Text = $"{tb_nome.Text} nasceu a {tb_data.Text}";
        }
    }
}