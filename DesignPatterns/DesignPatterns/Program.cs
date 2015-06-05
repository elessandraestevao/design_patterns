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
            Orcamento orcamento = new Orcamento(450.0);
            orcamento.AdicionaItem(new Item("LAPIS", 100.0));
            orcamento.AdicionaItem(new Item("Item2", 200.0));
            orcamento.AdicionaItem(new Item("Item3", 300.0));
            orcamento.AdicionaItem(new Item("Item4", 400.0));
            orcamento.AdicionaItem(new Item("Item5", 500.0));
            orcamento.AdicionaItem(new Item("CANETA", 50.0));

            CalculadorDeDesconto calculador = new CalculadorDeDesconto();
            Console.WriteLine(calculador.Calcula(orcamento));
            /*Imposto icms = new ICMS();
            Imposto iss = new ISS();
            Imposto iccc = new ICCC();

            CalculadorDeImposto calculador = new CalculadorDeImposto();
            calculador.CalculaImposto(orcamento, icms);
            calculador.CalculaImposto(orcamento, iss);
            calculador.CalculaImposto(orcamento, iccc);
            Console.WriteLine(iccc.Calcula(orcamento));*/

            Console.ReadKey();
        }
    }
}
