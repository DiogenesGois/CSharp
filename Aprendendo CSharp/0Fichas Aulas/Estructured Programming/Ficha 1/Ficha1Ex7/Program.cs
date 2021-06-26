using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1Ex7 {
    class Program {
        static void Main(string[] args) {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;

            Console.WriteLine("Insira a primeira nota");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a terceira nota");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("média final: " + Media(nota1, nota2, nota3));
            Console.ReadKey();

        }

        static double Media(double x, double y, double z) {
            double peso1 = x * 0.2;
            double peso2 = y * 0.3;
            double peso3 = z * 0.5;
            double media = peso1 + peso2 + peso3;

            return media;

        }
    }
}
