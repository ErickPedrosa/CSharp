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

        public Mesa Mesa { get { return mesa; } set { mesa = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }


        public void ImprimeCliente()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Email: {Email}");
            /*if (Mesa != null)
            {
                Console.WriteLine($"Número da Mesa: {Mesa.NumMesa}");
            }*/
            
        }


    }
}
