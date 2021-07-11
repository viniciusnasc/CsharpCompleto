using System;
using System.Globalization;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo da aula que deseja: " +
                              "\nA1 para Expressão condicional ternaria" +
                              "\nA2 para funções para string(sem exercicio, apenas consulta)" +
                              "\nA3 para DateTime(sem exercicio, apenas consulta)" +
                              "\nA4 para TimeSpan(sem exercicio, apenas consulta)" +
                              "\nA5 para Propriedades e operacoes DateTime(sem exercicio, apenas consulta)");
            string aula = Console.ReadLine().ToUpper();

            #region Expressão condicional ternaria
            if (aula == "A1")
            {
                Console.Clear();
                //Exemplo de como utilizar a expressão condicional ternaria
                double preco = double.Parse(Console.ReadLine());
                double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
                Console.WriteLine(desconto);
            }
            #endregion

            #region Funções string
            else if (aula == "A2")
            {
                string original = "abcde FGHIJ ABC abc DEFG    ";

                string si = original.ToUpper(); // Transforma tudo em letras maiusculas
                string s2 = original.ToLower(); // Transforma tudo em letras minusculas
                string s3 = original.Trim(); // Retira os espaços em branco do fim e do começo
                int n1 = original.IndexOf("bc"); // Retorna a primeira posição que se encontra o conteudo do parenteses, no caso, 1
                int n2 = original.LastIndexOf("bc"); // Retorna a última posição que se encontra o conteudo do parenteses, no caso, 17
                string s4 = original.Substring(3); // Corta a string, a partir do indice em parenteses, no caso, a partir da letra d
                string s5 = original.Substring(3, 5); // O numero apos o indice corresponde a quantidade de characteres que você quer trazer, no caso, "de FG"
                string s6 = original.Replace('a', 'x'); // Substitui o primeiro conteudo pelo segundo
                string s7 = original.Replace("abc", "xy"); // Replace também funciona com strings
                bool b1 = string.IsNullOrEmpty(original); // Teste para saber se a variavel é nula ou vazia
                bool b2 = string.IsNullOrWhiteSpace(original); // Teste para saber se a variavel é nula ou espaço em branco
            }
            #endregion

            #region Datetime
            else if (aula == "A3")
            {
                DateTime d1 = DateTime.Now; // Traz a data e hora atual no formato: dd/mm/aaaa hh:mm:ss
                Console.WriteLine(d1.Ticks); ; // Tick é o codigo da data, cada tick equivale a 100 nanosegundos e é esse o real
                                               // valor dentro de um DateTime

                DateTime d2 = new DateTime(2018, 11, 25); // Vai trazer 25/11/2018 00:00:00
                DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3); // Vai trazer 25/11/2018 20:45:03
                DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500); // Vai trazer mesma coisa de cima, porem os 500 milisegundos
                                                                          // continuam armazenados na variável
                DateTime d5 = DateTime.Today; // Traz o dia atual, com contador de horas zerado
                DateTime d6 = DateTime.UtcNow; // Horario no meridiano de Greenwich

                // Utilizando parse

                DateTime d7 = DateTime.Parse("2000-08-15");
                DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
                DateTime d9 = DateTime.Parse("15/08/2000");
                DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

                DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            }
            #endregion

            #region TimeSpan
            else if(aula == "A4")
            {
                // Enquanto DateTime se refere a um instante, TimeSpan se refere a uma duração
                TimeSpan t1 = new TimeSpan(0, 1, 30); // Retorna 00:01:30
                TimeSpan t2 = new TimeSpan(); // Retorna 00:00:00
                TimeSpan t3 = new TimeSpan(900000000L);// Retorna 00:01:30, utilizando ticks em formato long como parametro
                TimeSpan t4 = new TimeSpan(1, 2, 11, 21);// Retorna 1.02:11:21, sendo 1 a quantidade de dias
                TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);// Retorna 1.02:11:21:3210000, sendo 3210000, milisegundos

                TimeSpan t6 = TimeSpan.FromDays(1.5); //O from retorna o valor em parametro como dia, hora, minutos, segundos ou milisegundos
            }
            #endregion

            #region Propriedades e operacoes com DateTime
            else if ( aula == "A5")
            {
                DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
                Console.WriteLine("1) Date: " + d1.Date); // Traz apenas a data, o horario fica zerado - DateTime
                Console.WriteLine("2) Day: " + d1.Day); // Vai trazer apenas o dia, em formato int
                Console.WriteLine("3) DayOfWeek: " + d1.DayOfWeek); // Traz o dia da semana "Wednesday" - DayOfWeek
                Console.WriteLine("4) DayOfYear: " + d1.DayOfYear);// Traz o dia do ano, 227 formato int
                Console.WriteLine("5) Hour: " +d1.Hour); //Traz a hora, int
                Console.WriteLine("6) Kind: " + d1.Kind); // Traz se é local ou universal - padrão: local - DateTime
                Console.WriteLine("7) Milisecond: " + d1.Millisecond); // Int
                Console.WriteLine("8) Minute: " + d1.Minute); // Int
                Console.WriteLine("9) Month: " + d1.Month); // Int
                Console.WriteLine("10) Seconds: " + d1.Second); // Int
                Console.WriteLine("11) Ticks: " + d1.Ticks); // Long
                Console.WriteLine("12) TimeOfDay: " + d1.TimeOfDay); //Apenas o horario - TimeSpan
                Console.WriteLine("13) Year: " + d1.Year); // Int

                // Formatação
                DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

                Console.WriteLine(d2.ToLongDateString()); // quarta-feira, 15 de agosto de 2001
                Console.WriteLine(d2.ToLongTimeString()); // 13:45:58
                Console.WriteLine(d2.ToShortDateString()); // 15/08/2001
                Console.WriteLine(d2.ToShortTimeString()); // 13:45
                Console.WriteLine(d2.ToString()); // 15/08/2001 13:45:58
                Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss")); // 2001-08-15 13:45:58
                Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss.fff")); // 2001-08-15 13:45:58.000

                // Operações
                DateTime d3 = new DateTime(2001, 8, 15, 13, 45, 58);

                d3 = d3.AddDays(7);
                d3 = d3.AddHours(2);
                d3 = d3.AddMilliseconds(24);
                d3 = d3.AddMinutes(3);
                d3 = d3.AddMonths(13);
                d3 = d3.AddSeconds(324);
                d3 = d3.AddTicks(2444);
                d3 = d3.AddYears(3);

                TimeSpan t1 = d3.Subtract(d2); 
                d3 = d3.Subtract(t1);
                d3 = d3.Add(t1);
            }
            #endregion

            #region Propriedades e operacoes com TimeSpan
            else if (aula == "A6")
            {
                TimeSpan t1 = TimeSpan.MaxValue; // Valor máximo possivel de um TimeSpan
                TimeSpan t2 = TimeSpan.MinValue; // Valor mínimo - pode ter valor negativo
                TimeSpan t3 = TimeSpan.Zero; // Valor zerado

                TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

                int dias = t4.Days; // 2
                int horas = t4.Hours; // 3
                int minutos = t4.Minutes; // 5
                int segundos = t4.Seconds; // 7
                int milisegundos = t4.Milliseconds; // 011
                long ticks = t4.Ticks;

                double totalDias = t4.TotalDays; // Vai trazer numero quebrado, totalizando o total de dias junto as horas, min, sec, milisec
                double totalHoras = t4.TotalHours;
                double totalMinutos = t4.TotalMinutes;
                double totalSegundos = t4.TotalSeconds;
                double totalMilisegundos = t4.TotalMilliseconds;

                // Operacoes

                TimeSpan t5 = new TimeSpan(1, 30, 10);
                TimeSpan t6 = new TimeSpan(0, 10, 5);

                TimeSpan soma = t5.Add(t6);
                TimeSpan subtracao = t5.Subtract(t6);
                TimeSpan multiplicacao = t5.Multiply(2);
                TimeSpan divisao = t5.Divide(2);

            }
            #endregion
        }
    }
}
