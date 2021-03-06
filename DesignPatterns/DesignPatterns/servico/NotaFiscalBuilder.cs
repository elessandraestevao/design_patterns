﻿using DesignPatterns.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.servico
{
    public class NotaFiscalBuilder
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public String Observacoes { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        private IList<AcaoAposGerarNota> todasAcoesAposGerarNota = new List<AcaoAposGerarNota>();

        public NotaFiscalBuilder(IList<AcaoAposGerarNota> acoes)
        {
            this.Itens = new List<ItemDaNota>();
            this.DataDeEmissao = DateTime.Now;
            this.todasAcoesAposGerarNota = acoes;
        }

        public NotaFiscalBuilder()
        {
            this.Itens = new List<ItemDaNota>();
            this.DataDeEmissao = DateTime.Now;
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            this.Itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime data)
        {
            this.DataDeEmissao = data;
            return this;
        }

        /*public NotaFiscalBuilder Executa(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesAposGerarNota.Add(novaAcao);
            return this;
        }*/
      
        private void executaAcaoAposGerarNota(NotaFiscal nf){
            foreach (AcaoAposGerarNota acao in todasAcoesAposGerarNota)
            {
                acao.Executa(nf);
            }
        }

        public NotaFiscal Constroi()
        {            
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Impostos, DataDeEmissao, Observacoes, Itens);
            executaAcaoAposGerarNota(nf);
            return nf;
        }
    }
}
