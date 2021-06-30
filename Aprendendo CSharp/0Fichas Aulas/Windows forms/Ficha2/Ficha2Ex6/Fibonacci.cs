using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha2Ex6 {
    class Fibonacci {

        static public string enesimo(int num) {
            int a = 1;
            int b = 0;
            int c = 1;


            for (int i = 0; i < num; i++)
            {
                a = b;//1
                b = c;//1
                c = a + b;//1
            }

            return a.ToString();
        }
    }
}
