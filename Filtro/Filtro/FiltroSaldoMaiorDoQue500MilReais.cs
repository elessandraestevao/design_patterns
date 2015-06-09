using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro
{
    public class FiltroSaldoMaiorDoQue500MilReais : Filtro
    {
        public FiltroSaldoMaiorDoQue500MilReais(Filtro proximoFiltro) : base(proximoFiltro) { }
        public FiltroSaldoMaiorDoQue500MilReais() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {            
            IList<Conta> filtradas = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.Saldo > 500000)
                {
                    filtradas.Add(conta);
                }
            }
            foreach (Conta conta in VerificaProximoFiltro(contas))
            {
                filtradas.Add(conta);
            }
            return filtradas;
        }
    }
}
