using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimestral
{
    public class Restaurante
    {
        private string nome;
        private string endereco;
        private Mesa[] mesa;

        public Mesa[] Mesa { get { return mesa; } private set { mesa = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
    }
}
