using System;
using System.Globalization;

namespace AplicacaoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Conta c1 = new Conta(numConta, nome);
            double valor = 0;

            Console.Write("Haverá depósito inicial? (s/n) ");
            char dep = char.Parse(Console.ReadLine().ToUpper());

            if (dep == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                c1.Deposito(valor);
            }

            Console.WriteLine($"\nDados da conta:\n{c1}");

            Console.Write("\nEntre um valor para deposito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(valor);
            Console.WriteLine($"Dados da conta atualizados:\n{c1}");

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(valor);
            Console.WriteLine($"Dados da conta atualizados:\n{c1}");
        }
    }
}
