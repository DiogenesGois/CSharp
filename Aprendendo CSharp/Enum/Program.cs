using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Cor {Azul, Verde, Amarelo, vermelho}
    class Program
    {
        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Azul;
            Cor corFavorita2 = Cor.Verde;

            Console.WriteLine($"{(int)corFavorita} --> {corFavorita}");
            Console.WriteLine($"{(int)corFavorita2} --> {corFavorita2}");
            Console.WriteLine($"{(Cor)2}");
            Console.WriteLine($"{(Cor)3}");


            Console.ReadKey();
        }
    }
}
