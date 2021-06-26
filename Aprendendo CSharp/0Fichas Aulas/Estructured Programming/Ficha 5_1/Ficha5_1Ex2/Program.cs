using System;

namespace Ficha5_1Ex2 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[,] matriz = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int aux = 0;
            //int aux2 = 0;

            //trocar linha por coluna
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 21);
                    Console.Write(matriz[i, j] + "  ");

                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz2[i, j] = matriz[j, i];
                   
                }

            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz2[i, j] + "  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    for (int l = i; l < matriz.GetLength(0); l++)
                    {
                        for (int m = 0; m < matriz.GetLength(1); m++)
                        {
                            if (matriz[i, j] < matriz[l, m])
                            {
                                aux = matriz[i, j];
                                matriz[i, j] = matriz[l, m];
                                matriz[l, m] = aux;
                            }
                        }
                    }                     
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "  ");
                }

                Console.WriteLine();
            }





            Console.ReadKey();

        }
    }
}
