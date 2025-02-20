﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2 {
    public partial class app : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["logado"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btn_sair_Click(object sender, EventArgs e) {
            
            Session.Abandon();
            Session.Clear();
            Response.Redirect("login.aspx");
        }
    }
}