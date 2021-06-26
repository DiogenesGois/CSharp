using System;
using System.Collections.Generic;
using System.Text;

namespace Ficha2Ex5 {
    class Triangulo {

        static public double forma(double x, double y, double z, out double area) {
            double perimetro = x + y + z;
            area = Math.Sqrt(((x + y + z) / 2) * (((x + y + z) / 2) - x) * (((x + y + z) / 2) - y) * (((x + y + z) / 2) - z));

            return perimetro;
        }
    }
}
