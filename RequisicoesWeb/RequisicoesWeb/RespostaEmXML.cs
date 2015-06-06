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

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Nome + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                Proxima.Responde(requisicao, conta);
            }
        }
    }
}
