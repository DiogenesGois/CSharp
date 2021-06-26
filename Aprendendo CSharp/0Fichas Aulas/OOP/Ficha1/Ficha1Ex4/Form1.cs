using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1Ex4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void tbn_calcular_Click(object sender, EventArgs e) {
            double brancos = double.Parse(tb_brancos.Text);
            double nulos = double.Parse(tb_nulos.Text);
            double validos = double.Parse(tb_valido.Text);
            double total = brancos + nulos + validos;

            lbl_resultBrancos.Text = $"{(brancos / total).ToString("P2")}";
            lbl_resultNulos.Text = $"{(nulos / total).ToString("P2")}";
            lbl_resultValido.Text = $"{(validos / total).ToString("P2")}";
            lbl_resultTotal.Text = $"{total}";

            lbl_resultBrancos.Visible = true;
            lbl_resultNulos.Visible = true;
            lbl_resultValido.Visible = true;
            lbl_resultTotal.Visible = true;
        }
    }
}
