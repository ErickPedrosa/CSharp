using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class SeguroDeVida : ITributavel
    {

        public double CalcularTributos()
        {
            double taxaFixa = 42;

            return taxaFixa;
        }
    }
}
