using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3Ex._1 {
    class Program {
        static void Main(string[] args) {


            somaMedia();

            Console.ReadKey();
        }

        static void somaMedia() {
            int[] numero = new int[5];
            int soma = 0;
            float media = 0f;
            int contador = 0;
            

            while(contador < numero.Length)
            {
                Console.WriteLine("Insira um valor");
                numero[contador] = int.Parse(Console.ReadLine());
                                
                soma += numero[contador];

                contador++;
            }

            media = soma / contador;

            Console.WriteLine($"A soma: {soma}");
            Console.WriteLine($"A media: {media}");
        }
    }
}
