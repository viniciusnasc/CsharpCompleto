using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresEncapsulamento
{
    class Produto
    {
        protected string _nome; //sempre utilizar '_variavel' quando for atributo protected
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome)
        {
            _nome = nome;
        }

        public Produto(string nome, double preco, int quantidade) : this (nome) //Exemplo de utilização de dois construtores
        {
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get
            { return _nome; } 
            set 
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return _nome +
                   ", $ " +
                   Preco.ToString("F2", CultureInfo.InvariantCulture) +
                   ", " +
                   Quantidade +
                   " unidades, Total: $ " +
                   ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
