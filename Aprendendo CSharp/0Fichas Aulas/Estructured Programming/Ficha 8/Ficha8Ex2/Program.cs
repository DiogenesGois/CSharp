using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha8Ex2 {
    class Program {
        static void Main(string[] args) {
            double num1 = 0;
            double num2 = 0;
            char operacao;

            Console.WriteLine("Insiar o primeiro número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insiar o segundo número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insiar a operação (+, -, *, /)");
            operacao = char.Parse(Console.ReadLine());

            if (operacao == '+')
            {
                Console.WriteLine(soma(num1, num2));
            }else if (operacao == '-')
            {
                Console.WriteLine(subtracao(num1, num2));
            } else if (operacao == '*' || operacao == 'x')
            {
                Console.WriteLine(multiplicacao(num1, num2));
            } else if (operacao == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Impossível dividir por 0");
                } else
                {
                    Console.WriteLine(divisao(num1, num2));
                }                
            }

            Console.ReadKey();
        }

        static double soma(double x, double y) {
            double resultado = x + y;

            return resultado;
        }

        static double subtracao(double x, double y) {
            double resultado = x - y;

            return resultado;
        }

        static double multiplicacao(double x, double y) {
            double resultado = x * y;

            return resultado;
        }

        static double divisao(double x, double y) {
            double resultado = x / y;

            return resultado;
        }
    }
}
