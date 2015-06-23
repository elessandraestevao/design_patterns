using DesignPatterns.modelo;
using DesignPatterns.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Orcamento orcamento = new Orcamento(500.0);
            Console.WriteLine(orcamento.Valor);

            //em aprovação
            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            //aprovado
            orcamento.Aprova();
            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            //finalizado
            //orcamento.Finaliza();
            orcamento.AplicaDescontoExtra();


            Imposto imposto = new IKCV(new ICPP());
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
            Orcamento orcamento = new Orcamento(1000.0);
            orcamento.AdicionaItem(new Item("LAPIS", 100.0));
            orcamento.AdicionaItem(new Item("Item2", 200.0));
            orcamento.AdicionaItem(new Item("Item3", 300.0));
            orcamento.AdicionaItem(new Item("Item4", 400.0));
            orcamento.AdicionaItem(new Item("Item5", 500.0));
            orcamento.AdicionaItem(new Item("CANETA", 50.0));

            //CalculadorDeDesconto calculador = new CalculadorDeDesconto();
            //Console.WriteLine(calculador.Calcula(orcamento));

            Imposto icms = new ICMS();
            Imposto iss = new ISS();
            Imposto iccc = new ICCC();

            CalculadorDeImposto calculador = new CalculadorDeImposto();
            calculador.CalculaImposto(orcamento, icms);
            calculador.CalculaImposto(orcamento, iss);
            calculador.CalculaImposto(orcamento, iccc);

            //Testando o Template Method            
            TemplateDeImpostoCondicional ihit = new IHIT();
            CalculadorDeImposto calculador = new CalculadorDeImposto();           
            calculador.CalculaImposto(orcamento, ihit);  */

            
            IList<AcaoAposGerarNota> acoes = new List<AcaoAposGerarNota>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            acoes.Add(new Multiplicador(4.5));
            

            NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("Empresa Teste")
                .ComCnpj("123.234.343/0001-12")
                .ComItem(new ItemDaNotaBuilder().ComDescricao("Item 1").ComValor(100.0).Constroi())
                .ComItem(new ItemDaNotaBuilder().ComDescricao("Item 2").ComValor(200.0).Constroi())
                .ComItem(new ItemDaNotaBuilder().ComDescricao("Item 3").ComValor(300.0).Constroi())                
                .ComObservacoes("Observacao da nota")               
                .Constroi();

            Console.WriteLine(nf.RazaoSocial + " " + nf.Cnpj);
            Console.WriteLine(nf.Observacoes + " " + nf.DataDeEmissao);
            Console.WriteLine(nf.ValorBruto + " " + nf.Impostos);
            foreach (var item in nf.Itens)
            {
                Console.WriteLine(item.Descricao + " " + item.Valor);
            }
            
            Console.ReadKey();
        }
    }
}
