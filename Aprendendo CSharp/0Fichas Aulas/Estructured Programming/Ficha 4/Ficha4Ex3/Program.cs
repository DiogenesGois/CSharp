using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4Ex3 {
    class Program {
        static void Main(string[] args) {
            int[] vetor = new int[20];
            Random rand = new Random();
            int par = 0;
            int impar = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(1, 100);

                if (vetor[i] % 2 == 0)
                {
                    par++;
                } else
                {
                    impar++;
                }
            }

            foreach (int n in vetor)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"{par} números pares");
            Console.WriteLine($"{impar} números ímpares");

            Console.ReadKey();
        }
    }
}
