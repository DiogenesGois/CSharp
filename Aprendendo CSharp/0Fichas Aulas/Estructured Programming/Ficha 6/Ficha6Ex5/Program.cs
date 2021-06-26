using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha6Ex5 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(parImpar());

            Console.ReadKey();
        }

        static string parImpar() {
            int numero = 0;

            Console.WriteLine("Insira um número");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                return "Par";
            } else
            {
                return "Ímpar";
            }

        }
    }
}
