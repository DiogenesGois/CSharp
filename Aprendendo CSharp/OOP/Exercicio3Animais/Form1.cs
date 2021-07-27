using System;
using System.Windows.Forms;

namespace Exercicio3Animais {
    public partial class Form1 : Form {
        string[] nomes = new string[5];
        string[] tipos = new string[5];
        int cont = 0;
        public Form1() {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e) {

            if (cont > 3)
            {
                btn_adicionar.Enabled = false;
               
            } else
            {
                nomes[cont] = tb_nome.Text;
                tipos[cont] = tb_tipo.Text;
            }               

            cont++;
        }

        private void btn_finalizar_Click(object sender, EventArgs e) {
            Animais a = new Animais();
            int cao = 0;
            int gato = 0;
            int peixe = 0;
            


            for (int i = 0; i <= cont; i++)
            {
                a.setNome(nomes[i]);
                a.setTipo(tipos[i]);
                

                if (a.getTipo() == "cachorro")
                {
                    cao++;
                } else if (a.getTipo() == "gato")
                {
                    gato++;

                } else
                {
                    peixe++;
                }
            }

            
            tb_cachorro.Text = cao.ToString();
            tb_gato.Text = gato.ToString();
            tb_peixe.Text = peixe.ToString();

        }
    }
}
