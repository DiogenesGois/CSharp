using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1Ex6 {
    class Program {
        static void Main(string[] args) {

         preco();

            Console.ReadKey();
        }

        static void preco() {
            double precoFabrica = 0;
            double distribuidor = 0;
            double impostos = 0;

            Console.WriteLine("Insira o preço de fábrica");
            precoFabrica = double.Parse(Console.ReadLine());

            distribuidor = precoFabrica * 0.28;
            impostos = precoFabrica * 0.45;

            Console.WriteLine("O preço final do carro é: " + (precoFabrica + distribuidor + impostos) + "Euros");



        }


    }
}
