using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
           
            char medida = ' ';
            int graus = 0;

            do { 
            
                Console.WriteLine("Qual a conversão que pretende fazer? f/c");
                medida = char.Parse(Console.ReadLine());

                if (medida == 'c')
                {
                    Console.WriteLine("Indique os graus em celcius");
                    graus = int.Parse(Console.ReadLine());
                    Farenheit(graus);

                }
                else if (medida == 'f')
                {
                    Console.WriteLine("Indique os graus em fahrenheit");
                    graus = int.Parse(Console.ReadLine());                    
                    Celcius(graus);
                }
                else
                {
                    Console.WriteLine("Obrigado, até a proxima");
                }


            } while (medida == 'f' || medida == 'c');
           
            Console.ReadKey();
        }

        static void Celcius(int fahrenheit)
        {
             float cel = (fahrenheit - 32) / 1.8f;

            Console.WriteLine("O grau em fahrenheit: " + cel);
        }

        static void Farenheit(int celcius)
        {
            int fahren = (celcius * 9) / 5 + 32;

            Console.WriteLine("O grau em celcius: " + fahren);
        }
    }
}
