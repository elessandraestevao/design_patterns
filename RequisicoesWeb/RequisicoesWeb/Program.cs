using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Requisicao requisicao = new Requisicao(new Formato());
            Conta conta = new Conta(1000.0, "João");

            CriadorDeResposta criador = new CriadorDeResposta();
            criador.Resposta(requisicao, conta);
            Console.ReadKey();
        }
    }
}
