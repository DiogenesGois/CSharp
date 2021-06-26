using System;

namespace Ficha3_1Ex4 {
    class Program {
        static void Main(string[] args) {
            double horas = 0;
            double pagamento = 0;
            char confirma = 's';


            while (confirma == 's')
            {
                Console.WriteLine("Indique as horas que esteve estacionado");
                horas = double.Parse(Console.ReadLine());

                if (horas == 24)
                {
                    pagamento = 20;

                } else if (horas <= 3)
                {
                    pagamento = 3;

                } else
                {
                    pagamento = ((horas - 3) * 1.50) + 3;

                    if (pagamento >= 20)
                    {
                        pagamento = 20;
                    }
                }

                Console.WriteLine($"O valor a pagar é: {pagamento}");


                Console.WriteLine("Deseja continuar? s/n");
                confirma = char.Parse(Console.ReadLine());


            }

            Console.WriteLine("Até a próxima");






            Console.ReadKey();
        }
    }
}
