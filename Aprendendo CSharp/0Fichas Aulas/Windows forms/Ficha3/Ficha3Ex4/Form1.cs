using System;
using System.Windows.Forms;

namespace Ficha3Ex4 {
    public partial class Form1 : Form {
        int[,] matriz = new int[3, 3];
        int linhas = 0;
        int colunas = 0;
        public Form1() {
            InitializeComponent();
        }

        private void tb_colunas_TextChanged(object sender, EventArgs e) {

        }

        private void btn_ok_Click(object sender, EventArgs e) {
            matriz[linhas, colunas] = int.Parse(tb_numero.Text);
            dgv_matriz[colunas, linhas].Value = matriz[linhas, colunas];
            colunas++;

            if (colunas == 3)
            {
                linhas++;
                colunas = 0;
            }


            tb_colunas.Text = colunas.ToString();
            tb_linhas.Text = linhas.ToString();
            tb_numero.Text = "";
            tb_numero.Focus();

        }

        private void Form1_Load(object sender, EventArgs e) {
            dgv_matriz.Rows.Add(3);
        }

        private void btn_calcular_Click(object sender, EventArgs e) {

            calculo();

        }

        public void calculo() {
            int somaDiagonal = 0;
            int pares = 0;
            int impares = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0) { 
                        pares++;
                    } else
                    {
                        impares++;
                    }

                    
                    if (i == j)
                    {
                        somaDiagonal += matriz[i, j];
                    }
                }
            }

            tb_diagonal.Text = somaDiagonal.ToString();
            tb_pares.Text = pares.ToString();
            tb_impares.Text = impares.ToString();
        }
    }
}
