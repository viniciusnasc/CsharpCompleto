using System;

namespace Logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual desafio deseja visualizar?");
            string estudo = Console.ReadLine();

            if (estudo == "1.1")
            {
                Produtos p1 = new Produtos(1, "Cachorro quente", 15.10);
                Produtos p2 = new Produtos(2, "Bolo de cenoura", 15.10);
                Produtos p12 = new Produtos(12, "Refrigerante de laranja", 5.30);
                Produtos p13 = new Produtos(13, "Batata frita", 15.30);
                Produtos p16 = new Produtos(16, "Suco de abacaxi", 5.10);
                Produtos p161 = new Produtos(161, "Agua mineral", 5.20);

                double valorTotal = 0;

                double[,] itens = new double[,]
                { { p1._ID, p1._preco }, {p2._ID, p2._preco },
                  { p12._ID, p12._preco }, {p13._ID, p13._preco },
                  {p16._ID, p16._preco },  {p161._ID, p161._preco } };

                Inicio:

                double item = Menu.Item();
                double quantidade = Menu.Quantidade();
                valorTotal = Menu.Calculo(itens, quantidade, item, valorTotal);
                char questionario = Menu.OutroItem();

                if (questionario == 'n' || questionario == 'N')
                {
                    Console.WriteLine("Valor total do pedido é de R$ {0}", valorTotal);
                }
                if (questionario == 's' || questionario == 'S')
                {
                    goto Inicio;
                }
                else
                {
                    throw new ArgumentException();
                }
            }

            if (estudo == "1.2")
            {
                Console.WriteLine("Digite o valor do raio: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal raio)) { }
                else
                {
                    Console.WriteLine("Valor invalido! Digite um valor numérico!");
                }

                decimal Pi = 3.14159m;

                decimal area = Pi * raio * raio;

                Console.WriteLine($"A área do circulo equivale a aproximadamente {decimal.Round(area, 4)}.");

            }

            if (estudo == "2.2")
            {
                Console.WriteLine("Insira o valor de a: ");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o valor de b: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Insira o valor de c: ");
                double c = double.Parse(Console.ReadLine());

                double resultadox1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
                double resultadox2 = (-b - Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);

                try
                {
                    if (a == 0)
                        throw new DivideByZeroException();
                    if ((b * b) - 4 * a * c < 0)
                        throw new ArithmeticException();

                    Console.WriteLine("O resultado de x1 é de : " + resultadox1);
                    Console.WriteLine("O resultado de x2 é de : " + resultadox2);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Impossível realizar operação: divisor = 0");
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine("Impossível realizar operação: não é possível realizar raiz com numero negativo");
                }
            }

            if (estudo == "3.1")
            {
            Inicio:
                Console.WriteLine("Qual a senha de acesso?");
                int senha = int.Parse(Console.ReadLine());

                switch (senha)
                {
                    case 2002:
                        Console.WriteLine("ACESSO PERMITIDO!");
                        break;

                    default:
                        Console.WriteLine("SENHA INVALIDA, ACESSO NEGADO!\n");
                        goto Inicio;
                }
            }

            if (estudo == "3.2")
            {
            Inicio:
                Console.WriteLine("Digite o número N");

                if (int.TryParse(Console.ReadLine(), out int N)) { }
                else
                {
                    Console.WriteLine("Valor invalido! Digite um numero inteiro!\n");
                    goto Inicio;
                }

                int[] num = new int[N];
                int In = 0;
                int Out = 0;
                Random rdm = new Random();

                Console.WriteLine();

                for (int i = 0; i < N; i++)
                {
                    num[i] = rdm.Next(30);

                    if (num[i] >= 10 && num[i] <= 20)
                        In++;

                    else
                        Out++;

                    Console.WriteLine(num[i]);
                }

                Console.WriteLine($"\n{In} números estão dentro do range (10-20)");
                Console.WriteLine($"{Out} estão fora do range");
            }

        }
    }
}
