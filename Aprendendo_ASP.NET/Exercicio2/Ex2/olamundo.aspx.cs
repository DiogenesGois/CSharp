using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex2 {
    public partial class olamundo : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_ola_Click(object sender, EventArgs e) {

            lbl_ola.Visible = true;
        }

        protected void btn_adeus_Click(object sender, EventArgs e) {

            lbl_adeus.Visible = true;
        }
    }
}