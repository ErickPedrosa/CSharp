using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public class Conta
    {
        protected double saldo = 0;

        public double Saldo { get { return saldo; } }

        
        public virtual bool Depositar(double valor)
        {
            if(valor > 0)
            {
                saldo += valor;
                
                return true;
            }
            else
            {
                Console.WriteLine($"Impossível depositar R${valor}");
                return false;
            }
            
        }
        public bool Sacar(double valor)
        {
            if (valor <= saldo && valor > 0)
            {
                saldo -= valor;

                return true;
            }
            else
            {
                Console.WriteLine($"Impossível sacar R${valor}\nSeu saldo atual é de R${saldo}");
                return false;
            }
        }

        public virtual void Atualiza(double taxa)
        {
            saldo += saldo * taxa;
        }
    }
}
