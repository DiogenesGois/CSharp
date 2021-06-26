using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            int numero = 0;
            int soma = 0;

            Console.WriteLine("Insira um número");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if ( i % 2 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"Soma de todos os números pares entre 0 e {numero} = {soma}");


            Console.ReadKey();
        }
    }
}
