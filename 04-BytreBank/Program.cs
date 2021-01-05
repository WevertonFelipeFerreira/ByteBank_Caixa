using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_BytreBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            contaDoBruno.saldo = 1000;
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaBruna = new ContaCorrente();
            contaDaBruna.titular = "Bruna";

            contaDoBruno.Transferir(300, contaDaBruna);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaDaBruna.saldo);
            Console.ReadLine();
        }
    }

}
