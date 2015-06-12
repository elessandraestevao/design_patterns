using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.modelo
{
    public class Reprovado : EstadoDoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado não recebe desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }
}
