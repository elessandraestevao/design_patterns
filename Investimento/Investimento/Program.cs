using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Deposita(1000);

            Investimento conservador = new Conservador();

            RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();
            realizador.Investe(conta, conservador);
            Console.WriteLine(conta.Saldo);
            Console.ReadKey();
        }
    }
}
