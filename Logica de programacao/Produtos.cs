using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_programacao
{
    public class Produtos
    {
        public string _nome { get; set; }
        public double _ID { get; set; }
        public double _preco { get; set; }

        public Produtos (double _ID, string _nome, double _preco)
        {
            this._ID = _ID;
            this._nome = _nome;
            this._preco = _preco;
        }
    }

    public class Menu
    {
        public static double Item()
        {
            Console.WriteLine("Digite o codigo do itém que deseja colocar no carrinho: ");
            double _ID = double.Parse(Console.ReadLine());

            return _ID;
        }

        public static double Quantidade()
        {
            Console.WriteLine("Digite a quantidade que deseja: ");
            double quant = double.Parse(Console.ReadLine());

            return quant;
        }

        public static char OutroItem()
        {
            Console.WriteLine("Deseja incluir outro item no carrinho? (S/N)");
            char questionario = char.Parse(Console.ReadLine());

            return questionario;
        }

        public static double Calculo(double[,] itens, double quantidade, double item, double valorTotal)
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
    }
}
