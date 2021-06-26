using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2Ex5 {
    class Program {
        static void Main(string[] args) {
            float numero1 = 0f;
            float numero2 = 0f;
            char operacao = ' ';

            Console.WriteLine("Insira o primeiro número");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a operação");
            operacao = char.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            numero2 = int.Parse(Console.ReadLine());

            if (operacao == '+')
            {
                Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");

            } else if (operacao == '-')
            {

                Console.WriteLine($"{numero1} - {numero2} = {numero1 - numero2}");

            } else if (operacao == '*')
            {

                Console.WriteLine($"{numero1} x {numero2} = {numero1 * numero2}");

            } else if (operacao == '/')
            {
                if (numero2 != 0)
                {
                    Console.WriteLine($"{numero1} / {numero2} = {numero1 / numero2}");
                } else
                {
                    Console.WriteLine("Impossível dividir por 0");
                }
            } else
            {
                Console.WriteLine("Operação inválida");
            }

            Console.ReadKey();
        }
    }
}
