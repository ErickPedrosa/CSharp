using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    public class Funcionario
    {
        public static int numFuncionarios = 0;


        private int identificador;
        private string nome;
        private double salario;
        private Data dataDeEntrada;
        private string rg;

        public int Identificador { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Data DataDeEntrada { get; private set; }
        public string RG { get; private set; }

        public Funcionario(string nome, double salario, Data dataDeEntrada, string rg)
        {
            numFuncionarios++;
            this.Identificador = numFuncionarios;

            this.Nome = nome;
            this.Salario = salario;
            this.DataDeEntrada = dataDeEntrada;
            this.RG = rg;
        }

        public Funcionario()
        {
            numFuncionarios++;
            this.Identificador = numFuncionarios;

            string nome, rg;
            double salario;
            Data dataDeEntrada;

            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o RG:");
            rg = Console.ReadLine();
            Console.WriteLine("Digite o salário:");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a data da entrada do funcionário no banco:");

            dataDeEntrada = new Data();

            this.Nome = nome;
            this.Salario = salario;
            this.DataDeEntrada = dataDeEntrada;
            this.RG = rg;

        }

        public void Mostra()
        {
            Console.WriteLine($"Nome: {Nome}\nSalário: {Salario}\nData de entrada no banco: {DataDeEntrada.DataAtual()}\nRG: {RG}\nIdentificador: {Identificador}\n");
        }

    }

    


    
}
