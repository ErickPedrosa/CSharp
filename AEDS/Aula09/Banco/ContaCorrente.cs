using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class ContaCorrente : Conta, ITributavel
    {
        public override void Atualiza(double taxa)
        {
            saldo += saldo * (taxa * 2);
        }

        public override bool Depositar(double valor)
        {

            valor = valor - 0.1;
            
            Console.WriteLine($"Valor depositado após a retirada de 10 centavos de taxa: R${valor}");

            return base.Depositar(valor);        

        }

        public double CalcularTributos()
        {
            double tributo;

            tributo = (saldo / 100);

            return tributo;
        }
    }
}
