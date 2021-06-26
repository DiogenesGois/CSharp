using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1Ex._3 {
    class Program {
        static void Main(string[] args) {

            Area();

            Console.ReadKey();
        }
        static void Area() {
            int baseR = 0;
            int lado = 0;

            Console.WriteLine("Insira a base do retangulo");
            baseR = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o lado do retangulo");
            lado = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do retangulo é: " + lado * baseR);

        }

    }
}
