using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha6Ex1 {
    class Program {
        static void Main(string[] args) {

            for (int i = 0; i < 3; i++)
            {
                menu();
            }
            

            Console.ReadKey();
        }

        static void identidade(int idade, string nome) {

            Console.WriteLine($"{nome} tem {idade} anos");
        }

        static void menu() {
            int idade = 0;
            string nome = "";

            Console.WriteLine("Qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());

            identidade(idade, nome);
        }
    }
}
