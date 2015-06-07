using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public abstract class TemplateRelatorio : Relatorio
    {
        public void Cabecalho(Banco banco)
        {
            Console.WriteLine("------------------CABEÇALHO--------------------");
            if (DeveUsarCabecalhoComplexo(banco))
            {
                CabecalhoComplexo(banco);
            }
            else
            {
                CabecalhoSimples(banco); 
            }                       
        }

        public void Corpo(List<Conta> contas)
        {
            Console.WriteLine("--------------------CORPO----------------------");
            if (DeveUsarCorpoComplexo(contas))
            {
                CorpoComplexo(contas);
            }
            else
            {
                CorpoSimples(contas);
            }            
        }

        public void Rodape(Banco banco)
        {
            Console.WriteLine("-------------------RODAPÉ----------------------");
            if (DeveUsarRodapeComplexo(banco))
            {
                RodapeComplexo(banco);
            }
            else
            {
                RodapeSimples(banco);
            }            
        }

        protected abstract bool DeveUsarCabecalhoComplexo(Banco banco);
        protected abstract bool DeveUsarCorpoComplexo(List<Conta> contas);
        protected abstract bool DeveUsarRodapeComplexo(Banco banco);
        protected abstract void CabecalhoComplexo(Banco banco);
        protected abstract void CorpoComplexo(List<Conta> contas);
        protected abstract void RodapeComplexo(Banco banco);
        protected abstract void CabecalhoSimples(Banco banco);
        protected abstract void CorpoSimples(List<Conta> contas);
        protected abstract void RodapeSimples(Banco banco);
    }
}
