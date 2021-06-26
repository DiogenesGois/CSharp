using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            int x = 0;
            int y = 0;
            int z = 0;
            double area;
            double res;

            Console.WriteLine("Insira um lado");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro lado");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira outro lado");
            z = int.Parse(Console.ReadLine());

            res = triangulo(x, y, z, out area);

            Console.WriteLine($"Perímetro: {res} e Área: {area}");

            Console.ReadKey();
        }


        static double triangulo(int x, int y, int z, out double area) {
            int perimetro = x + y + z;
            area = Math.Sqrt(((x + y + z) / 2) * (((x + y + z) / 2) - x) * (((x + y + z) / 2) - y) * (((x + y + z) / 2) - z));

            if (x == y && y == z)
            {
                Console.WriteLine("Equilátero");
            } else if ((x == y && y != z) || (x == z && z != y) || (y == z && z != x))
            {
                Console.WriteLine("Isósceles");
            } else if (x != y && x != z && y != z)
            {
                Console.WriteLine("Escaleno");
            } else
            {
                Console.WriteLine("Os lados não formam um triângulo");
            }

            return perimetro;
        }

    }
}
