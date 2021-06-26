using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1Ex4 {
    class Program {
        static void Main(string[] args) {


            Dias();

            Console.ReadKey();
        }

        static void Dias() {

            int dias = 0;
            int meses = 0;
            int anos = 0;

            Console.WriteLine("Insira o numero de anos");
            anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de meses");
            meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o numero de dias");
            dias = int.Parse(Console.ReadLine());

            anos *= 365;
            meses *= 30;

            Console.WriteLine("Está vivo há " + (anos + meses + dias) + " dias");
        }
    }
}
