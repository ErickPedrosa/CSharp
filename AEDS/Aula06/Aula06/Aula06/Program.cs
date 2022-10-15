using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario func1, func2, func3;

            Data data = new Data(-99, 13, 20000);

            

            func1 = new Funcionario("Erick Pedrosa", 1000000, data, "12121212");
            func2 = new Funcionario("Julia Luna", 5655550, data, "181212568");
            func3 = new Funcionario("Kaio Fernandes", 456123, data, "45645123");

            Funcionario[] funcionarios = new Funcionario[] { func1, func2, func3 };

            Empresa empresa = new Empresa(funcionarios, "456123789", "Silph Core");

            empresa.Mostra();

            Empresa empresa2 = new Empresa();

            empresa2.Mostra();


        }
    }
}
