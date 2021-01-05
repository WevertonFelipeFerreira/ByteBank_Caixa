using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaUM = new ContaCorrente(8741,855521);
            ContaCorrente contaDois = new ContaCorrente(8741, 855531);
            ContaCorrente contatrew = new ContaCorrente(8741, 555531);
            ContaCorrente contaqua = new ContaCorrente(8741, 875531);
            ContaCorrente contacin = new ContaCorrente(8741, 855531);
            ContaCorrente contaseis = new ContaCorrente(8741, 455531);
            ContaCorrente contaseiss = new ContaCorrente(8741, 455531);
            ContaCorrente contaseisss = new ContaCorrente(8741, 455531);
            ContaCorrente contaseissss = new ContaCorrente(8741, 455531);
            ContaCorrente contaseisssss = new ContaCorrente(8741, 455531);


            Console.WriteLine("O total de contas criada é: "+ContaCorrente.TotalDeContasCriadas);
            Console.ReadLine();
            //comentttt
        }
    }
}
