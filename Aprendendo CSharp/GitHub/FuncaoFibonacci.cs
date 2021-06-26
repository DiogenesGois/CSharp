using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoFibonacci {
    class Program {
        static void Main(string[] args) {

            menu();

            Console.ReadKey();
        }

        static void fibonacci(int x) {
            int anterior = 1;
            int seguinte = 1;
            int atual = 0;

            while (x > 0)
            {
                anterior = seguinte;
                seguinte = atual;
                atual = anterior + seguinte;

                x--;
            }


            Console.WriteLine(atual);

        }

        static void menu() {
            int x = 0;

            Console.WriteLine("Insira o valo de x");
            x = int.Parse(Console.ReadLine());

            fibonacci(x);

        }
    }
}
