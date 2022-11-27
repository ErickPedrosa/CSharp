using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class GerenciadorDeImpostoDeRenda
    {
        private double totalTributos;
        public double TotalTributos { get => totalTributos; set => totalTributos = value; }
        public GerenciadorDeImpostoDeRenda(ITributavel[] tributaveis)
        {
            TotalTributos = 0;
            foreach (ITributavel t in tributaveis)
            {
                TotalTributos += t.CalcularTributos();

            }
        }

        public void ImprimeTotalTributos ()
        {
            Console.WriteLine($"\nTotal a pagar de impostos: R${TotalTributos.ToString("0.00")}");

        }
    }
}
