using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();
            gabriela.cpf = "485.654.741-88";
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Designer";

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = gabriela;
            Console.WriteLine(contaDaGabriela.titular.cpf);
            
            Console.ReadLine();
        }
    }
}
