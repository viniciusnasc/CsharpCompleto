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
                               "c8 para exercicio condicional 8\n" +
                               "w1 para exercicio while 1\n" +
                               "w2 para exercicio while 2\n" +
                               "w3 para exercicio while 3\n" +
                               "r1 para exercicio for 1\n" +
                               "r2 para exercicio for 2\n" +
                               "r3 para exercicio for 3\n" +
                               "r4 para exercicio for 4\n" +
                               "r5 para exercicio for 5\n" +
                               "r6 para exercicio for 6\n" +
                               "r7 para exercicio for 7\n");

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

            #region Exercicio condicional 6
            else if (exercicio == "C6")
            {
                Console.WriteLine("Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos");
                Console.WriteLine("([0,25], (25,50], (50,75], (75,100]) este valor se encontra.");
                Console.WriteLine("Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”");

                Console.WriteLine("Digite um número");
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                int i1 = 0;
                int i2 = 25;
                int i3 = 50;
                int i4 = 75;
                int i5 = 100;

                if (num >= i1 && num <= i2)
                    Console.WriteLine($"Intervalo [{i1}, {i2}]");
                
                else if (num > i2 && num <= i3)
                    Console.WriteLine($"Intervalo [{i2}, {i3}]");

                else if (num > i3 && num <= i4)
                    Console.WriteLine($"Intervalo [{i3}, {i4}]");

                else if (num > i4 && num <= i5)
                    Console.WriteLine($"Intervalo [{i4}, {i5}]");

                else
                    Console.WriteLine("Fora de intervalo");
            }
            #endregion

            #region Exercicio condicional 7
            else if (exercicio == "C7")
            {
                Console.Clear();
                Console.WriteLine("Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano.");
                Console.WriteLine("A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).");
                Console.WriteLine("Se o ponto estiver na origem, escreva a mensagem “Origem”.");
                Console.WriteLine("Se o ponto estiver sobreum dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.");

                Console.Write("Digite o primeiro numero: ");
                double num1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Digite o segundo numero: ");
                double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (num1 == 0 && num2 == 0)
                    Console.WriteLine("\nOrigem");

                else if (num1 == 0 && num2 != 0)
                    Console.WriteLine("\nEixo Y");

                else if (num1 != 0 && num2 == 0)
                    Console.WriteLine("\nEixo X");

                else if (num1 > 0 && num2 > 0)
                    Console.WriteLine("\nQ1");

                else if (num1 > 0 && num2 < 0)
                    Console.WriteLine("\nQ4");

                else if (num1 < 0 && num2 > 0)
                    Console.WriteLine("\nQ2");
                
                else
                    Console.WriteLine("\nQ3");
            }
            #endregion

            #region Exercicio Condicional 8
            else if (exercicio =="C8")
            {
                Console.Clear();
                Console.WriteLine("Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos,");
                Console.WriteLine("pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população,");
                Console.WriteLine("sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.");
                Console.WriteLine("\nLeia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida,");
                Console.WriteLine("calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.");
                Console.WriteLine("\nLembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00,");
                Console.WriteLine("pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.");
                Console.WriteLine("No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00,");
                Console.WriteLine("o que resulta em R$ 80.36 no total. O valor deveser impresso com duas casas decimais.");

                Console.Write("\nDigite o valor do salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double imposto = 0;

                if (salario <= 2000)
                    Console.WriteLine("Isento");

                else if (salario <= 3000)
                {
                    salario -= 2000;
                    imposto = salario * 0.08;
                    Console.WriteLine($"R$ {imposto.ToString("F2")}");
                }

                else if (salario <= 4500)
                {
                    salario -= 3000;
                    imposto = salario * 0.18 + 1000 * 0.08;
                    Console.WriteLine($"R$ {imposto.ToString("F2")}");
                }

                else
                {
                    salario -= 4500;
                    imposto = salario * 0.28 + 1000 * 0.08 + 1500 * 0.18;
                    Console.WriteLine($"R$ {imposto.ToString("F2")}");
                }
            }
            #endregion

            #region Exercicio while 1
            else if (exercicio == "W1")
            {
                Console.Clear();
                Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada,");
                Console.WriteLine("escrever a mensagem 'Senha Invalida'. Quando a senha for informada corretamente deve ser impressa a mensagem 'Acesso Permitido' e o algoritmo encerrado.");
                Console.WriteLine("Considere que a senha correta é o valor 2002.\n");

                Console.Write("Digite a senha: ");
                int senha = int.Parse(Console.ReadLine());
                int i = 1;

                    while (senha != 2002)
                    {
                        Console.WriteLine("Senha invalida!\n");
                    i++;
                        Console.Write($"Digite novamente! (Tentativa de número: {i}): ");
                        senha = int.Parse(Console.ReadLine());
                    }
              
                    Console.WriteLine("Acesso perimitido!");
            }
            #endregion

            #region Exercicio while 2
            else if (exercicio == "W2")
            {
                Console.Clear();
                Console.WriteLine("Escreva um programa para ler as coordenadas (X,Y) de uma quantidadeindeterminada de pontos no sistema cartesiano.");
                Console.WriteLine("Para cada ponto escrever o quadrante a que ele pertence.");
                Console.WriteLine("O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).");

                Console.Write("Digite o valor de x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor de y: ");
                int y = int.Parse(Console.ReadLine());

                while (x != 0 && y != 0)
                {
                    if (x > 0 && y > 0)
                        Console.WriteLine("PRIMEIRO");
                    else if (x > 0 && y < 0)
                        Console.WriteLine("QUARTO");
                    else if (x < 0 && y > 0)
                        Console.WriteLine("SEGUNDO");
                    else
                        Console.WriteLine("TERCEIRO");

                    Console.Write("\nDigite o valor de x: ");
                    x = int.Parse(Console.ReadLine());

                    Console.Write("Digite o valor de y: ");
                    y = int.Parse(Console.ReadLine());
                }
            }
            #endregion

            #region Exercicio while 3
            else if (exercicio == "W3")
            {
                Console.Clear();
                Console.WriteLine("Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes.");
                Console.WriteLine("Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma:");
                Console.WriteLine("1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4)");
                Console.WriteLine("deve ser solicitado um novo código (até que seja válido).");
                Console.WriteLine("O programa será encerrado quando o código informado for o número 4.Deve ser escrito a mensagem:");
                Console.WriteLine("'MUITO OBRIGADO' e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.\n");

                //Alcool = 1
                //Gasolina = 2
                //Diesel = 3

                int alcool = 0;
                int gasolina = 0;
                int diesel = 0;

                Console.Write("Digite o código do combustivel que deseja - 1 para alcool, 2 para gasolina, 3 para diesel, 4 para sair: ");
                int opcao = int.Parse(Console.ReadLine());

                while (opcao != 4)
                {
                    if (opcao == 1)
                        alcool++;
                    else if (opcao == 2)
                        gasolina++;
                    else if (opcao == 3)
                        diesel++;
                    else
                        Console.WriteLine("Codigo inválido");

                    Console.Write("\nDigite o código do combustivel que deseja - 1 para alcool, 2 para gasolina, 3 para diesel, 4 para sair ");
                    opcao = int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"\nMUITO OBRIGADO!\n" +
                                  $"Alcool = {alcool}\n" +
                                  $"Gasolina = {gasolina}\n" +
                                  $"Diesel = {diesel}");
            }
            #endregion

            #region Exercicio for 1
            else if (exercicio == "R1")
            {
                Console.Clear();
                Console.WriteLine("Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X,");
                Console.WriteLine("um valor por linha, inclusive o X, se for o caso.\n");

                Console.Write("Digite um número entre 1 e 1000! ");
                int num = int.Parse(Console.ReadLine());

                while (num < 1 || num > 1000)
                {
                    Console.Write("Número invalido! Digite um número entre 1 e 1000! ");
                    num = int.Parse(Console.ReadLine());
                }

                for (int i = 1; i <= num; i = i + 2)
                {
                        Console.WriteLine(i);
                }
            }
            #endregion

            #region Exercicio for 2
            else if (exercicio == "R2")
            {
                Console.Clear();
                Console.WriteLine("Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.");
                Console.WriteLine("Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantosestão fora do intervalo,");
                Console.WriteLine("mostrando essas informações conforme exemplo (use a palavra 'in' para dentro do intervalo, e 'out' para fora do intervalo),");

                Console.Write("Quantos numeros voce irá digitar? ");
                int N = int.Parse(Console.ReadLine());
                int In = 0;
                int Out = 0;

                for (int i = 1; i <= N; i++)
                {
                    Console.Write($"{i}º número: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num >= 10 && num <= 20)
                        In++;
                    else
                        Out++;
                }

                Console.WriteLine($"\n{In} in\n{Out} out");
            }
            #endregion

            #region Exercicio for 3
            else if (exercicio == "R3")
            {
                Console.Clear();
                Console.WriteLine("Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir.");
                Console.WriteLine("Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.");
                Console.WriteLine("Apresente a média ponderada para cada um destes conjuntos de 3 valores,");
                Console.WriteLine("sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.\n");

                Console.WriteLine("Quantos casos você irá colocar?");
                int numCasos = int.Parse(Console.ReadLine());
                double valor1 = 0;
                double valor2 = 0;
                double valor3 = 0;
                double[] media = new double[numCasos];

                for(int i = 1; i <= numCasos; i++)
                {
                    Console.WriteLine($"\n{i}º Caso: ");
                    Console.Write("\nDigite o valor do primeiro teste: ");
                    valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite o valor do segundo teste: ");
                    valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Digite o valor do terceiro teste: ");
                    valor3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    media[i - 1] = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;
                }

                Console.WriteLine("\n");

                for (int i = 0; i < media.Length; i++)
                {
                    Console.WriteLine($"Média do primeiro caso = {media[i].ToString("F1")}");
                }
            }
            #endregion

            #region Exercicio for 4
            else if (exercicio == "R4")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo.");
                Console.WriteLine("Se o denominador for igual a zero, mostrar a mensagem 'divisao impossivel'.");

                Console.Write("\nQuantas divisões você irá fazer? ");
                int quant = int.Parse(Console.ReadLine());
                string[] numeros = new string[quant];
                
                for (int i = 1; i <= quant; i++)
                {
                    Console.WriteLine("\nCaso " + i + ": \n");
                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    if (num2 == 0)
                        numeros[i - 1] = "divisão impossivel";
                    else
                        numeros[i - 1] = (num1 / num2).ToString("F1");
                }

                Console.WriteLine("\n");

                for ( int i = 0; i < numeros.Length; i++)
                Console.WriteLine($"Resultado {i+1} = {numeros[i]}");
            }
            #endregion

            #region Exercicio for 5
            else if ( exercicio == "R5")
            {
                Console.Clear();
                Console.WriteLine("Ler um valor N. Calcular e escrever seu respectivo fatorial.");
                Console.WriteLine("Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.Lembrando que, por definição, fatorial de 0 é 1");

                Console.Write("\nDigite um número para ver seu fatorial: ");
                int N = int.Parse(Console.ReadLine());
                int fatorial = 1;

                if ( N != 0)
                for (int i = 1; i <= N; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"Fatorial de {N} = {fatorial}");
            }
            #endregion

            #region Exercicio for 6
            else if (exercicio == "R6")
            {
                Console.Clear();
                Console.WriteLine("Ler um número inteiro N e calcular todos os seus divisores.\n");

                Console.Write("Digite um número para ver seus divisores: ");
                int num = int.Parse(Console.ReadLine());

                for(int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            #endregion

            #region Exercicio for 7
            else if (exercicio == "R7")
            {
                Console.Clear();
                Console.WriteLine("Fazer um programa para ler um número inteiro positivo N.");
                Console.WriteLine("O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha,");
                Console.WriteLine("mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.\n");

                Console.Write("Digite um número: ");
                int N = int.Parse(Console.ReadLine());

                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"\nNúmero {i}: ");
                    Console.WriteLine($"Número: {i}, ao quadrado: {Math.Pow(i, 2)}, ao cubo: {Math.Pow(i, 3)}");
                }
            }
            #endregion
        }
    }
}
