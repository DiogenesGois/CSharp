using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha2Ex3 {
    class Soma_Intervalo {

        static public int soma (int num1, int num2) {
            int soma = 0;

            for (int i = num1; i <= num2; i++)
            {
                soma += i;
            }

            return soma;
        }
    }
}
