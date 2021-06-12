using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAtributos
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double P = (A + B + C) / 2;
            double area = Math.Sqrt((P * (P - A) * (P - B) * (P - C)));
            return area;
        }
    }

    class Retangulo
    {
        public double A;
        public double B;

        public double Area()
        {
            return A * B;
        }

        public double Perimetro()
        {
            return 2 * A + 2 * B;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
    }
}
