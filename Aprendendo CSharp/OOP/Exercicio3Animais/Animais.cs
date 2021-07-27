using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3Animais {
    class Animais {

        private string Nome;
        private string Tipo;

        public string Nome1 { get => Nome; set => Nome = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value;  }

        public string getNome() {
            return Nome;
        }

        public string getTipo() {
            return Tipo;
        }

        public void setNome(string nome) {
            this.Nome = nome;
        }

        public void setTipo(string tipo) {
            this.Tipo = tipo;
        }


        public Animais() {
            Nome = "";
            Tipo = "";
        }

       
    }
}
