using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5Ex2 {
    class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10];
            Random rand = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(1, 100);
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine($"O maior: {vetor.Max()}");
            Console.WriteLine($"O menor: {vetor.Min()}");




            Console.ReadKey();
        }
    }
}
