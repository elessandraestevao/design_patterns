using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    public class Arrojado : Investimento
    {
        public double Calcula(Conta conta)
        {
            int auxiliar = new Random().Next(10);
            if (auxiliar <= 1)
            {
                return conta.Saldo * 0.05;
            }
            else if (auxiliar <= 4)
            {
                return conta.Saldo * 0.03;
            }
            else
            {
                return conta.Saldo * 0.006;
            }
        }
    }
}
