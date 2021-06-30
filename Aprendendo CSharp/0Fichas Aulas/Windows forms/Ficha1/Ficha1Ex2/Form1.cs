using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1Ex2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void tbn_calcular_Click(object sender, EventArgs e) {
            double km = double.Parse(tb_km.Text);
            double litros = double.Parse(tb_consumo.Text);
            double preco = double.Parse(tb_combustivel.Text);

            tb_cem.Text = $"{((litros / km) * 100).ToString("#.##")}";

            tb_gasto.Text = $"{(litros * preco).ToString("#.##")}";
        }
    }
}
