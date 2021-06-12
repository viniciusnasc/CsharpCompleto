using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAtributos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario*((porcentagem+100)/100);
        }

        public override string ToString()
        {
            return Nome +
                   ", $" +
                   SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    class Aluno
    {
        public string Nome;
        public int Trimestre1;
        public int Trimestre2;
        public int Trimestre3;

        public int NotaFinal()
        {
            return Trimestre1 + Trimestre2 + Trimestre3;
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60)
            return "NOTA FINAL = " + NotaFinal().ToString("F2") + "\nAPROVADO"; 
            else
            return "NOTA FINAL = " + NotaFinal().ToString("F2") + "\nREPROVADO\nFALTARAM " + 
                   (60 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS"; 
        }
    }
}
