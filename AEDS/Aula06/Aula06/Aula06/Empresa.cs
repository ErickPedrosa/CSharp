using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    public class Empresa
    {
        private Funcionario[] empregados;
        private string cnpj;
        private string nome;


        public Funcionario[] Empregados { get; private set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }

        public void Contrata(Funcionario funcionario)
        {
            if (empregados == null)
            {
                empregados = new Funcionario[1];
                empregados[0] = funcionario;
            }
            else
            {
                Funcionario[] empregadosBuf = new Funcionario[empregados.Length + 1];

                for (int i = 0; i < empregados.Length; i++)
                {
                    empregadosBuf[i] = empregados[i];
                }
                empregadosBuf[empregados.Length] = funcionario;

                empregados = empregadosBuf;
            }
        }

        public Empresa(Funcionario[] empregados, string cnpj, string nome)
        {
            this.Empregados = empregados;
            this.Cnpj = cnpj;
            this.Nome = nome;
        }

        public Empresa()
        {
            string nome, cnpj;
            int numFuncionarios = 0;
            Funcionario[] empregados;

            Console.WriteLine("Digite o nome da empresa:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CNPJ da empresa:");
            cnpj = Console.ReadLine();
            Console.WriteLine("Digite o n° de funcionários da empresa:");
            numFuncionarios = int.Parse(Console.ReadLine());

            empregados = new Funcionario[numFuncionarios];

            for(int i = 1; i <= numFuncionarios; i++)
            {
                Console.WriteLine($"\nFuncionário {i}:");
                Funcionario f = new Funcionario();

                empregados[i] = f;
            }

            this.Empregados = empregados;
            this.Cnpj = cnpj;
            this.Nome = nome;
        }

        public void Mostra()
        {
            Console.WriteLine($"\nNome: {Nome}");
            Console.WriteLine($"CNPJ: {Cnpj}");

            int i = 1;
            foreach(Funcionario f in Empregados)
            {
                Console.WriteLine($"\nFuncionário {i}");
                f.Mostra();

                i++;
            }
        }

    }
}
