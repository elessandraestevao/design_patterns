using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    public class CriadorDeResposta
    {
        public void Resposta(Requisicao requisicao, Conta conta)
        {
            //r3 é o final da cadeia
            Resposta r3 = new RespostaEmPorcento();
            Resposta r2 = new RespostaEmCSV(r3);
            Resposta r1 = new RespostaEmXML(r2);            

            //r1.Proxima = r2;
            //r2.Proxima = r3;
            //r3.Proxima = r1;

            r1.Responde(requisicao, conta);
        }
    }
}
