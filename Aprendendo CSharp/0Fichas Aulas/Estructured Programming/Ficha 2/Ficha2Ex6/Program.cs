using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha2Ex6 {
    class Program {
        static void Main(string[] args) {
            float valorCompra = 0;
            int codigo = 0;
            float vip = 0;
            float funcionario = 0;

            Console.WriteLine("Indique o código de cliente: 1 - comum, 2 - VIP, 3 - Funcionário");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique o valo total da compra");
            valorCompra = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine($"O valor total da compra é: {valorCompra}");
                    break;
                case 2:
                    funcionario = valorCompra - (valorCompra * 0.1f);
                    Console.WriteLine($"O valor total da compra é: {funcionario}");                   
                    break;
                case 3:
                    vip =valorCompra - (valorCompra * 0.05f);
                    Console.WriteLine($"O valor total da compra é: {vip}");
                    break;
                default:
                    Console.WriteLine($"O valor é inválido");
                    break;
            }


            Console.ReadKey();
        }
    }
}
