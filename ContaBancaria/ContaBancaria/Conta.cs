using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Conta
    {
        public Status Status { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
            this.Status = new Negativo();
        }

        public void Saca(double valor)
        {
            this.Status.Saca(valor, this);
        }

        public void Deposita(double valor)
        {
            this.Status.Deposita(valor, this);            
        }       
    }
}
