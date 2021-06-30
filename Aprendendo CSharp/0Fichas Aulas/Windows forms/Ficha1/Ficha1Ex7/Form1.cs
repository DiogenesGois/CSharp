using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1Ex7 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {
            double num1 = double.Parse(tb_num1.Text);
            double num2 = double.Parse(tb_num2.Text);
            
            if (cb_operacao.Text.ToString() == "Soma")
            {
                MessageBox.Show($"{num1 + num2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (cb_operacao.Text.ToString() == "Subtração")
            {
                MessageBox.Show($"{num1 - num2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (cb_operacao.Text.ToString() == "Multiplicação")
            {
                MessageBox.Show($"{num1 * num2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (cb_operacao.Text.ToString() == "Divisão")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("ERRO: Impossível dividir por 0", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    MessageBox.Show($"{num1 - num2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e) {

            tb_num1.Text = "";
            tb_num2.Text = "";
            cb_operacao.Text = "";
        }
    }
}
