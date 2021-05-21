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
				double quant = 0;
				int ID = 0;

				Produtos p1 = new Produtos();

				p1._nome = "Cachorro quente";
				p1._ID = 1;
				p1._preco = 15.10;

				Produtos p2 = new Produtos();

				p2._nome = "Bolo de cenoura";
				p2._ID = 2;
				p2._preco = 15.10;

				Produtos p12 = new Produtos();

				p12._nome = "Refrigerante de laranja";
				p12._ID = 12;
				p12._preco = 5.30;

				Produtos p13 = new Produtos();

				p13._nome = "Batata frita";
				p13._ID = 13;
				p13._preco = 15.30;

				Produtos p16 = new Produtos();

				p16._nome = "Suco de abacaxi";
				p16._ID = 16;
				p16._preco = 5.10;

				Produtos p161 = new Produtos();

				p161._nome = "Agua mineral";
				p161._ID = 161;
				p161._preco = 5.20;

				Produtos m1 = new Produtos();

				m1.Pergunta();

				Console.WriteLine(quant);

				

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
