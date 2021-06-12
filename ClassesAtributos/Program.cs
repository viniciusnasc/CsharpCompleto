using System;
using System.Globalization;

namespace ClassesAtributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite para ver o exercicio: " +
                                                          "\na1 para aula 1;" +
                                                          "\nc1 para exercicio 1;" +
                                                          "\nc2 para exercicio 2;" +
                                                          "\na2 para aula 2" +
                                                          "\nf1 para exercicio de fixação 1" +
                                                          "\nf2 para exercicio de fixação 2" +
                                                          "\nf3 para exercicio de fixação 3" +
                                                          "\na3 para aula 3");
            string aula = Console.ReadLine().ToUpper();

            #region Aula 1
            if (aula == "A")
            {
                Triangulo X = new Triangulo();
                Triangulo Y = new Triangulo();

                Console.WriteLine("Digite os lados do triangulo X: ");
                X.A = double.Parse(Console.ReadLine());
                X.B = double.Parse(Console.ReadLine());
                X.C = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite os lados do triangulo Y: ");
                Y.A = double.Parse(Console.ReadLine());
                Y.B = double.Parse(Console.ReadLine());
                Y.C = double.Parse(Console.ReadLine());

                double area1 = X.Area();

                Console.WriteLine($"Area do primeiro triangulo = {area1}");

                double area2 = Y.Area();

                Console.WriteLine($"Area do primeiro triangulo = {area2}");

                if (area1 > area2)
                    Console.WriteLine($"Maior área: Triangulo X");
                else
                    Console.WriteLine("Maior área: Triangulo Y");
            }
            #endregion

            #region exercicio 1
            else if (aula == "C1")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler os dados de duas pessoas,");
                Console.WriteLine("depois mostrar o nome da pessoa mais velha.\n");

                Pessoa p1 = new Pessoa();
                Pessoa p2 = new Pessoa();

                Console.Write("Digite o nome da primeira pessoa: ");
                p1.Nome = Console.ReadLine();
                Console.Write("Agora digite sua idade: ");
                p1.Idade = int.Parse(Console.ReadLine());

                Console.Write("\nDigite o nome da segunda pessoa: ");
                p2.Nome = Console.ReadLine();
                Console.Write("Agora digite sua idade: ");
                p2.Idade = int.Parse(Console.ReadLine());

                if (p1.Idade > p2.Idade)
                    Console.WriteLine($"\nPessoa mais velha: {p1.Nome}");
                else
                    Console.WriteLine($"\nPessoa mais velha: {p2.Nome}");
            }
            #endregion

            #region exercicio 2
            else if (aula == "C2")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler nome e salário de dois funcionários.");
                Console.WriteLine("Depois, mostrar o salário médio dos funcionários.\n");

                Pessoa p1 = new Pessoa();
                Pessoa p2 = new Pessoa();

                Console.Write("Digite o nome do primeiro funcionario: ");
                p1.Nome = Console.ReadLine();
                Console.Write("Agora digite seu salário: ");
                p1.Salario = double.Parse(Console.ReadLine());

                Console.Write("\nDigite o nome do segundo funcionario: ");
                p2.Nome = Console.ReadLine();
                Console.Write("Agora digite seu salário: ");
                p2.Salario = double.Parse(Console.ReadLine());

                double media = (p1.Salario + p2.Salario) / 2;

                Console.WriteLine($"\nSalário médio = {media}");
            }
            #endregion

            #region Aula2
            else if(aula =="A2")
            {
                Console.Clear();

                Produto p1 = new Produto();

                Console.WriteLine("Entre os dados do produto: ");
                Console.Write("Nome: ");
                p1.Nome = Console.ReadLine();
                Console.Write("Preço: ");
                p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade no estoque: ");
                p1.Quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nDados do produto: {p1}\n");

                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                int quantidade = int.Parse(Console.ReadLine());

                p1.AdicionarProdutos(quantidade);

                Console.WriteLine($"\nDados atualizados: {p1}\n");

                Console.Write("Digite o número de produtos a ser removidos do estoque: ");
                quantidade = int.Parse(Console.ReadLine());

                p1.RemoverProdutos(quantidade);

                Console.WriteLine($"\nDados atualizados: {p1}");
            }
            #endregion

            #region Exercicio de fixação 1
            else if(aula == "F1")
            {
                Console.Clear();

                Retangulo r1 = new Retangulo();
                Console.WriteLine("Digite os lados do retangulo:");
                r1.A = double.Parse(Console.ReadLine());
                r1.B = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nAREA: {r1.Area().ToString("F2", CultureInfo.InvariantCulture)}" +
                                  $"\nPERIMETRO: {r1.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}" +
                                  $"\nDIAGONAL: {r1.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            #endregion

            #region Exercicio de fixação 2
            else if (aula == "F2")
            {
                Console.Clear();

                Pessoa p1 = new Pessoa();

                Console.Write("Nome do funcionário: ");
                p1.Nome = Console.ReadLine();
                Console.Write("Salario bruto: ");
                p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Imposto: ");
                p1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"\nFuncionário: {p1}");

                Console.Write($"\nDigite a porcentagem para aumentar o salário: ");
                double porcentagem = double.Parse(Console.ReadLine());
                p1.AumentarSalario(porcentagem);

                Console.WriteLine($"\nFuncionário: {p1}");
            }
            #endregion

            #region Exercicio de fixação 3
            else if (aula == "F3")
            {
                Console.Clear();

                Aluno a1 = new Aluno();
                Console.Write("Nome do aluno: ");
                a1.Nome = Console.ReadLine();

                Console.Write("Nota do primeiro trimestre: ");
                a1.Trimestre1 = int.Parse(Console.ReadLine());

                Console.Write("Nota do segundo trimestre: ");
                a1.Trimestre2 = int.Parse(Console.ReadLine());

                Console.Write("Nota do terceiro trimestre: ");
                a1.Trimestre3 = int.Parse(Console.ReadLine());

                Console.WriteLine("\n" + a1);
            }
            #endregion

            #region Aula 3
            else if (aula == "A3")
            {
                Console.Clear();

                Console.Write("Entre o valor do raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double circ = Calculadora.Circunferencia(raio);
                double volume = Calculadora.Volume(raio);

                Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
            }
            #endregion

            #region Exercicio de fixação membros estaticos
            else if (aula == "F4")
            {
                Console.Write("Qual a cotação do dolar? ");
                double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantos dolares voce vai comprar? ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("\nValor a ser pago em reais = " + 
                                  ConversorDeMoeda.DolaresReais(valor, cotacao).ToString("F2", CultureInfo.InvariantCulture));
            }
            #endregion
        }
    }
}
