using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1Alunos {
    class Aluno {
        private string Nome = "";
        private string Matricula = "";
        private double Nota1 = 0;
        private double Nota2 = 0;
        private double NotaTrabalho = 0;

        public string Nome1 { get => Nome; set => Nome = value; }
        public string Matricula1 { get => Matricula; set => Matricula = value; }
        public double Nota11 { get => Nota1; set => Nota1 = value; }
        public double Nota21 { get => Nota2; set => Nota2 = value; }
        public double NotaTrabalho1 { get => NotaTrabalho; set => NotaTrabalho = value; }

        public double media() {

            double media = (Nota1 * 0.25) + (Nota2 * 0.25) + (NotaTrabalho * 0.2);

            return media;
        }

        public double final() {
            
            if(media() >= 5)
            {
                return 0;
            } else
            {
                return 5 - media();
            }
        }
    }
}
