using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1Ex6 {
    public partial class frm_parImpar : Form {
        public frm_parImpar() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {

            int num = int.Parse(tb_numero.Text);

            if (num % 2 == 0)
            {
                MessageBox.Show($"{num} é par", "Par ou Ímpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show($"{num} é ímpar", "Par ou Ímpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e) {

            tb_numero.Text = "";
            tb_numero.Focus();
        }
    }
}
