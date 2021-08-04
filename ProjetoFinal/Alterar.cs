using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFinal {
    public partial class Alterar : Form {
        DataTable dt = new DataTable();
        
        public Alterar() {
            InitializeComponent();
        }

        private void Alterar_Load(object sender, EventArgs e) {
            //this.dgv_alterar.ScrollBars = ScrollBars.None;
            //this.dgv_alterar.MouseWheel += new MouseEventHandler(mousewheel);
            dgv_alterar.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 27, 30);
            dgv_alterar.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(169, 188, 208);

            //string sql = "select mo.id as Número, mo.code as 'Código do Modelo', mo.title as Modelo, ma.code as 'Código da Marca', ma.title as Marca from make as ma inner join model as mo on mo.make_id = ma.id";
            dt = BaseDeDados.Consulta();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgv_alterar.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
            }

            //dgv_alterar.DataSource = BaseDeDados.Consulta(sql);
            dgv_alterar.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
            dgv_alterar.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 27, 30);
            dgv_alterar.ForeColor = Color.FromArgb(169, 188, 208);
        }

        private void mousewheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0 && dgv_alterar.FirstDisplayedScrollingRowIndex > 0)
            {
                dgv_alterar.FirstDisplayedScrollingRowIndex--;
            } else if (e.Delta < 0)
            {
                dgv_alterar.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void bt_alterar_Click(object sender, EventArgs e) {
   

            if (Sessao.logado && Sessao.Codigo >= 2)
            {
                if (dgv_alterar.SelectedRows.Count > 0)
                {
                    DialogResult res = MessageBox.Show("Tem a certeza que pretende atuallizar a tabela?", "Atualização", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        
                        dt = BaseDeDados.Consulta();

                        Carro car = new Carro();
                        car.Id = int.Parse(dgv_alterar.SelectedRows[0].Cells[0].Value.ToString());
                        car.CodigoMarca1 = tb_codMarca.Text;
                        car.CodigoModelo1 = tb_codModelo.Text;
                        car.Marca1 = tb_marca.Text;
                        car.Modelo1 = tb_modelo.Text;

                        BaseDeDados.AtualizarMarca(car);
                        BaseDeDados.AtualizarModelo(car);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dgv_alterar.Rows.Add(dt.Rows[i][0], dt.Rows[i][1], dt.Rows[i][2], dt.Rows[i][3], dt.Rows[i][4]);
                        }

                        //dgv_alterar.DataSource = BaseDeDados.Consulta();
                    }
                }else
                {
                    MessageBox.Show("Para alterar um registo é necessário selecionar uma linha da base de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            } else
            {
                MessageBox.Show("É necessário estar logado em uma conta com códio 2 ou superior", "Não autorizado");
            }


        }

        private void tb_codMarca_Enter(object sender, EventArgs e) {
            if (tb_codMarca.Text == "Código da Marca")
            {
                tb_codMarca.Text = "";
            }
        }

        private void tb_codMarca_Leave(object sender, EventArgs e) {

            if (tb_codMarca.Text == "")
            {
                tb_codMarca.Text = "Código da Marca";
            }
        }

        private void tb_marca_TextChanged(object sender, EventArgs e) {

        }

        private void tb_marca_Enter(object sender, EventArgs e) {
            if (tb_marca.Text == "Marca")
            {
                tb_marca.Text = "";
            }
        }

        private void tb_marca_Leave(object sender, EventArgs e) {
            if (tb_marca.Text == "")
            {
                tb_marca.Text = "Marca";
            }
        }

        private void tb_codModelo_Enter(object sender, EventArgs e) {
            if (tb_codModelo.Text == "Código do Modelo")
            {
                tb_codModelo.Text = "";
            }
        }

        private void tb_codModelo_Leave(object sender, EventArgs e) {
            if (tb_codModelo.Text == "")
            {
                tb_codModelo.Text = "Código do Modelo";
            }
        }

        private void tb_modelo_Enter(object sender, EventArgs e) {
            if (tb_modelo.Text == "Modelo")
            {
                tb_modelo.Text = "";
            }
        }

        private void tb_modelo_Leave(object sender, EventArgs e) {
            if (tb_modelo.Text == "")
            {
                tb_modelo.Text = "Modelo";
            }
        }

        private void dgv_alterar_SelectionChanged(object sender, EventArgs e) {
            DataGridView dgv = (DataGridView)sender;
            int conl = dgv.SelectedRows.Count;

            if (conl > 0)
            {
                string id = dgv_alterar.SelectedRows[0].Cells[0].Value.ToString();

                dt = BaseDeDados.CarroID(id);


                tb_codModelo.Text = dt.Rows[0].ItemArray[1].ToString();
                tb_modelo.Text = dt.Rows[0][2].ToString();
                tb_codMarca.Text = dt.Rows[0][3].ToString();
                tb_marca.Text = dt.Rows[0][4].ToString();

            } 
        }

        private void btn_apagar_Click(object sender, EventArgs e) {

            if (Sessao.logado && Sessao.Codigo >= 2)
            {
                DialogResult res = MessageBox.Show("Tem a certeza que pretende apagar os dados da tabela?", "Atualização", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    string idmodelo = dgv_alterar.SelectedRows[0].Cells[0].Value.ToString();

                    //BaseDeDados.ApagarCarroMarca(idmodelo);
                    BaseDeDados.ApagarCarroModelo(idmodelo);

                    dgv_alterar.Rows.Remove(dgv_alterar.CurrentRow);

                    MessageBox.Show("Registo apagado com sucesso", "Sucesso");
                }
            } else
            {
                MessageBox.Show("É necessário estar logado em uma conta com códio 2 ou superior", "Não autorizado");
            }
        }

        private void btn_selecionar_Click(object sender, EventArgs e) {

        }

        private void dgv_alterar_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
