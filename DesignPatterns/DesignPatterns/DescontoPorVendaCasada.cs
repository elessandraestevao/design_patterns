using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }            

        public double Desconta(Orcamento orcamento)
        {
           if(existeVendacasada(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return Proximo.Desconta(orcamento);
        }

        private bool existeVendacasada(Orcamento orcamento)
        {
            if (encontraItem("LAPIS", orcamento) && encontraItem("CANETA", orcamento))
            {
                return true;
            }
            return false;
        }

        private bool encontraItem(String nomeDoItem, Orcamento orcamento){
            foreach (Item i in orcamento.Itens)
            {
                if (nomeDoItem.Equals(i.Nome))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
