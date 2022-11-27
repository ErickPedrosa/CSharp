using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public class Amigo : Pessoa
    {
        private string dataDeAniversario;

        public string DataDeAniversario { get => dataDeAniversario; set => dataDeAniversario = value; }

        public Amigo() : base()
        {
            DataDeAniversario = "Indefinido";
        }

        public Amigo(string nome, int idade, string dataDeAniversario) : base(nome, idade)
        {
            DataDeAniversario = dataDeAniversario;
        }



    }
}
