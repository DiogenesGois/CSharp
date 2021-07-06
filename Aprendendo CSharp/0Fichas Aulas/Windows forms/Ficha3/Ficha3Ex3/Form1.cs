using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha3Ex3 {
    public partial class Form1 : Form {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int x = 0;
        int y = 0;
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            preencherVetor2(vetor2);

            

            if (int.Parse(tb_posicao2.Text) >= (vetor2.Length))
            {
                MessageBox.Show("Não é possível inserir mais números", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            tb_valor2.Clear();
            tb_valor2.Focus();

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btn_inserir1_Click(object sender, EventArgs e) {
            

            preencherVetor1(vetor1);

            

            if (int.Parse(tb_posicao1.Text) > (vetor1.Length - 1))
            {
                MessageBox.Show("Não é possível inserir mais números", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            tb_valor1.Clear();
            tb_valor1.Focus();
        }

        private void btn_valores_Click(object sender, EventArgs e) {
            preencherLista(vetor1, vetor2);
        }

        private void btn_somar_Click(object sender, EventArgs e) {

            int[] vetorSoma = new int[vetor1.Length];
            for (int i = 0; i < vetorSoma.Length; i++)
            {
                vetorSoma[i] = vetor1[i] + vetor2[i];
                ltb_somar.Items.Add(vetorSoma[i]);
            }
            
        }


        public void preencherVetor1(params int[] vetor) {

            if(x < vetor.Length)
            {
                vetor[x] = int.Parse(tb_valor1.Text);
            }

            x++;
            tb_posicao1.Text = x.ToString();

        }

        public void preencherVetor2(params int[] vetor) {
            

            if (y < vetor.Length)
            {
                vetor[y] = int.Parse(tb_valor2.Text);
            }

            y++;
            tb_posicao2.Text = y.ToString();

        }


        public void preencherLista(int[] vetor1, params int[] vetor2) {

            for (int i = 0; i < vetor1.Length; i++)
            {
                ltb_vetor1.Items.Add(vetor1[i]);
                ltb_vetor2.Items.Add(vetor2[i]);
            }
        }

       

        
    }
}
