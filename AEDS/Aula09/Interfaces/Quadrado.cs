using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class Quadrado : IAreaCalculavel
    {
        private int lado;

        public int Lado { get { return lado; } set { lado = value; } }

        public Quadrado(int lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            double area;

            area = lado * lado;

            return area;
        }
    }
}
