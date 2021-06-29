using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2 {
    public partial class Exe3 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e) {

            if (rbl_profissao.SelectedItem.ToString() == "Outra")
            {
                tb_qual.Enabled = true;
            } else
            {
                tb_qual.Enabled = false;
                tb_qual.Text = "";
            }
        }

        protected void rbl_musical_SelectedIndexChanged(object sender, EventArgs e) {

            if(rbl_musical.SelectedItem.ToString() == "Outro")
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