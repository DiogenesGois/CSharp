using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha5Ex1 {
    public partial class Form1 : Form {
        int cont = 1;
        Pizza p = new Pizza();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            cboIngredientes.Items.Add("Ananás");
            cboIngredientes.Items.Add("Atum");
            cboIngredientes.Items.Add("Azeitonas");
            cboIngredientes.Items.Add("Bacon");
            cboIngredientes.Items.Add("Camarão");
            cboIngredientes.Items.Add("Carne de Vaca");
            cboIngredientes.Items.Add("Cebola");
            cboIngredientes.Items.Add("Chouriço");
            cboIngredientes.Items.Add("Cogumelos");
            cboIngredientes.Items.Add("Feta");
            cboIngredientes.Items.Add("Fiambre");
            cboIngredientes.Items.Add("Frango");
            cboIngredientes.Items.Add("Milho");
            cboIngredientes.Items.Add("Molho Barbecue");
            cboIngredientes.Items.Add("Molho Picante");
            cboIngredientes.Items.Add("Mozzarella");
            cboIngredientes.Items.Add("Parmessão");
            cboIngredientes.Items.Add("Pepperoni");
            cboIngredientes.Items.Add("Pimentos");
            cboIngredientes.Items.Add("Tomate");

            cboMassa.Items.Add("Fina");
            cboMassa.Items.Add("Pan");
            cboMassa.Items.Add("Rolling");

            cboTamanho.Items.Add("Individual");
            cboTamanho.Items.Add("Média");
            cboTamanho.Items.Add("Familiar");


        }

        private void btn_adicionar_Click(object sender, EventArgs e) {
            
            if (cont <= 5)
            {
                p.Ingredientes1 = cont;
                p.Massa1 = cboMassa.Text;
                p.Tamanho1 = cboTamanho.Text;

                lb_ingredientes.Items.Add(cboIngredientes.Text);
            }else
            {
                btn_adicionar.Enabled = false;
            }
            

            cont++;
        }

        private void btn_finalizar_Click(object sender, EventArgs e) {

            if (cboMassa.Text == "Fina")
            {
                p.Massa1 = "Fina";
            }else if (cboMassa.Text == "Pan")
            {
                p.Massa1 = "Pan";
            } else if (cboMassa.Text == "Rolling")
            {
                p.Massa1 = "Rolling";
            }

            if (cboTamanho.Text == "Individual")
            {
                p.Tamanho1 = "Individual";
            } else if (cboTamanho.Text == "Média")
            {
                p.Tamanho1 = "Média";
            } else if (cboTamanho.Text == "Familiar")
            {
                p.Tamanho1 = "Familiar";
            }

            if (cboIngredientes.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (cboTamanho.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (cboMassa.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (cont < 2)
            {
                MessageBox.Show("Escolha no mínimo 2 ingredientes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else
            {
                tb_total.Text = p.calcPreco().ToString();
            }

        }

        private void btn_repor_Click(object sender, EventArgs e) {

            cboIngredientes.Text = "";
            cboMassa.Text = "";
            cboTamanho.Text = "";
            tb_total.Text = "";
            lb_ingredientes.Items.Clear();

        }
    }
}
