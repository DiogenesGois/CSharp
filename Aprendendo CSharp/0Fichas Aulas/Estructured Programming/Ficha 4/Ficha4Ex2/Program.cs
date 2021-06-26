using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4Ex2 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[] numeros = new int[20]; 

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(1, 1000); 
                Console.WriteLine($"Posição: {i + 1}: {numeros[i]}");
            }
           
            Console.WriteLine("\n----------------\n");

            for (int i = numeros.Length; i > 0; i--)
            {
                Console.WriteLine($"Posição: {i}: {numeros[i-1]}");
            }

            Console.ReadKey();
        }
    }
}
