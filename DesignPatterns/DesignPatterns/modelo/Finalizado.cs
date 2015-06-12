using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.modelo
{
    public class Finalizado : EstadoDoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento finalizado não recebe desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está finalizado!");
        }
    }
}
