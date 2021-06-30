using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha3Ex2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

            preencherCb();
        }

        private void preencherCb() {

            foreach (Object controlo in this.Controls)
            {
                if (controlo is ComboBox)
                {
                    for (int i = 0; i <= 20; i++)
                    {
                        ((ComboBox)controlo).Items.Add(i);
                    }
                    ((ComboBox)controlo).Text = "10";
                }
                
            }
        }

        private void btn_submeter_Click(object sender, EventArgs e) {
            int linguas = 0;
            int media = 0;
            string situacao = "";

            foreach (Object caixa in gb_linguas.Controls)
            {
                if (((CheckBox)caixa).Checked)
                {
                    linguas++;
                }
                
            }

            media = (int.Parse(cb_escrita.Text) + int.Parse(cb_fisica.Text) + int.Parse(cb_oral.Text)) / 3;

            if (media >= 10 && linguas >= 2)
            {
                situacao = "Aprovado";
            } else
            {
                situacao = "Reprovado";
            }

            dgv_registo.Rows.Add(tb_nome.Text, cb_escrita.Text, cb_oral.Text, cb_fisica.Text, linguas, situacao);
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            limpar();
        }

        private void limpar() {
            cb_escrita.Text = "10";
            cb_oral.Text = "10";
            cb_fisica.Text = "10";
            tb_nome.Text = "";
            tb_nome.Focus();

            foreach (Object caixa in gb_linguas.Controls)
            {
                ((CheckBox)caixa).Checked = false;
            }
        }
    }
}
