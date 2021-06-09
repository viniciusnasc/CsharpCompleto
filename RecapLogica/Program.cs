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
                               "p6 para exercicio proposto 6\n" +
                               "c1 para exercicio condicional 1\n" +
                               "c2 para exercicio condicional 2\n" +
                               "c3 para exercicio condicional 3\n" +
                               "c4 para exercicio condicional 4\n" +
                               "c5 para exercicio condicional 5\n" +
                               "c6 para exercicio condicional 6\n" +
                               "c7 para exercicio condicional 7\n" +
                               "c8 para exercicio condicional 8\n");
            string exercicio = Console.ReadLine().ToUpper();

            #region Exercicio de fixação de concatenação
            if (exercicio == "F1")
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
            else if (exercicio == "F2")
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
            else if (exercicio == "P1")
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
            else if (exercicio == "P2")
            {
                Console.WriteLine("Calculo de área de circulo!\n" +
                                  "Informe o valor do raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double area = 3.14159 * Math.Pow(raio, 2);

                Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            }
            #endregion

            #region Exercicio proposto 3
            else if(exercicio == "P3")
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
            else if (exercicio == "P4")
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
            else if (exercicio == "P5")
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
                    //tentar fazer while
                    goto Inicio;
                }
                else
                {
                    Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2",CultureInfo.InvariantCulture));
                }
            }
            #endregion

            #region Exercicio proposto 6
            else if (exercicio == "P6")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. ");
                Console.WriteLine("Em seguida, calcule e mostre: ");
                Console.WriteLine("a) a área do triângulo retângulo que tem A por base e C por altura. ");
                Console.WriteLine("b) a área do círculo de raio C. (pi = 3.14159) ");
                Console.WriteLine("c) a área do trapézio que tem A e B por bases e C por altura.");
                Console.WriteLine("d) a área do quadrado que tem lado B.");
                Console.WriteLine("e) a área do retângulo que tem lados A e B");

                //tentar criar um metodo com array para as tres incognitas
                double[] letras = new double[3];
                letras = Ex6.Incognitas(letras);

                Console.WriteLine("\nTRIANGULO RETANGULO: " + Ex6.TrianguloRetangulo(letras[0], letras[2]).ToString("F3",CultureInfo.InvariantCulture));
                Console.WriteLine("CIRCULO: " + Ex6.Circulo(letras[2]).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("TRAPEZIO: " + Ex6.Trapezio(letras[0], letras[1], letras[2]).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("QUADRADO: " + Ex6.Quadrado(letras[1]).ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("RETANGULO: " + Ex6.Retangulo(letras[0], letras[1]).ToString("F3", CultureInfo.InvariantCulture));
            }
            #endregion

            #region Exercicio condicional 1
            else if (exercicio == "C1")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não");

                Console.WriteLine("\nDigite o número: ");
                double num = double.Parse(Console.ReadLine());

                if (num < 0)
                    Console.WriteLine("NEGATIVO");
                else
                    Console.WriteLine("NAO NEGATIVO");
            }
            #endregion

            #region Exercicio condicional 2
            else if (exercicio == "C2")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar");

                Console.WriteLine("\nDigite um número: " );
                double numero = double.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                    Console.WriteLine("PAR");
                else
                    Console.WriteLine("IMPAR");
            }
            #endregion

            #region Exercicio condicional 3
            else if (exercicio == "C3")
            {
                Console.Clear();
                Console.WriteLine("Leia 2 valores inteiros(A e B).");
                Console.WriteLine("Após, o programa deve mostrar uma mensagem 'Sao Multiplos' ou 'Nao sao Multiplos', indicando se os valores lidos são múltiplos entre si.");
                Console.WriteLine("Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.\n");

                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 % num2 == 0 || num2 % num1 == 0)
                    Console.WriteLine("São Multiplos");
                
                else
                    Console.WriteLine("Não são multiplos");

            }
            #endregion

            #region Exercicio condicional 4
            else if (exercicio == "C4")
            {
                Console.Clear();
                Console.WriteLine("Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,");
                Console.WriteLine("sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.");

                Console.WriteLine("\nDigite o horario inicial do jogo: 'hh:mm'");
                string horar1 = Console.ReadLine();

                string[] horario1 = horar1.Split(":");

                Console.WriteLine("\nDigite o horario final do jogo: 'hh:mm'");
                string horar2 = Console.ReadLine();

                string[] horario2 = horar2.Split(":");

                int hora1 = int.Parse(horario1[0]);
                int min1 = 0;
                if (horario1.Length > 1)
                   min1 = int.Parse(horario1[1]);

                int hora2 = int.Parse(horario2[0]);
                int min2 = 0;
                if (horario2.Length > 1)
                    min2 = int.Parse(horario2[1]);

                //No exercicio é proposto que o mínimo de tempo entre jogos é de uma hora, porém vou deixar sem tempo mínimo para
                //futuras consultas

                //Outro metodo que poderia ser feito é o TimeSpan, mas optei por esse, mais complexo, para treinar matematica
                if (hora1 * 60 + min1 <= hora2 * 60 + min2)
                {
                    if (min1 <= min2)
                        Console.WriteLine("\nO jogo teve uma duração de: " + (hora2 - hora1) + ":" + (min2 - min1).ToString("D2") + ".");
                    else
                        Console.WriteLine("\nO jogo teve uma duração de: " + (hora2 - hora1 - 1) + ":" + (min2 + 60 - min1).ToString("D2") + ".");
                }
                else
                {
                    if (min1 < min2)
                        Console.WriteLine("\nO jogo teve uma duração de: " + (24 + hora2 - hora1) + ":" + (min2 - min1).ToString("D2") + ".");
                    else
                        Console.WriteLine("\nO jogo teve uma duração de: " + (24 + hora2 - hora1 -1) + ":" + (min2 + 60 - min1).ToString("D2") + ".");
                }
            }
            #endregion

            #region Exercicio condicional 5
            else if (exercicio == "C5")
            {
                Console.Clear();

                Produto p1 = new Produto(1, "cachorro-quente", 4);
                Produto p2 = new Produto(2, "x-salada", 4.5);
                Produto p3 = new Produto(3, "x-bacon", 5);
                Produto p4 = new Produto(4, "torrada simples", 2);
                Produto p5 = new Produto(5, "Refrigerante", 1.5);

                double[,] produtos = new double[,] { { p1.Id, p1.Preco }, { p2.Id, p2.Preco },
                                                     { p3.Id, p3.Preco }, { p4.Id, p4.Preco }, 
                                                     { p5.Id, p5.Preco } };
                string[] nomeProdutos = new string[] { p1.Nome, p2.Nome, p3.Nome, p4.Nome, p5.Nome };
                double precoTotal = 0;

                Console.WriteLine("Seja bem vindo ao restaurante x!");


                int codigoPedido = Produto.Menu(nomeProdutos, produtos);
                int quantidade = Produto.Quantidade(codigoPedido, nomeProdutos);
                precoTotal = Produto.PrecoTotal(precoTotal, quantidade, codigoPedido, produtos);
                char outroPedido = Produto.OutroPedido();

                while (outroPedido == 'S')
                {
                    codigoPedido = Produto.Menu(nomeProdutos, produtos);
                    quantidade = Produto.Quantidade(codigoPedido, nomeProdutos);
                    precoTotal = Produto.PrecoTotal(precoTotal, quantidade, codigoPedido, produtos);
                    outroPedido = Produto.OutroPedido();
                }

                Console.WriteLine("preco total = " + precoTotal);
            }
                #endregion
        }
    }
}
