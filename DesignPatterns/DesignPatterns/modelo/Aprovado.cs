using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.modelo
{
    public class Aprovado : EstadoDoOrcamento
    {
        public bool DescontoAplicado { get; set; }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (this.DescontoAplicado)
            {
                throw new Exception("O desconto só pode ser aplicado uma única vez!");
            }
            else
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                this.DescontoAplicado = true;
            }            
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }
    }
}
