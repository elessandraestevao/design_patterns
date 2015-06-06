using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public String Nome { get; private set; }

        public Conta(double saldo, String nome)
        {
            this.Saldo = saldo;
            this.Nome = nome;
        }
    }
}
