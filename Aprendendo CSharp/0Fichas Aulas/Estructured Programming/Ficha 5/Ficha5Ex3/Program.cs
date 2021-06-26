using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5Ex3 {
    class Program {
        static void Main(string[] args) {
            int[,] matriz = new int[4, 4];
            Random rand = new Random();
            int maior = 0;
            int menor = 150;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                    Console.Write(matriz[i,j] + "  ");

                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }

                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                    }
                }
                Console.WriteLine("");
            }

            Console.WriteLine($"A soma do menor e maior valor é {maior + menor}");


            Console.ReadKey();
        }
    }
}
