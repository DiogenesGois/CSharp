using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2Ex5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e) {
            double ladox = double.Parse(tb_ladox.Text);
            double ladoy = double.Parse(tb_ladoy.Text);
            double ladoz = double.Parse(tb_ladoz.Text);
            double area = 0;

            if (ladox == ladoy && ladoy == ladoz)
            {
                lbl_mostra.Text = $"O triangulo é equilátero, o perímetro é {Triangulo.forma(ladox, ladoy, ladoz, out area)} e a área {area.ToString("F2")}";
            } else if ((ladox == ladoy && ladoy != ladoz) || (ladox == ladoz && ladoz != ladoy) || (ladoy == ladoz && ladoz != ladox))
            {
                lbl_mostra.Text = $"O triangulo é isósceles, o perímetro é {Triangulo.forma(ladox, ladoy, ladoz, out area)} e a área {area.ToString("F2")}";
            } else if (ladox != ladoy && ladox != ladoz && ladoy != ladoz)
            {
                lbl_mostra.Text = $"O triangulo é escaleno, o perímetro é {Triangulo.forma(ladox, ladoy, ladoz, out area)} e a área {area.ToString("F2")}";
            } else
            {
                lbl_mostra.Text = "Os lados não formam um triângulo";
            }


            lbl_mostra.Visible = true;

        }

        private void lbl_mostra_Click(object sender, EventArgs e) {

        }
    }
}
