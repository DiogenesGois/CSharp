using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2Ex2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            cb_parImpar.Items.Add("Par");
            cb_parImpar.Items.Add("Ímpar");
        }

        private void cb_parImpar_SelectedIndexChanged(object sender, EventArgs e) {
            lsb_resultado.Items.Clear();

            if (cb_parImpar.SelectedItem.ToString() == "Par")
            {
                for (int i = 0; i <= 20; i++)
                {
                    if(i % 2 == 0)
                    {
                        lsb_resultado.Items.Add(i);
                    }
                }
            } else
            {
                for (int i = 0; i <= 20; i++)
                {
                    if (i % 2 != 0)
                    {
                        lsb_resultado.Items.Add(i);
                    }
                }
            }
        }
    }
}
