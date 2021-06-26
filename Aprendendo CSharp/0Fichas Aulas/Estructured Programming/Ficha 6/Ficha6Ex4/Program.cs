using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha6Ex4 {
    class Program {
        static void Main(string[] args) {
            int[] vetor = new int[5];


            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Insira a idade");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            idade(vetor);

            Console.ReadKey();

        }


        static void idade(params int[] idade) {
            int soma = 0;

            if (idade.Length < 1)
            {
                Console.WriteLine("Não existem valores a serem somados");
            }else if (idade.Length < 2)
            {
                Console.WriteLine($"Valores insuficientes para serem somados {idade[0]}");
            } else
            {
                for (int i = 0; i < idade.Length; i++)
                {
                    soma += idade[i];
                }
            }
            Console.WriteLine($"A média é: {soma / idade.Length}");
        }
    }
    
}
