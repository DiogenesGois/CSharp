using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2Ex1 {
    class Program {
        static void Main(string[] args) {
            int numero = 0;

            Console.WriteLine("Insira um número");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par");
            } else
            {
                Console.WriteLine($"{numero} é ímpar");
            }

            Console.ReadKey();
        }
    }
}
