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
        public int _ID { get; set; }
        public double _preco { get; set; }


        public void Pergunta()
        {
            Console.WriteLine("Digite o codigo do itém que deseja colocar no carrinho: ");
            _ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade que deseja: ");
            int quant = int.Parse(Console.ReadLine());
        }
    }
}
