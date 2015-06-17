using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.modelo
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public String Observacoes { get; set; }
        public IList<ItemDaNota> Itens { get; set; }

        public NotaFiscal(String razaoSocial, String cnpj, double valorBruto, double impostos, 
            DateTime dataDeEmissao, String observacoes, IList<ItemDaNota> itens)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.DataDeEmissao = dataDeEmissao;
            this.Observacoes = observacoes;
            this.Itens = itens;
        }
    }
}
