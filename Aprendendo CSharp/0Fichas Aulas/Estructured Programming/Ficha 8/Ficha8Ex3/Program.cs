using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha8Ex3 {
    class Program {
        static void Main(string[] args) {

            intervalo();

            Console.ReadKey();
        }

        static void intervalo() {
            int n = 0;
            int m = 0;
            int soma = 0;
            int contador = 0;


            Console.WriteLine("Insira o valor de n");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de n");
            m = int.Parse(Console.ReadLine());

            for (int i = n; i <= m; i++)
            {
                soma += i;

                if (i % 2 == 0)
                {
                    contador++;
                    Console.Write(i + "  ");
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{contador} números pares");
        }
    }
}
