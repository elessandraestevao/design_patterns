using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class Conta
    {
        public String Titular { get; private set; }
        public String Agencia { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(String titular, String agencia, int numero, double saldo)
        {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            this.Saldo = saldo;
        }
    }
}
