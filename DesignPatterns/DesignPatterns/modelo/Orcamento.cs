using DesignPatterns.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public EstadoDoOrcamento Estado { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.Estado = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra(){
            this.Estado.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            this.Estado.Aprova(this);
        }

        public void Reprova()
        {
            this.Estado.Reprova(this);
        }

        public void Finaliza()
        {
            this.Estado.Finaliza(this);
        }
    }
}
