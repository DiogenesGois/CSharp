using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2Pessoas {
    public class Pessoa {

        private string Nome;
        private int Idade;

        public string ExibirDados() {    
            
            return $"Nome :{Nome}, Idade: {Idade}";
        }

        public Pessoa() {
            Nome = "";
            Idade = 0;
        }

        public Pessoa(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }
    }
}
