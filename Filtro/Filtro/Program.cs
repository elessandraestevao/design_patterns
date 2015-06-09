using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro
{
    class Program
    {
        static void Main(string[] args)
        {
            Filtro filtro = new FiltroDataDeAberturaNoMesCorrente(
                new FiltroSaldoMenorDoQueCemReais(
                new FiltroSaldoMaiorDoQue500MilReais()));

            DateTime d1 = new DateTime(2009, 7, 6);
            DateTime d2 = new DateTime(2006, 2, 6);

            IList<Conta> contas = new List<Conta>();
            Conta c1 = new Conta(d1);
            c1.Deposita(90.0);
            Conta c2 = new Conta(d2);
            c2.Deposita(900000.0);
            Conta c3 = new Conta(DateTime.Now);
            c3.Deposita(400.0);

            contas.Add(c1);
            contas.Add(c2);
            contas.Add(c3);

            IList<Conta> filtradas = filtro.Filtra(contas);
            foreach (Conta conta in filtradas)
            {
                Console.WriteLine(conta.Saldo + " " + conta.DataAbertura);
            }
            Console.ReadKey();
        }
    }
}
