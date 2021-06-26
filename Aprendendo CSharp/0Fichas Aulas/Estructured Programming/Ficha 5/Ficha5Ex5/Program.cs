using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5Ex5 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int soma1 = 0;
            int soma2 = 0;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz1[i, j] = rand.Next(1, 101);
                    matriz2[i, j] = rand.Next(1, 101);
                    soma1 += matriz1[i, j];
                    soma2 += matriz2[i, j];
                }
            }

            Console.WriteLine($"A soma das matrizes é igual a: {soma1 + soma2}");


            Console.ReadKey();
        }
    }
}
