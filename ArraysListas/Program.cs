using System;
using System.Globalization;
using System.Collections.Generic;

namespace ArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo da aula que deseja: " +
                              "\na1 para aula 1" +
                              "\na2 para aula 2" +
                              "\nf1 para exercicio de fixação - vetores" +
                              "\na3 para aula 3" +
                              "\nf2 para exercicio de fixação - listas" +
                              "\nf3 para exercicio de fixação - matrizes" +
                              "\nf4 para exercicio de fixação - matrizes 2");
            string aula = Console.ReadLine().ToUpper();

            #region Exercicio aula 1
            if (aula == "A1")
            {
                Console.Clear();
                Console.Write("Digite a quantidade de pessoas que voce deseja calcular a media da altura: ");
                int N = int.Parse(Console.ReadLine());

                double[] altura = new double[N];
                double alturaTotal = 0;

                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Digite a {i + 1}º altura: ");
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

                    Console.Write($"Digite o nome do {i + 1}º produto: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Digite o valor do produto: ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    conj[i] = new Produto(nome, preco);

                    precoMedio += conj[i].Preco;
                }

                Console.WriteLine($"\nAVERAGE PRICE = {(precoMedio / N)}");
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
                    Console.WriteLine($"\nINQUILINO #{i + 1}: ");
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

            #region aula 3 - listas
            else if (aula == "A3")
            {
                List<string> list = new List<string>();

                //adicionar itens na lista
                list.Add("Maria");
                list.Add("Alex");
                list.Add("Bob");
                list.Add("Anair");

                //adicionar itens na lista, em uma posição determinada
                list.Insert(2, "Vinicius");

                foreach (string obj in list)
                    Console.WriteLine(obj);

                //Contar quantidade de itens na lista
                Console.WriteLine("List count: " + list.Count);

                //Encontrar um item na lista, cujo a primeira letra seja igual a A
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("First A = " + s1);

                //Encontrar o ultimo item da lista, cujo a primeira letra seja igual a A
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Last A= " + s2);

                //Encontrar a posição que o primeiro item com a primeira letra A esta na lista
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("First position 'A' = " + pos1);

                //Encontrar a posição que o ultimo item com a primeira letra A esta na lista
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Last position 'A' = " + pos2);

                //Para filtrar algo da lista, precisamos criar outra lista e colocar seus itens nela,
                //neste exemplo, colocamos todos itens que o tamanho da palavra seja igual a 5
                List<string> list2 = list.FindAll(x => x.Length == 5);
                Console.WriteLine("------------------------");
                foreach (string obj in list2)
                    Console.WriteLine(obj);

                //Remover item da lista:
                list.Remove("Alex");
                Console.WriteLine("-------------------");
                foreach (string obj in list)
                    Console.WriteLine(obj);

                //Remover todos itens da lista que comecem com a letra M
                list.RemoveAll(x => x[0] == 'M');
                Console.WriteLine("-------------------");
                foreach (string obj in list)
                    Console.WriteLine(obj);

                //Remover o item de uma determinada posição
                list.RemoveAt(0);
                Console.WriteLine("-------------------");
                foreach (string obj in list)
                    Console.WriteLine(obj);

                //Remover, a partir de uma posição /0 no caso/ a quantidade de itens da lista
                list.RemoveRange(0, 2);
                Console.WriteLine("-------------------");
                foreach (string obj in list)
                    Console.WriteLine(obj);
            }

            #endregion

            #region exercicio listas
            else if (aula == "F2")
            {
                Console.Clear();
                List<Funcionarios> funcionarios = new List<Funcionarios>();
                Console.Write("Quantos funcionarios você irá registrar? ");
                int N = int.Parse(Console.ReadLine());

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Funcionário #{i + 1}:");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Salario: ");
                    double salario = double.Parse(Console.ReadLine());

                    funcionarios.Add(new Funcionarios(id, nome, salario));
                }

                Console.Write("\nDigite a Id do funcionário que terá aumento: ");
                int re = int.Parse(Console.ReadLine());

                Funcionarios fun = funcionarios.Find(x => x.Id == re);

                if (re != null)
                {
                    Console.Write("Digite a porcentagem de aumento que terá o funcionário: ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    fun.AumentarSalario(porcentagem);
                }
                else
                    Console.WriteLine("ID não localizada!");

                Console.WriteLine("\nLista atualizada de funcionários: ");
                foreach (Funcionarios obj in funcionarios)
                    Console.WriteLine(obj);


            }
            #endregion

            #region exercicio matrizes
            else if (aula == "F3")
            {
                Console.Clear();
                Console.WriteLine("Criar uma matriz de ordem N, mostrar os numeros da diagonal e a quantidade de numeros negativos");

                Console.Write("\nDigite a quantidade de numeros em cada linha (ordem N): ");
                int N = int.Parse(Console.ReadLine());

                int[,] matriz = new int[N, N];

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine($"Digite os numeros da {i + 1}ª ordem (numeros separados por espaco): ");
                    string[] numer = Console.ReadLine().Split(" ");

                    for (int x = 0; x < N; x++)
                    {
                        matriz[i, x] = int.Parse(numer[x]);
                    }
                }

                Console.WriteLine("Main diagonal: ");
                for (int i = 0; i < N; i++)
                {
                    Console.Write(matriz[i, i] + " ");
                }

                int negativos = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int x = 0; x < N; x++)
                    {
                        if (matriz[i, x] < 0)
                            negativos++;
                    }
                }
                Console.Write("\nNegative numbers: " + negativos);
            }
            #endregion

            #region exercicio matrizes 2
            else if (aula == "F4")
            {
                Console.Clear();
                Console.WriteLine("Criar uma matriz de N linhas e M colunas, " +
                    "ler um numero dessa matriz e dizer os valores acima, abaixo, a esquerda e a direita dele.\n");

                Console.Write("Quantas linhas terão sua matriz? ");
                int N = int.Parse(Console.ReadLine());
                Console.Write("Quantas colunas terá sua matriz? ");
                int M = int.Parse(Console.ReadLine());

                int[,] matriz = new int[N, M];

                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Digite os numeros da {i + 1}ª linha - separados apenas por espaço: ");
                    string[] linha = Console.ReadLine().Split(" ");

                    for (int x = 0; x < M; x++)
                    {
                        matriz[i, x] = int.Parse(linha[x]);
                    }
                }

                Console.Write("Qual numero você deseja saber a posição e seus vizinhos? ");
                int num = int.Parse(Console.ReadLine());

                for (int i = 0; i < N; i++)
                {
                    for (int x = 0; x < M; x++)
                    {
                        if (matriz[i, x] == num)
                        {
                            Console.WriteLine($"Posição {i}, {x}:");
                            if (x - 1 >= 0)
                                Console.WriteLine($"Left: {matriz[i, x - 1]}");
                            if (x + 1 < M)
                                Console.WriteLine($"Right: {matriz[i, x + 1]}");
                            if (i - 1 >= 0)
                                Console.WriteLine($"Up: {matriz[i - 1, x]}");
                            if (i + 1 < N)
                                Console.WriteLine($"Down: {matriz[i + 1, x]}");
                        }
                    }
                }
            }
            #endregion
        }

    }


}
