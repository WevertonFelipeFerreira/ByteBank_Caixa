using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Saque(double valor)
    {
        if (this.saldo < valor)
        {
            Console.WriteLine("Saldo insuficiente");
            return false;
        }
        else
        {
            this.saldo -= valor;
            Console.WriteLine("Foi sacado " + valor + " reais da conta de " + this.titular);
            return true;
        }
    }
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            Console.WriteLine("Foi Transferido " + valor + " reais para " + contaDestino.titular);
            return true;
        }
    }
}

