using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class AtualizadorDeContas
    {
        private double saldoTotal = 0;
        private double selic;

        public double SaldoTotal { get { return saldoTotal; } }
        public double Selic { get { return selic; } }
    
        public AtualizadorDeContas(double selic)
        {
            this.selic = selic;
        }

        public void Roda(Conta c)
        {
            Console.WriteLine($"Saldo anterior: R${c.Saldo}");
            c.Atualiza(Selic);
            Console.WriteLine($"Saldo atual: R${c.Saldo}");

            saldoTotal += c.Saldo;
        }
    }
}
