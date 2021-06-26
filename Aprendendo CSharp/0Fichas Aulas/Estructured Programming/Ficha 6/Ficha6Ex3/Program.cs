using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha6Ex3 {
    class Program {
        static void Main(string[] args) {

            parImpar();


            Console.ReadKey();
        }

        static void parImpar() {
            Random rand = new Random();
            int n = 0;
            int[] vetor;
            int par = 0;
            int impar = 0;


            Console.WriteLine("Indique o valor de n");
            n = int.Parse(Console.ReadLine());

            vetor = new int[n];

            for (int i = 0; i < vetor.GetLength(0); i++)
            {
                vetor[i] = rand.Next(1, 11);
                Console.Write(vetor[i] + "   ");

                if (vetor[i] % 2 == 0)
                {
                    par++;
                } else
                {
                    impar++;
                }

            }

            Console.WriteLine();

            Console.WriteLine($"Números pares: {par}");
            Console.WriteLine($"Números impares: {impar}");
        }
    }
}
