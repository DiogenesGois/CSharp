using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5Ex8 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[,] matriz = new int[5, 5];
            int A = 0;
            int igualMatriz = 0;
            int igualDiagonal = 0;
            int igualPrimeiraColuna= 0;
            int maior = 0;
            int somaMaiores = 0;

            Console.WriteLine("Indique um número entre 1 e 100");
            A = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 101);

                    if (matriz[i, j] == A)
                    {
                        igualMatriz++;
                    }
                    if (matriz[i, j] == A && i == j)
                    {
                        igualDiagonal++;
                    }
                    if (matriz[i, j] == A && j == 0)
                    {
                        igualPrimeiraColuna++;
                    }
                    if (matriz[i, j] > A)
                    {
                        maior++;
                        somaMaiores += matriz[i, j];
                    }

                }
            }


            Console.WriteLine($"Iguais na matriz: {igualMatriz}");
            Console.WriteLine($"Iguais na diagonal: {igualDiagonal}");
            Console.WriteLine($"Iguais na primeira coluna: {igualPrimeiraColuna}");
            Console.WriteLine($"Maiores na matriz: {maior}");
            Console.WriteLine($"Soma dos maiores: {somaMaiores}");


            Console.ReadKey();
        }
    }
}
