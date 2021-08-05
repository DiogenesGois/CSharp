using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjetoFinal {
    public partial class Procurar : Form {
        DataTable dtModelo = new DataTable();
        DataTable dtMarca = new DataTable();
        private object after;

        public object RepeatOnNewPage { get; private set; }
        public object KeepWithGroup { get; private set; }

        public Procurar() {
            InitializeComponent();
            this.dgv_procurar.ScrollBars = ScrollBars.None;
            this.dgv_procurar.MouseWheel += new MouseEventHandler(mousewheel);


        }

        private void mousewheel(object sender, MouseEventArgs e) {

            if (e.Delta > 0 && dgv_procurar.FirstDisplayedScrollingRowIndex > 0)
            {
                dgv_procurar.FirstDisplayedScrollingRowIndex--;
            } else if (e.Delta < 0)
            {
                dgv_procurar.FirstDisplayedScrollingRowIndex++;
            }

        }

        private void btn_procurar_Click(object sender, EventArgs e) {
            string marca = cb_marca.Text;
            string modelo = cb_modelo.Text;

            if ((marca != "MARCA" && marca != "") && (modelo == "MODELO" || modelo == ""))
            {
                string existe = "select * from make where title = '" + marca + "'";
                if (BaseDeDados.ExisteCarro(existe))
                {
                    DataTable dt = new DataTable();
                    string sql = "select mo.make_id as 'Número da marca', mo.id as 'Número do Modelo', mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from make as ma inner join model as mo on mo.make_id = ma.id where mo.make_id in (select id from make where title = '" + marca + "')";
                    dt = BaseDeDados.Consulta(sql);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv_procurar.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
                    }
                    dgv_procurar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
                    dgv_procurar.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
                    dgv_procurar.ForeColor = Color.FromArgb(169, 188, 208);
                } else
                {
                    MessageBox.Show("O marca que procura não se encontra registada na nossa base de dados, poderá realizar esse registo no menu \" Registar\"", "Marca não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } else if ((marca == "MARCA" || marca == "") && (modelo != "MODELO" && modelo != "") || ((marca != "MARCA" && modelo != "MODELO") && (marca != "" && modelo != "")))
            {
                string existe = "select * from model where title = '" + modelo + "'";
                if (BaseDeDados.ExisteCarro(existe))
                {

                    DataTable dt = new DataTable();
                    string sql = "select mo.id as Número, mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from model as mo inner join make as ma on mo.make_id = ma.id where mo.title = '" + modelo + "'";
                    dt = BaseDeDados.Consulta(sql);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgv_procurar.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
                    }

                    //dgv_procurar.DataSource = BaseDeDados.Consulta(sql);
                    dgv_procurar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
                    dgv_procurar.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
                    dgv_procurar.ForeColor = Color.FromArgb(169, 188, 208);
                } else
                {
                    MessageBox.Show("O carro que procura não se encontra registado na nossa base de dados, poderá realizar esse registo no menu \"Registar\"", "Modelo não encontrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else if ((marca == "MARCA" && modelo == "MODELO") || (marca == "" && modelo == ""))
            {
                MessageBox.Show("Preencha pelo menos um dos campos", "Preencher Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                MessageBox.Show("O carro que procura não se encontra registado na nossa base de dados, poderá realizar esse registo no menu \"Registar\"", "Carro não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dgv_procurar.Enabled = true;


        }

        private void tb_marca_Enter(object sender, EventArgs e) {


        }

        private void tb_marca_Leave(object sender, EventArgs e) {

        }

        private void tb_modelo_TextChanged(object sender, EventArgs e) {

        }

        private void tb_modelo_Enter(object sender, EventArgs e) {


        }

        private void tb_modelo_Leave(object sender, EventArgs e) {


        }

        private void Procurar_Load(object sender, EventArgs e) {
            string sqlMarcas = "select title from make order by title";
            string sqlModelo = "select title from model";
            dtMarca = BaseDeDados.Consulta(sqlMarcas);
            dtModelo = BaseDeDados.Consulta(sqlModelo);

            for (int i = 0; i < dtMarca.Rows.Count; i++)
            {
                cb_marca.Items.Add(dtMarca.Rows[i][0]);

            }

            for (int i = 0; i < dtModelo.Rows.Count; i++)
            {

                cb_modelo.Items.Add(dtModelo.Rows[i][0]);
            }

        }

        private void cb_marca_SelectedIndexChanged(object sender, EventArgs e) {
            cb_modelo.Items.Clear();

            string sql = "select title from model where make_id in (select id from make where title = '" + cb_marca.SelectedItem.ToString() + "')";
            dtModelo = BaseDeDados.Consulta(sql);

            for (int i = 0; i < dtModelo.Rows.Count; i++)
            {
                cb_modelo.Items.Add(dtModelo.Rows[i][0]);
            }


        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            cb_marca.Text = "MARCA";
            cb_modelo.Text = "MODELO";
            dgv_procurar.Rows.Clear();
            cb_modelo.Items.Clear();

            for (int i = 0; i < dtModelo.Rows.Count; i++)
            {

                cb_modelo.Items.Add(dtModelo.Rows[i][0]);
            }

        }

        private void btn_exportar_Click(object sender, EventArgs e) {
            string sql;
            string marca = cb_marca.Text;
            string modelo = cb_modelo.Text;
            string dados = "";
            string ficheiro = @"C:\Users\dioge\CET60\0Programacao de computadores - orientada a objetos - Feito\Projetos\ProjetoFinal\pdfs\carro.pdf";//caminho ficheiro
            FileStream filePdf = new FileStream(ficheiro, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, filePdf);



            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\dioge\CET60\0Programacao de computadores - orientada a objetos - Feito\Projetos\ProjetoFinal\Assets\logo_transparent.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_CENTER;
            logo.SetAbsolutePosition(240f, 730f); //x,-y           




            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("\n\n\n\nRelatório de Procura\n");

            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("AUTO SEARCH - " + cb_marca.Text + "\n\n\n");

            PdfPTable tabela = new PdfPTable(5);//5 colunas
            tabela.DefaultCell.BackgroundColor = BaseColor.LIGHT_GRAY;


            tabela.AddCell("Número");
            tabela.AddCell("Código do modelo");
            tabela.AddCell("Modelo");
            tabela.AddCell("Código da marca");
            tabela.AddCell("Marca");

            if ((marca != "MARCA" && marca != "") && (modelo == "MODELO" || modelo == ""))
            {
                sql = "select mo.make_id as 'Número da marca', mo.id as 'Número do Modelo', mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from make as ma inner join model as mo on mo.make_id = ma.id where mo.make_id in (select id from make where title = '" + marca + "')";


            } else
            {
                sql = "select mo.id as Número, mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from model as mo inner join make as ma on mo.make_id = ma.id where mo.title = '" + modelo + "'";

            }


            DataTable dtCarros = BaseDeDados.Consulta(sql);
            for (int i = 0; i < dtCarros.Rows.Count; i++)
            {
                tabela.AddCell(dtCarros.Rows[i][0].ToString());
                tabela.AddCell(dtCarros.Rows[i][1].ToString());
                tabela.AddCell(dtCarros.Rows[i][2].ToString());
                tabela.AddCell(dtCarros.Rows[i][3].ToString());
                tabela.AddCell(dtCarros.Rows[i][4].ToString());
            }



            DialogResult res = MessageBox.Show("Deseja abrir o relatório de procura?", "Relatório de procura", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Users\dioge\CET60\0Programacao de computadores - orientada a objetos - Feito\Projetos\ProjetoFinal\pdfs\carro.pdf");
            }


            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(tabela);            
            doc.Close();

        }


    }
}
