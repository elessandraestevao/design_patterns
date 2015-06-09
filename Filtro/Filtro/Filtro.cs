using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtro
{
    public abstract class Filtro
    {
        public Filtro ProximoFiltro { get; set; }

        public Filtro(Filtro proximoFiltro)
        {
            this.ProximoFiltro = proximoFiltro;
        }

        public Filtro()
        {
            this.ProximoFiltro = null;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> VerificaProximoFiltro(IList<Conta> contas)
        {
            
            if (ProximoFiltro != null) return ProximoFiltro.Filtra(contas);
            return new List<Conta>();
        }
    }
}
