using System;
using System.Globalization;

namespace RecapLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual exercicio deseja visualizar?\n" +
                               "f1 para fixação 1\n" +
                               "f2 para fixação 2\n" +
                               "p1 para exercicio proposto 1\n" +
                               "p2 para exercicio proposto 2\n" +
                               "p3 para exercicio proposto 3\n" +
                               "p4 para exercicio proposto 4\n" +
                               "p5 para exercicio proposto 5\n" +
                               "p6 para exercicio proposto 6\n");
            string exercicio = Console.ReadLine();

            #region Exercicio de fixação de concatenação
            if (exercicio == "f1")
            {
                string produto1 = "Computador";
                string produto2 = "Mesa de escritório";

                byte idade = 30;
                int codigo = 5290;
                char genero = 'M';

                double preco1 = 2100.00;
                double preco2 = 650.5;
                double medida = 53.234567;

                Console.WriteLine($"Produtos:\n" +
                                  $"{produto1}, cujo preço é $ {preco1:F2}\n" +
                                  $"{produto2}, cujo preço é $ {preco2:F2}\n" +
                                  $"\n" +
                                  $"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n" +
                                  $"\n" +
                                  $"Medida com oito casas decimais: {medida:F8}\n" +
                                  $"Arredondado (três casas decimais): {medida:F3}");
                Console.WriteLine("Separador decimal invariant Culture: " + medida.ToString(CultureInfo.InvariantCulture));
            }
            #endregion

            #region Exercicio de fixação de entrada de dados
            if (exercicio == "f2" || exercicio == "F2")
            {
                //Proposto - entrar com os seguintes dados:
                //Alex Green
                //3
                //500.50
                //Green 21 1.73

                Console.WriteLine("Insira o nome completo: ");
                string nomeCompleto = Console.ReadLine();

                Console.WriteLine("Quantos quartos tem na sua sala? ");
                int quartos = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o preço de uma produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Insira o seu ultimo nome, idade e altura: ");
                string[] vetor = Console.ReadLine().Split(' ');
                string nome = vetor[0];
                int idade2 = int.Parse(vetor[1]);
                double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);


                Console.WriteLine($"\nVoce digitou:\n" +
                                  $"{nomeCompleto}\n" +
                                  $"{quartos}");
                Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture)
                                 + "\n" + nome + "\n" + idade2 + "\n"
                                 + altura.ToString("F2", CultureInfo.InvariantCulture));
            }
            #endregion

            #region Exercicio proposto 1
            if (exercicio == "p1" || exercicio == "P1")
            {
                Console.WriteLine("Calculadora de soma simples: Digite dois numeros a serem somados:\n" +
                                  "Primeiro numero: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Segundo numero: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("SOMA = " + (num1 + num2));
            }
            #endregion

            #region Exercicio proposto 2
            if ( exercicio == "p2" || exercicio == "P2")
            {
                Console.WriteLine("Calculo de área de circulo!\n" +
                                  "Informe o valor do raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double area = 3.14159 * Math.Pow(raio, 2);

                Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            }
            #endregion

            #region Exercicio proposto 3
            if(exercicio == "p3" || exercicio == "P3")
            {
                Console.WriteLine("Fazer um programa para lerquatro valores inteiros A, B, C e D. " +
                                  "A seguir, calcule e mostre a diferença do produto de A e B pelo produto " +
                                  "de C e D segundo a fórmula: DIFERENCA = (A * B -C * D)");

                Console.WriteLine("Digite o valor de A: ");
                int A = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de B: ");
                int B = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de C: ");
                int C = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor de D: ");
                int D = int.Parse(Console.ReadLine());

                Console.WriteLine("DIFERENÇA = " + ((A*B) - (C*D)));
            }
            #endregion

            #region Exercicio proposto 4
            if (exercicio == "p4" || exercicio == "P4")
            {
                Console.WriteLine("\nFazer um programa que leia o número de um funcionário, " +
                                  "seu número de horas trabalhadas, o valor que recebe por hora " +
                                  "e calcula o salário desse funcionário. " +
                                  "A seguir, mostre o número e o salário do funcionário, " +
                                  "com duas casas decimais.\n");

                Console.WriteLine("Digite o número de registro do funcionário: ");
                int registro = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual seu salário/hora? ");
                double salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Quantas horas ele(a) trabalhou nesse mês?");
                double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double salario = salarioHora * horasTrabalhadas;

                Console.WriteLine("\nNUMBER = " + registro + "\nSALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            }
            #endregion

            #region Exercicio proposto 5
            if (exercicio == "p5" || exercicio == "P5")
            {
                Console.WriteLine("Fazer um programa paraler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago");

                Pecas p1 = new Pecas(1, 15.10);
                Pecas p2 = new Pecas(2, 15.10);
                Pecas p12 = new Pecas(12, 5.30);
                Pecas p13 = new Pecas(13, 15.30);
                Pecas p16 = new Pecas(16, 5.10);
                Pecas p161 = new Pecas(161, 5.20);
                double[,] itens = new double[,]
                { { p1._Id, p1._preco }, { p2._Id, p2._preco }, 
                  { p12._Id, p12._preco }, { p13._Id, p13._preco }, 
                  { p16._Id, p16._preco }, { p161._Id, p161._preco } };
                double valorTotal = 0;

                Inicio:
                
                int item = Pedido.Item();
                int quantidade = Pedido.Quantidade();
                valorTotal = Pedido.Calculo(itens, item, quantidade, valorTotal);

                char outroItem = Pedido.OutroItem();

                if (outroItem == 's' || outroItem == 'S')
                {
                    goto Inicio;
                }
                else
                {
                    Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2",CultureInfo.InvariantCulture));
                }
            }
            #endregion

            #region Exercicio proposto 6
            if (exercicio == "p6" || exercicio == "P6")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. ");
                Console.WriteLine("Em seguida, calcule e mostre: ");
                Console.WriteLine("a) a área do triângulo retângulo que tem A por base e C por altura. ");
                Console.WriteLine("b) a área do círculo de raio C. (pi = 3.14159) ");
                Console.WriteLine("c) a área do trapézio que tem A e B por bases e C por altura.");
                Console.WriteLine("d) a área do quadrado que tem lado B.");
                Console.WriteLine("e) a área do retângulo que tem lados A e B");

                Console.Write("\nDigite o valor de A: ");
                double A = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor de B: ");
                double B = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor de C: ");
                double C = double.Parse(Console.ReadLine());

                Console.WriteLine("\nTRIANGULO RETANGULO: " + Ex6.TrianguloRetangulo(A,C).ToString("F3",CultureInfo.InvariantCulture));
                Console.WriteLine("CIRCULO: " + Ex6.Circulo(C).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("TRAPEZIO: " + Ex6.Trapezio(A,B,C).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("QUADRADO: " + Ex6.Quadrado(B).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("RETANGULO: " + Ex6.Retangulo(A, B).ToString("F3", CultureInfo.InvariantCulture));
            }
            #endregion
        }
    }
}
