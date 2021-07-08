using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha4Ex1 {
    class Pessoa {
        private int Idade = 0;
        private int Peso = 0;
        private double Altura = 0;
        private double Imc = 0;

        public int Idade1 { get => Idade; set => Idade = value; }
        public int Peso1 { get => Peso; set => Peso = value; }
        public double Altura1 { get => Altura; set => Altura = value; }

        


        public double calculoIMC(int idade, int peso, double altura) {

            this.Imc = peso / (altura * altura);

            return this.Imc;
        }       

    }
}
