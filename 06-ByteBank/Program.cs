using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.nome = "Alejandro";
            cliente.profissao = "Developer";
            cliente.cpf = "478.985.475-20";

            conta.Titular = cliente;
            conta.Saldo += 30;
            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Titular.cpf);
            Console.WriteLine(conta.Titular.profissao);
            Console.WriteLine(conta.Saldo);






            Console.ReadLine();
        }
    }
}
