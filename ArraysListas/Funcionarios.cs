using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListas
{
    class Funcionarios
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario (double porcentagem)
        {
            Salario += (Salario * (porcentagem/100));
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }
    }
}
