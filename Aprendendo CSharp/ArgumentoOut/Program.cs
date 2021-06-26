using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgumentoOut {
    class Program {
        static void Main(string[] args) {
            int divid = 10;
            int divis = 3;
            int rest = 0;
            int quoc = divide(divid, divis, out rest); 

            Console.WriteLine(rest);//posso usar livremente, como se a operação fosse local

            Console.WriteLine("{0}/{1} tem quociente {2} e resto {3}", divid, divis, quoc, rest);

            Console.ReadKey();
          
        }

        //OUT permite ter , mais que um retorno na função
        static int divide(int dividendo, int divisor, out int resto) {
            int quociente = 0;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }

        
    }
}
