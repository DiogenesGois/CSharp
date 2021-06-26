using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Insira um valor");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(Antecessor(numero));

            Console.ReadKey();
        }

        static int Antecessor(int x)
        {
            return --x;
        }
    }
}
