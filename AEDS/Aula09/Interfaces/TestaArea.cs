using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class TestaArea
    {

        public static void Teste()
        {
            Quadrado quadrado = new Quadrado(4);
            Triangulo triangulo = new Triangulo(5, 4);
            IAreaCalculavel retangulo = new Retangulo(10, 20);

            Console.WriteLine($"Área do quadrado de lados {quadrado.Lado} cm: {quadrado.CalcularArea()} cm ");
            Console.WriteLine($"Área do triângulo de base {triangulo.TamBase} cm e altura {triangulo.Altura} cm: {triangulo.CalcularArea()} cm ");
            
            Retangulo r = (Retangulo)retangulo; // É necessário fazer casting para poder acessar os atributos TamBase e Altura
            Console.WriteLine($"Área do retângulo de base {r.TamBase} cm e altura {r.Altura} cm: {r.CalcularArea()} cm ");

        }

    }
}
