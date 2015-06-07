using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public interface Relatorio
    {
        void Cabecalho(Banco banco);
        void Corpo(List<Conta> contas);
        void Rodape(Banco banco);
    }
}
