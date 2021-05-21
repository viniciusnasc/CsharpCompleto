using System;

namespace ClassesAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os lados do primeiro triangulo: ");
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os lados do segundo triangulo: ");
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double b3 = double.Parse(Console.ReadLine());

            double p1 = (a1 + a2 + a3) / 2;
            double area1 = Math.Round(Math.Sqrt(p1*(p1-a2)*(p1-a2)*(p1-a3)));

            Console.WriteLine($"Area do primeiro triangulo = {area1}");

            double p2 = (b1 + b2 + b3) / 2;
            double area2 = Math.Round(Math.Sqrt(p2 * (p2 - a2) * (p2 - a2) * (p2 - a3)));

            Console.WriteLine($"Area do primeiro triangulo = {area2}");

            if (area1 > area2)
                Console.WriteLine($"Maior área: Triangulo 1");
            else
                Console.WriteLine("Maior área: Triangulo 2");
        }
    }
}
