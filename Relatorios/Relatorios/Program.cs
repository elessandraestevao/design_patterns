using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateRelatorio simples = new RelatorioSimples();
            TemplateRelatorio complexo = new RelatorioComplexo();
            Banco banco = new Banco("Banco do Brasil", "Endereço de Teste", "35 3471-0909", "bb@bancodobrasil.com");
            List<Conta> contas = new List<Conta>();
            contas.Add(new Conta("Titular1", "Agência1", 1, 1000.0));
            contas.Add(new Conta("Titular2", "Agência2", 2, 2000.0));
            contas.Add(new Conta("Titular3", "Agência3", 3, 3000.0));

            simples.Cabecalho(banco);
            simples.Corpo(contas);
            simples.Rodape(banco);

            complexo.Cabecalho(banco);
            complexo.Corpo(contas);
            complexo.Rodape(banco);

            Console.ReadKey();
        }
    }
}
