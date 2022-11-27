using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public class Conhecido : Pessoa
    {

        private string email;

        public string Email { get => email; set => email = value; }

        public Conhecido() : base()
        {
            Email = "Indefinido";
        }

        public Conhecido(string nome, int idade, string email) : base(nome, idade)
        {
            Email = email;
        }
    }
}
