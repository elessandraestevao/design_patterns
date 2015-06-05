using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(1000.0);
            Imposto icms = new ICMS();
            Imposto iss = new ISS();
            Imposto iccc = new ICCC();

            CalculadorDeImposto calculador = new CalculadorDeImposto();
            calculador.CalculaImposto(orcamento, icms);
            calculador.CalculaImposto(orcamento, iss);
            calculador.CalculaImposto(orcamento, iccc);
            Console.WriteLine(iccc.Calcula(orcamento));

            Console.ReadKey();
        }
    }
}
