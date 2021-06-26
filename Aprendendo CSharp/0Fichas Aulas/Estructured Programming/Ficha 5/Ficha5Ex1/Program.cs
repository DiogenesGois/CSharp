using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha5Ex1 {
    class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10];
            Random rand = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(1, 100);
                Console.WriteLine(vetor[i]);
            }

            Array.Reverse(vetor);

            Console.WriteLine("-----------");

            foreach (int n in vetor)
            {
                Console.WriteLine(n);
            }



            Console.ReadKey();
        }
    }
}
