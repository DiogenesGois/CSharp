using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoDado
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncaoDado();

            Console.ReadKey();
        }

        static void FuncaoDado()
        {
            Random randNum = new Random();
            int cont1 = 0;
            int cont2 = 0;
            int cont3 = 0;
            int cont4 = 0;
            int cont5 = 0;
            int cont6 = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                int random = randNum.Next(1, 7);
                
                switch (random)
                {
                    case 1:
                        cont1++;
                        break;
                    case 2:
                        cont2++;
                        break;
                    case 3:
                        cont3++;
                        break;
                    case 4:
                        cont4++;
                        break;
                    case 5:
                        cont5++;
                        break;
                    case 6:
                        cont6++;
                        break;
                }
                    
            }
            Console.WriteLine($"1 --> {cont1}");
            Console.WriteLine($"2 --> {cont2}");
            Console.WriteLine($"3 --> {cont3}");
            Console.WriteLine($"4 --> {cont4}");
            Console.WriteLine($"5 --> {cont5}");
            Console.WriteLine($"6 --> {cont6}");
        }

    }
}
