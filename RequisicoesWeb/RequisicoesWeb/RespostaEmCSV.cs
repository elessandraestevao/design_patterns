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

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Nome + ";" + conta.Saldo);
            }
            else
            {
                Proxima.Responde(requisicao, conta);
            }
        }
    }
}
