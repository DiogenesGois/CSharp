using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2Ex3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_somar_Click(object sender, EventArgs e) {
            int num1 = int.Parse(tb_bottom.Text);
            int num2 = int.Parse(tb_top.Text);

            lbl_resultado.Text = $"A soma é: {Soma_Intervalo.soma(num1, num2)}";

            lbl_resultado.Visible = true;
        }
    }
}
