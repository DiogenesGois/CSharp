using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int aux = 0;

            Console.WriteLine("Insira o primeiro valor");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o primeiro valor");
            num2 = int.Parse(Console.ReadLine());

            TrocaVariavel(num1, num2, aux);


            Console.ReadKey();
        }

        static void TrocaVariavel(int a, int b, int c)
        {
            c = a;
            a = b;
            b = c;
            

            Console.WriteLine($"Valores trocados: {a} e {b}");

        }
    }


}
