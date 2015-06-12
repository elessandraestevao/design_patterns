using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public abstract class Status
    {
        public abstract void Saca(double valor, Conta conta);
        public abstract void Deposita(double valor, Conta conta);

        protected void verificaStatus(Conta conta)
        {
            if (conta.Saldo > 0)
            {
                conta.Status = new Positivo();
            }
            else
            {
                conta.Status = new Negativo();
            }
        }
    }
}
