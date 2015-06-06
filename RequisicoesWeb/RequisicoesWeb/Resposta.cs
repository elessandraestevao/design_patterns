using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicoesWeb
{
    public interface Resposta
    {
        //Resposta Proxima { get; set; }
        void Responde(Requisicao requisicao, Conta conta);        
    }
}
