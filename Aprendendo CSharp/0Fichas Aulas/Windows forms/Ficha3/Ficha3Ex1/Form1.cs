using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha3Ex1 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            preencher();

        }

        private void btn_pontuar_Click(object sender, EventArgs e) {
            int soma = 0;
            foreach (Object controlo in gb_avaliacao.Controls)
            {
                if (controlo is ComboBox)
                {
                    soma += int.Parse(((ComboBox)controlo).Text);
                }
            }

            ListViewItem novo = new ListViewItem(tb_marca.Text);
            novo.SubItems.Add(tb_modelo.Text);
            novo.SubItems.Add(Avaliacao.avaliacao(soma));

            lstv_avaliacao.Items.Add(novo);

        }

        public void preencher() {

            foreach (Object controlo in gb_avaliacao.Controls)
            {
                if (controlo is ComboBox)
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        ((ComboBox)controlo).Items.Add(i);


                    }
                    ((ComboBox)controlo).Text = "0";
                }
            }

        }

    }

}
