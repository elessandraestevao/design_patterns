using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    public class RespostaEmXML : Resposta
    {
        public Resposta Proxima { get; set; }

        public RespostaEmXML(Resposta resposta)
        {
            this.Proxima = resposta;
        }

        public RespostaEmXML()
        {
            this.Proxima = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Nome + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
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
