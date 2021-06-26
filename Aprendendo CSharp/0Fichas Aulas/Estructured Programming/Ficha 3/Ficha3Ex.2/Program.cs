using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3Ex._2 {
    class Program {
        static void Main(string[] args) {
            
            string currency = " ";          
            
            Console.WriteLine("Indique a converção que deseja");
            currency = Console.ReadLine();

            if(currency == "euro")
            {
                conversorEuro();
            }else if(currency == "escudo")
            {
                conversorEscudo();

            } else
            {
                Console.WriteLine("Operação inválida");
            }
            



            Console.ReadKey();
        }

        static void conversorEuro() {
            float euro = 1;
            float escudo = 0;

            while (euro != 0)
            {
                Console.WriteLine("Insira o valor em euros");
                euro = int.Parse(Console.ReadLine());

                escudo = euro * 200.50f;

                Console.WriteLine($"O valor em escudo é: {escudo}");
            }
        }

        static void conversorEscudo() {
            float euro = 0;
            float escudo = 1;
            bool continuar = true;

            while (continuar == true)
            {
                Console.WriteLine("Insira o valor em escudo");
                escudo = int.Parse(Console.ReadLine());

                if (escudo != 0){
                    euro = escudo / 200.50f;

                    Console.WriteLine($"O valor em euro é: {euro}");

                } else
                {
                    continuar = false;
                }

               
            }
        }
    }
}
