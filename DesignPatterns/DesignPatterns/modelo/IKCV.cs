using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }

        

        protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemComValorSuperiorACemReaisNo(orcamento);
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

       private bool temItemComValorSuperiorACemReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;            
        }
    }
}
