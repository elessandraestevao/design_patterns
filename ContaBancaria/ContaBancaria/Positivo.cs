using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Positivo : Status
    {
        public override void Saca(double valor, Conta conta)
        {
            conta.Saldo -= valor;
            verificaStatus(conta);
        }

        public override void Deposita(double valor, Conta conta)
        {
            conta.Saldo += valor * 0.98;
        }        
    }
}
