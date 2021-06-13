using System;
using System.Globalization;

namespace ArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo da aula que deseja: " +
                              "\na1 para aula 1" +
                              "\na2 para aula 2" +
                              "\nf1 para exercicio de fixação - vetores");
            string aula = Console.ReadLine().ToUpper();

            #region Exercicio aula 1
            if (aula == "A1")
            {
                Console.Clear();
                Console.Write("Digite a quantidade de pessoas que voce deseja calcular a media da altura: ");
                int N = int.Parse(Console.ReadLine());

                double[] altura = new double[N];
                    double alturaTotal = 0;

                for ( int i = 0; i < N; i++)
                {
                    Console.Write($"Digite a {i+1}º altura: ");
                    altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    alturaTotal += altura[i];
                }

                Console.WriteLine("AVERAGE HEIGHT = " + ((alturaTotal / N).ToString("F2", CultureInfo.InvariantCulture)));
            }
            #endregion

            #region Exercicio aula 2
            else if (aula == "A2")
            {
                Console.Clear();
                Console.Write("Digite a quantidade de produtos que serão inseridos na array: ");
                int N = int.Parse(Console.ReadLine());

                Produto[] conj = new Produto[N];
                double precoMedio = 0;

                for (int i = 0; i < conj.Length; i++)
                {
                    
                    Console.Write($"Digite o nome do {i+1}º produto: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Digite o valor do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    conj[i] = new Produto(nome, preco);
                    
                    precoMedio += conj[i].Preco;
                }

                Console.WriteLine($"\nAVERAGE PRICE = {(precoMedio/N)}");
            }
            #endregion

            #region Exercicio de fixação - vetores
            else if (aula == "F1")
            {
                Console.Clear();
                Console.Write("Quantos quartos serão alugados? ");
                int totalQuartos = int.Parse(Console.ReadLine());

                if (totalQuartos > 10)
                {
                    Console.WriteLine("Número inválido, neste estabelecimento temos apenas 10 quartos!");
                    Console.Write("Quantos quartos serão alugados? ");
                    totalQuartos = int.Parse(Console.ReadLine());
                }

                Inquilinos[] quartos = new Inquilinos[10];

                for (int i = 0; i < totalQuartos; i++)
                {
                    Console.WriteLine($"\nINQUILINO #{i+1}: ");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("E-mail: ");
                    string email = Console.ReadLine();
                    Console.Write("Quarto: ");
                    int nQuarto = int.Parse(Console.ReadLine());

                    if (nQuarto > 9)
                    {
                        Console.Write("Quarto não existente, opções de quarto de  a 9!");
                        Console.Write("Quarto: ");
                        nQuarto = int.Parse(Console.ReadLine());
                    }

                    quartos[nQuarto] = new Inquilinos(nQuarto, nome, email);
                }

                Console.WriteLine("\nQuartos ocupados: ");

                for (int i = 0; i < quartos.Length; i++)
                {
                    if (quartos[i] != null)
                    Console.WriteLine(quartos[i]);
                }
            }
            #endregion
        }
    }
}
