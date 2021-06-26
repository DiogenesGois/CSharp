using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha8Ex1 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[] vetor = new int[20];

            for (int j = 0; j < vetor.Length; j++)
            {
                vetor[j] = rand.Next(1, 100);
            }

            multiplo(vetor);


            Console.ReadKey();
        }

        static void multiplo(params int[] vetor) {
            
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0 && vetor[i] % 3 == 0)
                {
                    Console.WriteLine($"{vetor[i]} é multiplo de 2 e 3");
                } else
                {
                    Console.WriteLine($"{vetor[i]} não é multiplo de 2 e 3");
                }
            }
        }


    }
}
