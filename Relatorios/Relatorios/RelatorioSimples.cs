using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class RelatorioSimples : TemplateRelatorio
    {

        protected override bool DeveUsarCabecalhoComplexo(Banco banco)
        {
            return false;
        }

        protected override bool DeveUsarCorpoComplexo(List<Conta> contas)
        {
            return false;
        }

        protected override bool DeveUsarRodapeComplexo(Banco banco)
        {
            return false;
        }

        protected override void CabecalhoComplexo(Banco banco)
        {
            throw new NotImplementedException();
        }

        protected override void CorpoComplexo(List<Conta> contas)
        {
            throw new NotImplementedException();
        }

        protected override void RodapeComplexo(Banco banco)
        {
            throw new NotImplementedException();
        }

        protected override void CabecalhoSimples(Banco banco)
        {
            Console.WriteLine(banco.Nome + " " + banco.Telefone);
        }

        protected override void CorpoSimples(List<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine(conta.Titular + " " + conta.Saldo);
            }
        }

        protected override void RodapeSimples(Banco banco)
        {
            Console.WriteLine(banco.Nome + " " + banco.Telefone);
        }
    }
}
