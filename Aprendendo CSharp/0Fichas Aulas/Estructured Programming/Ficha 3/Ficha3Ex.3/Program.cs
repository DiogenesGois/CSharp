using System;

namespace Ficha3Ex._3 {
    class Program {
        static void Main(string[] args) {

            maiorMenor();

            Console.ReadKey();
        }

        static void maiorMenor() {
            int numero = 1;
            int maior = 0;
            int menor = 100000;

            while (numero != 0)
            {
                Console.WriteLine("Insira um número");
                numero = int.Parse(Console.ReadLine());
                
                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor && numero != 0)
                {
                    menor = numero;
                }

            }

            Console.WriteLine($"O maior: {maior}");
            Console.WriteLine($"O menor: {menor}");

        }
    }
}
