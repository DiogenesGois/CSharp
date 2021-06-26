using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5Ex7 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int N = 0;
            int M = 0;

            Console.WriteLine("Indique o valor de N");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique o valor de M");
            M = int.Parse(Console.ReadLine());

            int[,] matrizA = new int[N, M];
            int[,] matrizB = new int[N, M];
            int[,] matrizC = new int[N, M];


            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = rand.Next(1, 101);
                    matrizB[i, j] = rand.Next(1, 101);
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                    Console.Write(matrizC[i, j] + "  ");
                }
                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
