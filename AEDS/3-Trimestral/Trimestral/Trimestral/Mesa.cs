using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trimestral
{
    public class Mesa
    {
        private static int incremento = 1;

        private int tamanhoDaMesa = 4;
        private Cliente[] clientes = null;
        private int numMesa;
        private string data;
        private bool reservado;

        public int TamanhoDaMesa { get { return tamanhoDaMesa; } private set { tamanhoDaMesa = value; } }
        public int NumMesa { get { return numMesa; } private set { numMesa = value; } }
        public string Data { get { return data; } set { data = value; } }
        public bool Reservado { get { return reservado; } private set { reservado = value; } }
        public Cliente[] Clientes { get { return clientes; } private set { clientes = value; } }

        public Mesa()
        {
            numMesa = incremento;
            incremento++;

        }

        public bool Reservar()
        {
            if (Reservado)
            {
                return false;
            }
            else
            {
                Reservado = false;
                return true;
            }
        }
        public bool Reservar(int numDeClientes)
        {
            if (Reservado)
            {
                return false;
            }
            else
            {
                Reservado = false;
                TamanhoDaMesa = numDeClientes;
                return true;
            }
        }

        /*public void AdicionarClientes(Cliente[] clientes)
        {
            this.Clientes = clientes;

        }*/
        public bool AdicionarClientes(string nome, string email)
        {
            Cliente c = new Cliente(nome, email);

            if(c == null)
            {
                Clientes = new Cliente[1];
                Clientes[0] = c;

                return true;
            }
            else if(Clientes.Length < TamanhoDaMesa)
            {
                Cliente[] clientesBuff = new Cliente[Clientes.Length + 1];

                for (int i = 0; i < Clientes.Length; i++)
                {
                    clientesBuff[i] = Clientes[i];
                }
                clientesBuff[Clientes.Length] = c;

                Clientes = clientesBuff;

                return true;
            }
            else
            {
                return false;
            }


        }
        public bool AdicionarClientes(Cliente c)
        {

            if (Clientes == null)
            {
                Clientes = new Cliente[1];
                Clientes[0] = c;

                return true;
            }
            else if (Clientes.Length < TamanhoDaMesa)
            {
                Cliente[] clientesBuff = new Cliente[Clientes.Length + 1];

                for (int i = 0; i < Clientes.Length; i++)
                {
                    clientesBuff[i] = Clientes[i];
                }
                clientesBuff[Clientes.Length] = c;

                Clientes = clientesBuff;

                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
