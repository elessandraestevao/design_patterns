using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class RelatorioComplexo : TemplateRelatorio
    {
        protected override bool DeveUsarCabecalhoComplexo(Banco banco)
        {
            return true;
        }

        protected override bool DeveUsarCorpoComplexo(List<Conta> contas)
        {
            return true;
        }

        protected override bool DeveUsarRodapeComplexo(Banco banco)
        {
            return true;
        }

        protected override void CabecalhoComplexo(Banco banco)
        {
            Console.WriteLine(banco.Nome + " " + banco.Endereco + " " + banco.Telefone);
        }

        protected override void CorpoComplexo(List<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine(conta.Titular + " " + conta.Agencia + " " + conta.Numero + " " + conta.Saldo);
            }
        }

        protected override void RodapeComplexo(Banco banco)
        {
            Console.WriteLine(banco.Email + " " + DateTime.Today);
        }        

        protected override void CabecalhoSimples(Banco banco)
        {
            throw new NotImplementedException();
        }

        protected override void CorpoSimples(List<Conta> contas)
        {
            throw new NotImplementedException();
        }

        protected override void RodapeSimples(Banco banco)
        {
            throw new NotImplementedException();
        }
    }
}
