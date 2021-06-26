using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5Ex9 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[,] matriz = new int[6, 6];
            int menorDiagonal = int.MaxValue;
            int menorDiagonalSecundaria = 150;
            int linhaPrincipal = 0;
            int colunaPrincipal = 0;
            int linhaSecundaria = 0;
            int colunaSecundaria = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 101);
                    Console.Write(matriz[i, j] + "  ");

                    if (i == j)
                    {
                        if (matriz[i, j] < menorDiagonal)
                        {
                            menorDiagonal = matriz[i, j];
                            linhaPrincipal = i;
                            colunaPrincipal = j;
                        }                       
                    }

                    if (i + j == matriz.GetLength(0) - 1)
                    {
                        if (matriz[i, j] < menorDiagonalSecundaria)
                        {
                            menorDiagonalSecundaria = matriz[i, j];
                            linhaSecundaria = i;
                            colunaSecundaria = j;

                        }
                    }
                   
                }
                Console.WriteLine("");
            }          
            
             Console.WriteLine($"Menor da diagonal: {menorDiagonal} na linha {linhaPrincipal + 1} e coluna {colunaPrincipal + 1}");
             Console.WriteLine($"Menor da diagonal secundária: {menorDiagonalSecundaria} na linha {linhaSecundaria + 1} e coluna {colunaSecundaria + 1} ");

            Console.ReadKey();
        }
    }
}
