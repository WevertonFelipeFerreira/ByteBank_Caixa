using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Rafael";
            ContaCorrente conta = new ContaCorrente();
            if (conta.saldo == 0)
            {
                Console.WriteLine("Sem saldo definido");
            }
            else Console.WriteLine(conta.saldo);
            Console.ReadLine();

        }
    }
}
