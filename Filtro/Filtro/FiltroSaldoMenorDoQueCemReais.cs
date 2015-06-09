using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro
{
    public class FiltroSaldoMenorDoQueCemReais : Filtro
    {
        public FiltroSaldoMenorDoQueCemReais(Filtro proximoFiltro) : base(proximoFiltro) { }
        public FiltroSaldoMenorDoQueCemReais() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {            
            IList<Conta> filtradas = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.Saldo < 100)
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
