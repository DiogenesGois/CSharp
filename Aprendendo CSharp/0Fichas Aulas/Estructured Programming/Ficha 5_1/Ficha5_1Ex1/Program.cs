using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5_1Ex1 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            double[,] peso = new double[2, 5];
            double[,] comprimento = new double[2, 5];
            double somaPesoMedio = 0;
            double pesoMedio = 0;
            double comprimentoMedio = 0;
            double cont = 0;
            double menorComprimento = double.MaxValue;
            double maiorComprimento = 0;


            for (int i = 0; i < peso.GetLength(0); i++)
            {
                for (int j = 0; j < peso.GetLength(1); j++)
                {
                    peso[i, j] = rand.Next(1, 21);
                    Console.Write(peso[i, j] + "  ");

                    somaPesoMedio += peso[i, j];
                    pesoMedio = somaPesoMedio / (peso.GetLength(0) + peso.GetLength(1));                 

                }

                Console.WriteLine();
            }

            for (int i = 0; i < peso.GetLength(0); i++)
            {
                for (int j = 0; j < peso.GetLength(1); j++)
                {
                    if (peso[i, j] > pesoMedio)
                    {
                        cont++;
                    }
                }
               
            }

            Console.WriteLine();

            for (int i = 0; i < comprimento.GetLength(0); i++)
            {
                for (int j = 0; j < comprimento.GetLength(1); j++)
                {
                    comprimento[i, j] = rand.Next(1, 21);
                    Console.Write(comprimento[i, j] + "  ");

                    comprimentoMedio += comprimento[i, j];

                    if (comprimento[i, j] < menorComprimento)
                    {
                        menorComprimento = comprimento[i, j];
                    }

                    if (comprimento[i, j] > maiorComprimento)
                    {
                        maiorComprimento = comprimento[i, j];
                    }

                }
                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine($"Peso médio: {pesoMedio:0.00}");
            Console.WriteLine($"Percentagem de peso superior à média: {cont * 100 / (peso.GetLength(0) + peso.GetLength(1)):0.00}%");
            Console.WriteLine($"Diferença entre o maior e menor comprimento: {maiorComprimento - menorComprimento}");

            Console.ReadKey();
        }
    }
}
