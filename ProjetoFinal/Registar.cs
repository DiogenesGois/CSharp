using System;
using System.Data;
using System.Windows.Forms;

namespace ProjetoFinal {
    public partial class Registar : Form {

        

        public Registar() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void tb_codMarcaRegistar_Enter(object sender, EventArgs e) {
            if (tb_codMarcaRegistar.Text == "Código da Marca")
            {
                tb_codMarcaRegistar.Text = "";
            }
        }

        private void tb_marcaRegistar_TextChanged(object sender, EventArgs e) {

        }

        private void tb_marcaRegistar_Enter(object sender, EventArgs e) {
            if (tb_marcaRegistar.Text == "Marca")
            {
                tb_marcaRegistar.Text = "";
            }
        }

        private void tb_codModeloRegistar_Enter(object sender, EventArgs e) {
            if (tb_codModeloRegistar.Text == "Código do Modelo")
            {
                tb_codModeloRegistar.Text = "";
            }
        }

        private void tb_modeloRegistar_TextChanged(object sender, EventArgs e) {

        }

        private void tb_modeloRegistar_Enter(object sender, EventArgs e) {
            if (tb_modeloRegistar.Text == "Modelo")
            {
                tb_modeloRegistar.Text = "";
            }
        }

        private void Registar_Load(object sender, EventArgs e) {
            string sqlIdMarca = "SELECT TOP 1 id FROM make ORDER BY ID DESC";

            nud_idmarca.Value = decimal.Parse(BaseDeDados.Consulta(sqlIdMarca).Rows[0][0].ToString()) + 1;
        }

        private void btn_inserir_Click(object sender, EventArgs e) {

            inserir();

        }

        private void tb_idmarca_Enter(object sender, EventArgs e) {
            
        }

        private void tb_idmarca_Leave(object sender, EventArgs e) {
            
        }



        public void inserir() {

            bool inserido = false;
            Carro car = new Carro();
            car.IdMarca = nud_idmarca.Value;
            car.CodigoModelo1 = tb_codModeloRegistar.Text;
            car.Modelo1 = tb_modeloRegistar.Text;

            car.Marca1 = tb_marcaRegistar.Text;
            car.CodigoMarca1 = tb_codMarcaRegistar.Text;
            car.IdMarca = nud_idmarca.Value;

            string sqlExistemodelo = "Select * from model where title = '" + car.Modelo1 + "'";
            string sqlExistemarca = "Select * from make where title = '" + car.Marca1 + "'";

            if (Sessao.logado && Sessao.Codigo >= 2)
            {
                if (BaseDeDados.ExisteCarro(sqlExistemodelo) == false && BaseDeDados.ExisteCarro(sqlExistemarca) == true)
                {
                    if ((tb_codModeloRegistar.Text != "" && tb_codModeloRegistar.Text != "Código do Modelo") && (tb_modeloRegistar.Text != "" && tb_modeloRegistar.Text != "Modelo"))
                    {
                        string sqlIDMarca = "SELECT TOP 1 id FROM make where title = '" + car.Marca1 + "'";
                        car.IdMarca = int.Parse(BaseDeDados.Consulta(sqlIDMarca).Rows[0][0].ToString());
                        BaseDeDados.NovoCarroModelo(car);

                        inserido = true;
                    } else
                    {
                        MessageBox.Show("Apenas será registada a marca");
                    }

                } else if (BaseDeDados.ExisteCarro(sqlExistemodelo) == false && BaseDeDados.ExisteCarro(sqlExistemarca) == false)
                {
                    if ((tb_codModeloRegistar.Text != "" && tb_codModeloRegistar.Text != "Código do Modelo") && (tb_modeloRegistar.Text != "" && tb_modeloRegistar.Text != "Modelo"))
                    {
                        BaseDeDados.NovoCarroModelo(car);

                        inserido = true;
                    } else
                    {
                        MessageBox.Show("Apenas será registada a marca");
                    }

                    if ((tb_codMarcaRegistar.Text != "" && tb_codMarcaRegistar.Text != "Código da Marca") && (tb_marcaRegistar.Text != "" && tb_marcaRegistar.Text != "Marca"))
                    {
                        BaseDeDados.NovoCarroMarca(car);

                        inserido = true;
                    } else
                    {
                        MessageBox.Show("Apenas será registada o modelo");
                    }

                } 

                if (inserido == false)
                {
                    MessageBox.Show("O carro que está a tentar introduzir já se encontra registado na nossa base de dados");
                }

                

            } else
            {
                MessageBox.Show("É necessário estar logado em uma conta com códio 2 ou superior", "Não autorizado");
            }


        }
    }

}
