using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1Ex1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {

            tb_irs.Text = $"{((double.Parse(tb_salario.Text) * 15) / 100).ToString("#.##")}";

            tb_segSocial.Text = $"{((double.Parse(tb_salario.Text) * 12) / 100).ToString("#.##")}";

            tb_salarioLiquido.Text = $"{(double.Parse(tb_salario.Text) - double.Parse(tb_segSocial.Text) - double.Parse(tb_irs.Text)).ToString("#.##")}";
        }
    }
}
