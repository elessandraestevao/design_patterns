using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    public class RespostaEmCSV : Resposta
    {
        public Resposta Proxima { get; set; }

        public RespostaEmCSV(Resposta resposta)
        {
            this.Proxima = resposta;
        }

        public RespostaEmCSV()
        {
            this.Proxima = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Nome + ";" + conta.Saldo);
            }
            else if(Proxima != null)
            {
                Proxima.Responde(requisicao, conta);
            }
            else
            {
                //Não existe próxima, é o final da cadeia
                throw new Exception("Nenhum tipo de resposta foi definido: XML, CSV ou PORCENTO!");
            }
        }
    }
}
