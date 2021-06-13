using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListas
{
    class Inquilinos
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; private set; }

        public Inquilinos (int quarto, string nome, string email)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ": " + Nome + ", " + Email;
        }
    }
}
