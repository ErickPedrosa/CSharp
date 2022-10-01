using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula04Classes;

namespace Aula04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario func1, func2, func3;

            Data data = new Data(02, 10, 0);

            func1 = new Funcionario("Erick Pedrosa", 1000000, data, "12121212");
            func2 = new Funcionario(/*"Erick Pedrosa", 1000000, data, "12121212"*/);
            func3 = func1;

            func1.mostra();
            func2.mostra();
            func3.mostra();

            if (func1 == func2)
            {
                Console.WriteLine("O funcionário 1 é igual ao funcionário 2");
            }
            else
            {
                Console.WriteLine("O funcionário 1 é diferente do funcionário 2");
            }

            if (func1 == func3)
            {
                Console.WriteLine("O funcionário 1 é igual ao funcionário 3");
            }


        }
    }
}
