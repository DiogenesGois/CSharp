using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace Exercicio3 {
    public partial class Inscricao : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btn_word_Click(object sender, EventArgs e) {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename = ficheiro.doc");
            Response.ContentType = "application/msword";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Response.ContentEncoding = Encoding.Unicode;
            Response.BinaryWrite(Encoding.Unicode.GetPreamble());

            htw.Write($"<table><b>Nome:</b>{tb_nome.Text}<br><b>Curso:</b>{ddl_curso.SelectedItem}<br><b>Email:</b>{tb_email.Text}<br><b>Telemóvel:</b>{tb_telemovel.Text}<br><b>Género:</b>{rbl_genero.SelectedItem}<br></table>");

            Response.Write(sw);
            Response.End();
        }

        protected void btn_excel_Click(object sender, EventArgs e) {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename = ficheiro.xls");
            Response.ContentType = "application/vnd.msexcel";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Response.ContentEncoding = Encoding.Unicode;
            Response.BinaryWrite(Encoding.Unicode.GetPreamble());

            htw.Write($"<table><tr><td><b>Nome</b></td><td>{tb_nome.Text}</td></tr>" +
                $"<tr><td><b>Curso</b></td><td>{ddl_curso.SelectedItem}</td></tr>" +
                $"<tr><td><b>Email</b></td><td>{tb_email.Text}</td></tr>" +
                $"<tr><td><b>Telemóvel</b></td><td align = 'left'>{tb_telemovel.Text}</td></tr>" +
                $"<tr><td><b>Género</b></td><td>{rbl_genero.SelectedItem}</td></tr></table>");

            Response.Write(sw);
            Response.End();
        }
    }
}