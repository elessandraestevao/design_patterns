using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IHIT: TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarTaxacaoMaxima(Orcamento orcamento)
        {
            return existeDoisItensIguais(orcamento);
        }

        private bool existeDoisItensIguais(Orcamento orcamento)
        {
            for (int i = 0; i < orcamento.Itens.Count; i++)
            {
                for (int j = i + 1; j < orcamento.Itens.Count; j++)
                {
                    if (orcamento.Itens[i].Nome.Equals(orcamento.Itens[j].Nome))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        protected override double TaxacaoMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double TaxacaoMinima(Orcamento orcamento)
        {
            return orcamento.Valor * (orcamento.Itens.Count * 0.01);
        }
    }
}
