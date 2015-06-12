using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            Console.WriteLine(c.Status);
            c.Deposita(100.0);
            Console.WriteLine(c.Saldo);
            Console.WriteLine(c.Status);
            c.Saca(99);
            Console.WriteLine(c.Saldo);
            Console.WriteLine(c.Status);
            c.Deposita(100.0);
            Console.WriteLine(c.Saldo);
            Console.WriteLine(c.Status);
            c.Deposita(100.0);
            Console.WriteLine(c.Saldo);
            Console.WriteLine(c.Status);
            Console.ReadKey();

        }
    }
}
