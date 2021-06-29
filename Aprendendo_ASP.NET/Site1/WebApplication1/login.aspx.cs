using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_entrar_Click(object sender, EventArgs e) {

            //Session["nome"] = tb_nome.Text;
            
            if (tb_nome.Text.ToString() == "admin" && tb_pass.Text.ToString() == "123")
            {
                Session["logado"] = "sim";
                Response.Redirect("app.aspx");
            }
            
        }
    }
}