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
            Resposta r1 = new RespostaEmXML();
            Resposta r2 = new RespostaEmCSV();
            Resposta r3 = new RespostaEmPorcento();

            r1.Proxima = r2;
            r2.Proxima = r3;
            r3.Proxima = r1;

            r1.Responde(requisicao, conta);
        }
    }
}
