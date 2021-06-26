using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha7Ex2 {
    class Program {
        static void Main(string[] args) {
            int num = 0;

            Console.WriteLine("Insira um valor");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine(fibonacci(num));

            Console.ReadKey();
        }

        static int fibonacci(int valor) {
            int a = 1;
            int b = 1;
            int c = 0;
            

            for (int i = 1; i < valor; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(c);
                
            }

            return c;

        }
    }
}
