using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int agencia { get; set; }
        public int numero { get; set; }
        private double _saldo = 100; // o private faz com que o saldo seja manipulavel somente pela classe na qual ele esta inserido.
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        public bool Saque(double valor)
        {
            if (this._saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                this._saldo -= valor;
                Console.WriteLine("Foi sacado " + valor + " reais da conta de " + this.Titular);
                return true;
            }
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                Console.WriteLine("Foi Transferido " + valor + " reais para " + contaDestino.Titular);
                return true;
            }
        }
    }
}

