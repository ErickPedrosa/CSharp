using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {

        private string nome;
        private string cpf;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; private set => cpf = value; }
        public double Salario { get => salario; protected set => salario = value; }
        public static int totalDeFuncionarios { get; private set; }
    

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;

            totalDeFuncionarios++;
        }

        public abstract double getBonificacao();

        public abstract void aumentarSalario();



    }
}
