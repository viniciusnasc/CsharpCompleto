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
                               "p5 para exercicio proposto 5\n");
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
            if (exercicio == "p5" || exercicio =="P5")
            {
                Console.WriteLine("Fazer um programa paraler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago");
                Console.WriteLine("\nDigite o codigo da peça que deseja comprar: ");
                    Console.WriteLine("\nDigite a quantidade: ");
                

            }
            #endregion
        }
    }
}
