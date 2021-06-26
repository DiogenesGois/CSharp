using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha8Ex4 {
    class Program {
        static void Main(string[] args) {
            int x = 0;

            Console.WriteLine("Insira o número que deseja ver o fatorial");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine($"O fatorial de {x} é: {fatorial(x)}");

            Console.ReadKey();
        }

        static int fatorial(int x) {
            int fatorial = 1;

            for (int i = x; i > 1; i--)
            {
                fatorial *= i;
            }

            return fatorial;
        }
    }
}
