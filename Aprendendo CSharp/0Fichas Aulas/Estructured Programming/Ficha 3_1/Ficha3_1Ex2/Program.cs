using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3_1Ex2 {
    class Program {
        static void Main(string[] args) {
            int[] numeros = new int[10];
            int contador1 = 0;
            int contador2 = 0;
            Random rand = new Random();


            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(50);
                
                if (numeros[i] >= 10 && numeros[i] <= 20)
                {
                    contador1++;
                } else
                {
                    contador2++;
                }

            }

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"Entre 10 e 20: {contador1}");
            Console.WriteLine($"Fora do intervalo: {contador2}");


            Console.ReadKey();
        }
    }
}
