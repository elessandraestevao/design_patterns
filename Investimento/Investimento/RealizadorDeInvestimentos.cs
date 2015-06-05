using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    class RealizadorDeInvestimentos
    {
        public void Investe(Conta conta, Investimento investimento)
        {
            conta.Deposita(investimento.Calcula(conta) * 0.75);
            Console.WriteLine(investimento.Calcula(conta) * 0.75);
        }
    }
}
