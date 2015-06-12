using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.modelo
{
    public class EmAprovacao : EstadoDoOrcamento
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
                orcamento.Valor -= orcamento.Valor * 0.05;
                this.DescontoAplicado = true;
            }            
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento não pode ser finalizado diretamente!");
        }
    }
}
