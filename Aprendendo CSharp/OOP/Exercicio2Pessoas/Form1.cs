using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2Pessoas {
    public partial class Form1 : Form {
        string[] nomes = new string[3];
        int[] idades = new int[3];
        int cont = 0;
        public Form1() {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e) {
            int maior = 0;
            string nome = "";

            for (int i = 0; i < nomes.Length; i++)
            {
                if (maior < idades[i])
                {
                    maior = idades[i];
                    nome = nomes[i];
                }
            }

            Pessoa p1 = new Pessoa(nome, maior);
            lbl_velho.Text = p1.ExibirDados();

            lbl_velho.Visible = true;
        }

        private void btn_adicionar_Click(object sender, EventArgs e) {

            nomes[cont] = tb_nome.Text;
            idades[cont] = int.Parse(tb_idade.Text);

            cont++;
        }
    }
}
