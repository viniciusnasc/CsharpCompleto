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
                              "\nA4 para TimeSpan(sem exercicio, apenas consulta)");
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
        }
    }
}
