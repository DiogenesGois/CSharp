using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ficha3Ex5 {
    public partial class form_registo : Form {
        public string[] nomes = new string[10];
        public double[,] notas = new double[10, 3];
        int linhas = 0;
        
        public form_registo() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            double media = 0;
            string situacao = "";

            Form1 formulario = new Form1();

            for (int i = 0; i < linhas; i++)
            {          

            media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;

            if (media >= 10)
            {
                situacao = "Aprovado";
            } else
            {
                situacao = "Reprovado";
            }

            formulario.dgw_consulta.Rows.Add(nomes[i], notas[i, 0].ToString(), notas[i, 1].ToString(), notas[i, 2].ToString(), media.ToString("F2"), situacao.ToString());
            }

            formulario.Show();
        }

        private void btn_inserir_Click(object sender, EventArgs e) {
            

            notas[linhas, 0] = int.Parse(nud_portugues.Value.ToString());
            notas[linhas, 1] = int.Parse(nud_matematica.Value.ToString());            
            notas[linhas, 2] = int.Parse(nud_tic.Value.ToString());
            nomes[linhas] = tb_nome.Text;

            
            linhas++;
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            tb_nome.Text = "";
            tb_nome.Focus();
            nud_portugues.Value = 0;
            nud_matematica.Value = 0;
            nud_tic.Value = 0;

        }
    }
}
