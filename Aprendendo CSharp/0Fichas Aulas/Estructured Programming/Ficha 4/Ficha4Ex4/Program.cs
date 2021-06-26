using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4Ex4 {
    class Program {
        static void Main(string[] args) {
            int[] vetor = {2, 4, 35, 50, 23, 17, 9, 12, 27 };
            int maior = 0;
            int soma = 0;
            double media = 0;


            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i]; 

                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
            }

            Array.Sort(vetor);
            media = soma / vetor.Length;
            

            
            Console.WriteLine($"Maior valor: {maior}");
            //Console.WriteLine($"Média do vetor: {vetor.Average():0.00}");
            Console.WriteLine($"Média do vetor: {media:0.00}");
            foreach (int n in vetor)
            {
                Console.WriteLine(n);
            }



            Console.ReadKey();
        }
    }
}
