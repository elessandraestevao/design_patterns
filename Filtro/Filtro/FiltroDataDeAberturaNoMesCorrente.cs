using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro
{
    public class FiltroDataDeAberturaNoMesCorrente : Filtro
    {
        public FiltroDataDeAberturaNoMesCorrente(Filtro proximoFiltro) : base(proximoFiltro) { }
        public FiltroDataDeAberturaNoMesCorrente() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {            
            IList<Conta> filtradas = new List<Conta>();
            foreach (Conta conta in contas)
            {
                if (conta.DataAbertura.Month == DateTime.Now.Month && conta.DataAbertura.Year == DateTime.Now.Year)
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
