using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2Ex6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {


            lbl_resultado.Text = Fibonacci.enesimo(int.Parse(tb_numero.Text));
            lbl_resultado.Visible = true;
        }
    }
}
