using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentosNomeados {
    class Program {
        static void Main(string[] args) {

            int parametro1 = 0;
            string parametro2 = "";

            Console.WriteLine("Escreva algo");
            parametro2 = Console.ReadLine();

            Console.WriteLine("Insira um valor");
            parametro1 = int.Parse(Console.ReadLine());

            argumentosNomeados(par2: parametro2, par1: parametro1);


            Console.ReadKey();
        }
        static void argumentosNomeados(int par1, string par2 = "Passado pelo método") {

            string resultado = "Parâmetro obrigatório: " + par1 + " Parâmetro opcional: " + par2;

            Console.WriteLine(resultado);



        }
    }
}
