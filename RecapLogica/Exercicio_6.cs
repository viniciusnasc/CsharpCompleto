using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLogica
{
    public class Ex6
    {
        public static double TrianguloRetangulo(double A, double C)
        {
            double area = A * C / 2;
            return area;
        }

        public static double Circulo(double C)
        {
            double area = Math.PI * C * C;
            return area;
        }

        public static double Trapezio(double A, double B, double C)
        {
            double area = ((A+B)*C)/2;
            return area;
        }

        public static double Quadrado(double B)
        {
            double area = B*B;
            return area;
        }

        public static double Retangulo(double A, double B)
        {
            double area = A * B;
            return area;
        }

    }
}
