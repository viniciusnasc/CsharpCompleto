using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapLogica
{
    public class Pecas
    {
        public int _Id { get; set; }
        public double _preco { get; set; }

        public Pecas (int _Id, double _preco)
        {
            this._Id = _Id;
            this._preco = _preco;
        }
    }

    public class Pedido
    {
        public static int Item()
    {
        Console.WriteLine("\nDigite o codigo da peça que deseja comprar: ");
        int item = int.Parse(Console.ReadLine());

        return item;
    }

        public static int Quantidade()
        {
            Console.WriteLine("\nDigite a quantidade que você deseja comprar: ");
            int quantidade = int.Parse(Console.ReadLine());

            return quantidade;
        }

        public static double Calculo(double[,] itens, int item, int quantidade, double valorTotal)
        {
            for (int i = 0; i < 6; i++)
            {
                if (item == itens[i, 0])
                {
                    valorTotal += itens[i, 1] * quantidade;
                }
            }
            return valorTotal;
        }

        public static char OutroItem()
        {
            Console.WriteLine("\nDeseja adicionar outro item ao seu carrinho?(S/N) ");
            char outroItem = char.Parse(Console.ReadLine());

            return outroItem;
        }
    }
}
