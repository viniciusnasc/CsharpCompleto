using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBanco
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        public void Saque (double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta +
                   ", Titular: " + Titular +
                   ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
