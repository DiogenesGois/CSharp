using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2Ex4 {
    public partial class Form1 : Form {
        int contador = -1;
        int soma = 0;
        public Form1() {
            InitializeComponent();
        }

        private void lbl_resultado_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {     

            
        }

        private void btn_adicionar_Click(object sender, EventArgs e) {
            
            lsb_numeros.Items.Add(tb_numero.Text);

            soma += int.Parse(tb_numero.Text);
            contador++;


            if (tb_numero.Text == "0")
            {
                lbl_resultado.Text = $"A soma de todos os números é {soma} e a média {soma / contador} ";
                lbl_resultado.Visible = true;
            }
            
        }
    }
}
