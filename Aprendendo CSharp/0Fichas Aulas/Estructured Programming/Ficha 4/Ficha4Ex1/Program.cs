using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            int[] vetor = new int[7];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(1, 100);
                Console.WriteLine($"Posição {i}: {vetor[i]}");
            }



            Console.ReadKey();
        }
    }
}
