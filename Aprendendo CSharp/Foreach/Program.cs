using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "João", "Manuel", "Maria", "José", "António", "Marta" };

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }

    }
}
