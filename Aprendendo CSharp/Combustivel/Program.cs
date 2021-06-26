using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            const float KMLitro = 20f;
            float preco = 5.0f;
            float dinheiro = 0f;
            float KM = 0;
            float litros = 0f;

            Console.WriteLine("Quanto dinheiro tem?");
            dinheiro = float.Parse(Console.ReadLine());

            litros = dinheiro / preco;
            KM = litros * KMLitro;

            Console.WriteLine($"Com {dinheiro} euros pode abastecer com {litros} litros e andará {KM}Km.");





            Console.ReadKey();

        }
    }
}
