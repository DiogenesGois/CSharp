using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1Ex5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {
            double nota1 = double.Parse(tb_nota1.Text) * 0.2;
            double nota2 = double.Parse(tb_nota2.Text) * 0.3;
            double nota3 = double.Parse(tb_nota3.Text) * 0.5;
            double media = nota1 + nota2 + nota3;

            lbl_resultado.Text = $"{media.ToString("F2")}";
            lbl_resultado.Visible = true;
            

        }
    }
}
