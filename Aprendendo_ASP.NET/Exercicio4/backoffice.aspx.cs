using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace Exercicio4 {
    public partial class backoffice : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["log"] == null)
            {
                Response.Redirect("app.aspx");
            }
            lbl_info.Text = $"Nome: {Session["nome"]}<br> Morada: {Session["morada"]}<br> Email: {Session["email"]}<br> Data de nascimento: {Session["data"]}<br> Género: {Session["genero"]} ";
        }

        protected void btn_word_Click(object sender, EventArgs e) {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename = info.doc");
            Response.ContentType = "application/vdn-msword";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Response.ContentEncoding = Encoding.Unicode;
            Response.BinaryWrite(Encoding.Unicode.GetPreamble());

            htw.Write($"<table><b>Nome:</b> {Session["nome"]} <br>" +
                $"<b>Morada:</b> {Session["morada"]} <br>" +
                $"<b>Email:</b> {Session["email"]} <br>" +
                $"<b>Data de nascimento:</b> {Session["data"]} <br>" +
                $"<b>Género:</b> {Session["genero"]} <br></table>");

            Response.Write(sw);
            Response.End();
        }

        protected void btn_excel_Click(object sender, EventArgs e) {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename = info.xls");
            Response.ContentType = "application/vdn-msexcel";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Response.ContentEncoding = Encoding.Unicode;
            Response.BinaryWrite(Encoding.Unicode.GetPreamble());

            htw.Write($"<table><tr><td><b>Nome:</b></td><td>{Session["nome"]}</td></tr>" +
                $"<tr><td><b>Morada:</b></td><td>{Session["morada"]}</td></tr>" +
                $"<tr><td><b>Email:</b></td><td>{Session["email"]}</td></tr>" +
                $"<tr><td><b>Data de nascimento:</b></td><td align = 'left'>{Session["data"]}</td></tr>" +
                $"<tr><td><b>Género:</b></td><td>{Session["genero"]}</td></tr></table>");

            Response.Write(sw);
            Response.End();
        }

        protected void Button1_Click(object sender, EventArgs e) {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename = info.xml");
            Response.ContentType = "text/xml";

            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Response.ContentEncoding = Encoding.Unicode;
            Response.BinaryWrite(Encoding.Unicode.GetPreamble());

            htw.Write($"<formulario>" +
                $"<nome>{Session["nome"]}</nome>" +
                $"<morada>{Session["morada"]}</morada>" +
                $"<email>{Session["email"]}</email>" +
                $"<data>{Session["data"]}</data>" +
                $"<genero>{Session["genero"]}</genero>" +
                $"</formulario>");

            Response.Write(sw);
            Response.End();
        }

        protected void btn_pdf_Click(object sender, EventArgs e) {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename = info.pdf");
            Response.ContentType = "application/pdf";

            string conteudo = $"<table border = '1' align = 'center'>" +
                $"<tr>" +
                $"<td colspan = '2' align = 'center'><h1>Informações</h1></td>" +
                $"</tr>" +
                $"<tr>" +
                $"<td>Nome</td>" +
                $"<td>{Session["nome"]}</td>" +
                $"</tr>" +
                $"<tr>" +
                $"<td>Morada</td>" +
                $"<td>{Session["morada"]}</td>" +
                $"</tr>" +
                $"<tr>" +
                $"<td>Data de nascimento</td>" +
                $"<td>{Session["data"]}</td>" +
                $"</tr>" +
                $"<td>Género</td>" +
                $"<td>{Session["genero"]}</td>" +
                $"</tr>" +
                $"</table>";

            StringReader sr = new StringReader(conteudo);

            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);

            HTMLWorker hw = new HTMLWorker(pdfDoc);

            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            pdfDoc.Open();
            hw.Parse(sr);
            pdfDoc.Close();

            Response.Write(pdfDoc);
            Response.End();
        }
    }
}