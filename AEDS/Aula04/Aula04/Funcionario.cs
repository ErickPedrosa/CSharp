using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula04Classes
{
    public class Funcionario
    {
        private string nome;
        private double salario;
        private Data dataDeEntrada;
        private string rg;

        public string Nome { get; private set; }
        public double Salario { get; private set; }
        public Data DataDeEntrada { get ; private set; }
        public string RG { get; private set; }

        public Funcionario(string nome, double salario, Data dataDeEntrada, string rg)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.DataDeEntrada = dataDeEntrada;  
            this.RG = rg;
        }

        public Funcionario()
        {
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

        public void mostra()
        {
            Console.WriteLine($"\nNome: {Nome}\nSalário: {Salario}\nData de entrada no banco: {DataDeEntrada.DataAtual()}\nRG: {RG}\n");
        }

    }

    public class Data
    {
        private int dia;
        private int mes;
        private int ano;
        public int Dia { get; private set; }
        public int Mes { get; private set; }
        public int Ano { get; private set; }

        public Data(int dia, int mes, int ano)
        {
            this.Dia = dia;
            this.Mes = mes;
            this.Ano = ano;
        }

        public Data()
        {
            int dia, mes, ano;

            Console.WriteLine("Digite o dia:");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes:");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano:");
            ano = int.Parse(Console.ReadLine());

            this.Dia = dia;
            this.Mes = mes;
            this.Ano = ano;
        }

        public string DataAtual()
        {
            return ($"{Dia}/{Mes}/{Ano}");
        }

        public void ImprimeData()
        {
            Console.WriteLine(this.DataAtual());
        }


    }

}
