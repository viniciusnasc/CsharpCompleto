using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAtributos
{
    class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double raio)
        {
            return Pi * Math.Pow(raio, 2);
        }
        public static double Volume(double raio)
        {
            return 4 / 3 * Pi * Math.Pow(raio, 3);
        }
    }

    class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        public static double DolaresReais(double valor, double cotacao)
        {
            return valor * cotacao + (valor * cotacao * Iof);
        }
    }
}
