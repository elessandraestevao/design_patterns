using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }
        public TemplateDeImpostoCondicional() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarTaxacaoMaxima(orcamento))
            {
                return TaxacaoMaxima(orcamento) +CalculoDoOutroImposto(orcamento);
            }
            return TaxacaoMinima(orcamento) + CalculoDoOutroImposto(orcamento);
        }                    

        protected abstract bool DeveUsarTaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMaxima(Orcamento orcamento);
        protected abstract double TaxacaoMinima(Orcamento orcamento);
        
    }
}
