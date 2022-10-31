using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Aula07
{
    public class ContaPoupanca : Conta
    {
        public override void Atualiza(double taxa)
        {
            saldo += saldo * (taxa * 3);
        }
    }
}
