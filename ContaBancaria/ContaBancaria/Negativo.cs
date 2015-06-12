using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class Negativo : Status
    {
        public override void Saca(double valor, Conta conta)
        {
            throw new Exception("Não é possível realizar saque com saldo negativo!");
        }

        public override void Deposita(double valor, Conta conta)
        {
            conta.Saldo += valor * 0.95;
            verificaStatus(conta);
        }
    }
}
