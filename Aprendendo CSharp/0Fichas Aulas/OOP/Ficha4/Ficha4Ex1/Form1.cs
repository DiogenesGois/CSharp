using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha4Ex1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e) {

            Pessoa p = new Pessoa();

            p.Idade1 = int.Parse(tb_idade.Text);
            p.Peso1 = int.Parse(nud_peso.Value.ToString());
            p.Altura1 = double.Parse(nud_altura.Value.ToString());

            tb_imc.Text = p.calculoIMC(p.Idade1, p.Peso1, p.Altura1).ToString("F2");


            riscoEclassificacao();

        }

        private void btn_repor_Click(object sender, EventArgs e) {
            repor();
        }

        public void riscoEclassificacao() {

            if (rb_masculino.Checked)
            {
                if (double.Parse(tb_imc.Text) >= 17.9 && double.Parse(tb_imc.Text) <= 18.5)
                {
                    tb_risco.Text = "Baixo";
                    tb_classificacao.Text = "Magreza";
                } else if (double.Parse(tb_imc.Text) >= 18.6 && double.Parse(tb_imc.Text) <= 24.9)
                {
                    tb_risco.Text = "Sem risco";
                    tb_classificacao.Text = "Normal";
                } else if (double.Parse(tb_imc.Text) >= 25 && double.Parse(tb_imc.Text) <= 27.7)
                {
                    tb_risco.Text = "Moderado";
                    tb_classificacao.Text = "Sobrepeso";
                } else if (double.Parse(tb_imc.Text) >= 27.8)
                {
                    tb_risco.Text = "Elevado";
                    tb_classificacao.Text = "Obesidade";
                }
            }


            if (rb_feminino.Checked)
            {
                if (double.Parse(tb_imc.Text) >= 15 && double.Parse(tb_imc.Text) <= 19.9)
                {
                    tb_risco.Text = "Baixo";
                } else if (double.Parse(tb_imc.Text) >= 18 && double.Parse(tb_imc.Text) <= 24.9)
                {
                    tb_risco.Text = "Sem risco";
                } else if (double.Parse(tb_imc.Text) >= 25 && double.Parse(tb_imc.Text) <= 27.2)
                {
                    tb_risco.Text = "Moderado";
                } else if (double.Parse(tb_imc.Text) >= 27.3)
                {
                    tb_risco.Text = "Elevado";
                }

            }
        }

        
      

        public void repor() {

            tb_idade.Text = "";
            tb_imc.Text = "";
            tb_classificacao.Text = "";
            tb_risco.Text = "";
            nud_altura.Value = 0;
            nud_peso.Value = 0;
            tb_idade.Focus();

        }

    }
}
