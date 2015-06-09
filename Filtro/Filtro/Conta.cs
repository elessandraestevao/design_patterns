using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; set; }

        public Conta(DateTime dataAbertura)
        {
            this.DataAbertura = dataAbertura;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
