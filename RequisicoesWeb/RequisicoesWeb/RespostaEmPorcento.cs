using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    public class RespostaEmPorcento : Resposta
    {
        public Resposta Proxima { get; set; }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Nome + "%" + conta.Saldo);
            }
            else
            {
                Proxima.Responde(requisicao, conta);
            }
        }
    }
}
