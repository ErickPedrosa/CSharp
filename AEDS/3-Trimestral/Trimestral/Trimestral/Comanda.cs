using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimestral
{
    public abstract class Comanda
    {
        private string consumo;
        private double valor;

        public string Consumo { get => consumo; private set => consumo = value; }
        public double Valor {
            get
            {
                return valor;
            }
            private set
            {
                if (valor >= 0)
                {
                    valor = value;
                }
                
            }
        }

        public Comanda()
        {
            this.Consumo = "";
            this.Valor = 0;
        }

        public void ListarConsumo()
        {
            Console.WriteLine($"Pedido:\n{Consumo}");
            Console.WriteLine($"Valor Total: R${Valor.ToString("0.00")}");
        }
        
        public double Calcular10Porcento()
        {
            double total = 0;

            total = Valor / 10;

            return total;
        }

        public double DividirConta(int numClientes)
        {
            return (Valor / numClientes);
        }

        public double DividirConta(Mesa mesa)
        {
            return (Valor / mesa.Clientes.Length);
        }

            
        public void AnotarPedido(string pedido, double preco)
        {
            Consumo += (pedido + "\n");
            Valor += preco;

        }
    }
}
