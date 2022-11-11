using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimestral
{
    public class Cliente
    {
        private string nome;
        private string email;
        private Mesa mesa;

        public Mesa Mesa { get { return mesa; } private set { mesa = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void SentarEmUmaMesa(Mesa mesa)
        {
            bool sentado = mesa.AdicionarClientes(this);
            if (sentado)
            {
                Mesa = mesa;
            }
            
        }



    }
}
