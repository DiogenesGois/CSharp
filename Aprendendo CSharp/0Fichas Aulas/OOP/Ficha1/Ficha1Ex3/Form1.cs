using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1Ex3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {
            double largura = double.Parse(tb_largura.Text);
            double comprimento = double.Parse(tb_comprimento.Text);

            lbl_resultado.Text = $"{(largura * comprimento).ToString("F")}";
            lbl_resultado.Visible = true;
        }
    }
}
