using System;

namespace Ficha3Ex._4 {
    class Program {
        static void Main(string[] args) {
            decimal montante = 0;
            decimal[] valor = new decimal[8];
            decimal resto = 0;


            Console.WriteLine("Insira o montante em cêntimos");
            montante = decimal.Parse(Console.ReadLine());


            valor[0] = montante / 2;
            resto = montante % 2;

            valor[1] = resto / 1;
            resto %= 1;

            valor[2] = resto / 0.5m;
            resto %= 0.5m;

            valor[3] = resto / 0.2m;
            resto %= 0.2m;

            valor[4] = resto / 0.1m;
            resto %= 0.1m;

            valor[5] = resto / 0.05m;
            resto %= 0.05m;

            valor[6] = resto / 0.02m;
            resto %= 0.02m;

            valor[7] = resto / 0.01m;


            if (Math.Round(valor[7]) == 2)
            {
                valor[6]++;
                valor[7] = 0;
            }

            if ((Math.Floor(valor[6]) + Math.Round(valor[7])) == 3)
            {
                valor[5] = 1;
                valor[6] = 0;
                valor[7] = 0;
            }


            Console.WriteLine("2: " + Math.Floor(valor[0]));
            Console.WriteLine("1: " + Math.Floor(valor[1]));
            Console.WriteLine("0.50: " + Math.Floor(valor[2]));
            Console.WriteLine("0.20: " + Math.Floor(valor[3]));
            Console.WriteLine("0.10: " + Math.Floor(valor[4]));
            Console.WriteLine("0.05: " + Math.Floor(valor[5]));
            Console.WriteLine("0.02: " + Math.Floor(valor[6]));
            Console.WriteLine("0.01: " + Math.Round(valor[7]));

            Console.ReadKey();
        }
    }
}
