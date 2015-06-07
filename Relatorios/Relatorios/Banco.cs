using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorios
{
    public class Banco
    {
        public String Nome { get; private set; }
        public String Endereco { get; private set; }
        public String Telefone { get; private set; }
        public String Email { get; private set; }

        public Banco(String nome, String endereco, String telefone, String email)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}
