using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class Triangulo : IAreaCalculavel
    {
        private int tamBase;
        private int altura;

        public int TamBase { get { return tamBase; } set { tamBase = value; } }
        public int Altura { get { return altura; } set { altura = value; } }

        public Triangulo(int tamBase, int altura)
        {
            TamBase = tamBase;
            Altura = altura;
        }

        public double CalcularArea()
        {
            double area;

            area = (tamBase * altura) / 2;

            return area;
        }
    }
}
