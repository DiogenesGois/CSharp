using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3_1Ex._1 {
    class Program {
        static void Main(string[] args) {
            long numero = 0;
            long fatorial = 1;

            Console.WriteLine("Insiraum número");
            numero = long.Parse(Console.ReadLine());

            for (long i = numero; i >= 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);

            Console.ReadKey();
        }
    }
}
