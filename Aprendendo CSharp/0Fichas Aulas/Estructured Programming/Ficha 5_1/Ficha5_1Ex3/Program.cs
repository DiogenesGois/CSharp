using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5_1Ex3 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[,] matriz = new int[24, 4];
            int cama1 = 0;
            int cama2 = 0;
            int cama3 = 0;
            int cama4 = 0;
            int maior = 0;



            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(1, 21);
                    Console.Write(matriz[i, j] + "\t");

                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];                        
                    }

                    if (j == 0)
                    {
                        cama1 += matriz[i, j];
                    } else if (j == 1)
                    {
                        cama2 += matriz[i, j];
                    } else if (j == 2)
                    {
                        cama3 += matriz[i, j];
                    } else if (j == 3)
                    {
                        cama4 += matriz[i, j];
                    }


                }

                Console.WriteLine();
            }

            Console.WriteLine($"Média do paciente 1: {cama1 / matriz.GetLength(0)}");
            Console.WriteLine($"Média do paciente 2: {(cama2 / matriz.GetLength(0))}");
            Console.WriteLine($"Média do paciente 3: {(cama3 / matriz.GetLength(0))}");
            Console.WriteLine($"Média do paciente 4: {(cama4 / matriz.GetLength(0))}");




            if (cama1 > cama2 && cama1 > cama3 && cama1 > cama4)
            {
                Console.WriteLine($"A maior média e do paciente 1");
            } else if (cama2 > cama1 && cama2 > cama3 && cama2 > cama4)
            {
                Console.WriteLine($"A maior média e do paciente 2");
            } else if (cama3 > cama1 && cama3 > cama2 && cama3 > cama4)
            {
                Console.WriteLine($"A maior média e do paciente 3");
            } else if (cama4 > cama1 && cama4 > cama3 && cama4 > cama2)
            {
                Console.WriteLine($"A maior média e do paciente 4");
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == maior)
                    {
                        Console.WriteLine($"O maior valor é {matriz[i, j]} na cama {j + 1} às {i + 1} horas");
                    }
                    
                }
            }
            

            Console.ReadKey();
        }
    }
}
