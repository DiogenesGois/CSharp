using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoDado2 {
    class Program {
        static void Main(string[] args) {

            dado();

            Console.ReadKey();
        }

        static void dado() {
            Random rand = new Random();
            int[] armazem = new int[1000000];
            int[] contador = new int[6];
            
            for (int i = 0; i < 1000000; i++)
            {
                armazem[i] = rand.Next(1, 7);

                switch (armazem[i])
                {
                    case 1: 
                        contador[0]++;
                        break;
                    case 2:
                        contador[1]++;
                        break;
                    case 3:
                        contador[2]++;
                        break;
                    case 4:
                        contador[3]++;
                        break;
                    case 5:
                        contador[4]++;
                        break;
                    case 6:
                        contador[5]++;
                        break;

                }
            }

            Console.WriteLine($"Número 1: {contador[0]}");
            Console.WriteLine($"Número 2: {contador[1]}");
            Console.WriteLine($"Número 3: {contador[2]}");
            Console.WriteLine($"Número 4: {contador[3]}");
            Console.WriteLine($"Número 5: {contador[4]}");
            Console.WriteLine($"Número 6: {contador[5]}");
            
        }
    }

}
