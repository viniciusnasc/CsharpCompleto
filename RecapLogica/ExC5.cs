using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLogica
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(int id, string nome, double preco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }

        public static int Menu (string[] nomeprodutos, double[,] produtos )
        {
            Console.WriteLine("\nMENU: ");
            for (int i = 0; i < nomeprodutos.Length; i++)
            {
                Console.WriteLine(produtos[i, 0] + " - " + nomeprodutos[i]);
            }

            Console.Write("Digite o codigo do seu pedido: ");
            int codigoPedido = int.Parse(Console.ReadLine());

            return codigoPedido;
        }

        public static int Quantidade(int codigoPedido, string[] nomeProduto)
        {
            string produto = "";

            for (int i = 0; i < nomeProduto.Length; i++)
            {
                if (i == codigoPedido)
                {
                    produto = nomeProduto[i-1];
                }
            }

            Console.WriteLine($"\nQual a quantidade de {produto} que você deseja?");
            int quantidade = int.Parse(Console.ReadLine());

            return quantidade;
        }

        public static double PrecoTotal(double precoTotal, int quantidade, int codigoPedido, double[,] produtos)
        {
            double preco = 0;
            for (int i = 0; i < produtos.Length/2; i++)
            {
                if (i == codigoPedido)
                {
                    preco = produtos[i-1, 1];
                }
            }
            return precoTotal += (preco*quantidade); 
        }

        public static char OutroPedido()
        {
            Console.Write("Deseja fazer outro pedido?(S/N) ");
            char outroPedido = char.Parse(Console.ReadLine());

            return outroPedido;
        }
    }
}
