using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char operacao = ' ';
            int num1 = 0;
            int num2 = 0;


            Console.WriteLine("Insira a operação");
            num1 = int.Parse(Console.ReadLine());
            operacao = char.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            /*Console.WriteLine("Insira a operação");
            operacao = char.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo número");
            num2 = int.Parse(Console.ReadLine());*/

            if (operacao == '+')
            {
                Console.WriteLine(num1 + num2);
            }else if (operacao == '-')
            {
                Console.WriteLine(num1 - num2);
            }else if (operacao == '*')
            {
                Console.WriteLine(num1 * num2);
            }else if (operacao == '/')
            {
                Console.WriteLine(num1 / num2);
            }else
            {
                Console.WriteLine("Operação inválida");
            }




            Console.ReadKey();
        }
    }
}
