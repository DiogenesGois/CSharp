using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha6Ex2 {
    class Program {
        static void Main(string[] args) {

            aleatorio();

            Console.ReadKey();
        }

        static void aleatorio() {
            Random rand = new Random();
            int[] vetor = new int[15];
            double soma = 0;
            double media = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(0, 10);
                soma += vetor[i];
                Console.Write(vetor[i] + "  ");
            }

            media = soma / vetor.Length;

            Console.WriteLine();
            Console.WriteLine($"A média é: {media:0.00}");

        }
    }
}
