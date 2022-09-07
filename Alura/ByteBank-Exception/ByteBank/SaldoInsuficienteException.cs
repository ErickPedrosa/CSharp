using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public SaldoInsuficienteException() : base() { }
        public SaldoInsuficienteException(string message) : base(message) { }
        public SaldoInsuficienteException(string message, Exception inner) : base(message, inner) { }
        

        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque de " + valorSaque + " com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

    }
}
