using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1Alunos {
    public partial class Form1 : Form {
        string[] nome = new string[10];
        string[] matricula = new string[10];
        double[] nota1 = new double[10];
        double[] nota2 = new double[10];
        double[] notat = new double[10];
        double[] media = new double[10];
        double[] final = new double[10];      
        int cont = 0;
        public Form1() {
            InitializeComponent();
        }

        private void btn_registar_Click(object sender, EventArgs e) {
            Aluno aluno = new Aluno();

            aluno.Nome1 = tb_nome.Text;
            aluno.Matricula1 = tb_matricula.Text;
            aluno.Nota11 = double.Parse(tb_nota1.Text);
            aluno.Nota21 = double.Parse(tb_nota2.Text);
            aluno.NotaTrabalho1 = double.Parse(tb_trabalho.Text);

            nome[cont] = aluno.Nome1;
            matricula[cont] = aluno.Matricula1;
            nota1[cont] = aluno.Nota11;
            nota2[cont] = aluno.Nota21;
            notat[cont] = aluno.NotaTrabalho1;
            media[cont] = aluno.media();
            final[cont] = aluno.final();


            tb_nome.Text = "";
            tb_matricula.Text = "";
            tb_nota1.Text = "";
            tb_nota2.Text = "";
            tb_trabalho.Text = "";
            tb_nome.Focus();

            cont++;
            
        }

        private void btn_consultar_Click(object sender, EventArgs e) {
            Registo registo = new Registo();

            for (int i = 0; i < cont; i++){

                registo.dgv_registo.Rows.Add(nome[i], matricula[i], nota1[i], nota2[i], notat[i], media[i].ToString("F2"), final[i].ToString("F2"));
                
            }
            registo.Show();
        }
    }
}
