using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class Exe3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void tb_qual_TextChanged(object sender, EventArgs e) {
            
        }

        protected void rbl_profissao_SelectedIndexChanged(object sender, EventArgs e) {
            
            if (rbl_profissao.SelectedItem.ToString() == "Outra")
            { 
                tb_qual.Enabled = true;
            } else
            {
                tb_qual.Enabled = false;
                tb_qual.Text = "";
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e) {

            if (RadioButtonList1.SelectedItem.ToString() == "Outro")
            {
                Panel1.Visible = true;
            } else
            {
                Panel1.Visible = false;
                tb_musical_qual.Text = "";
            }
        }
    }
}