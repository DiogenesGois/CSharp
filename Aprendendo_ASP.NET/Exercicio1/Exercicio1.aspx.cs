using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercicio1 {
    public partial class Exercicio1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void bto_submit_Click(object sender, EventArgs e) {
            
            lbl_out.Visible = true;
            if (rbl_sex.SelectedItem.ToString() == "Male")
            {
                lbl_out.Text = $"Thanks Mister {tb_name.Text} for your feedback";
            }else
            {
                lbl_out.Text = $"Thanks Miss {tb_name.Text} for your feedback";
            }
            
        }
    }
}