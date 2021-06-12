using System;
using System.Globalization;

namespace ConstrutoresEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);

            Console.WriteLine($"\nDados do produto: {p1}\n");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            p1.AdicionarProdutos(quantidade);

            Console.WriteLine($"\nDados atualizados: {p1}\n");

            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            quantidade = int.Parse(Console.ReadLine());

            p1.RemoverProdutos(quantidade);

            Console.WriteLine($"\nDados atualizados: {p1}");
        }
    }
}
