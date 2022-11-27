using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }


        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public Pessoa()
        {
            this.Nome = "Indefinido";
            this.Idade = 0;
            
        }
    }
}
