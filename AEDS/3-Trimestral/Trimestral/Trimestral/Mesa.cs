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
        private ComandaBebidas comandaBebidas;
        private ComandaComidas comandaComidas;

        public ComandaBebidas ComandaBebidas { get { return comandaBebidas; } private set { comandaBebidas = value; } }
        public ComandaComidas ComandaComidas { get { return comandaComidas; } private set { comandaComidas = value; } }

        public int TamanhoDaMesa { get { return tamanhoDaMesa; } private set { tamanhoDaMesa = value; } }
        public int NumMesa { get { return numMesa; } private set { numMesa = value; } }
        public string Data { get { return data; } set { data = value; } }
        public bool Reservado { get { return reservado; } private set { reservado = value; } }
        public Cliente[] Clientes { get { return clientes; } private set { clientes = value; } }

        public Mesa()
        {
            numMesa = incremento;
            incremento++;
            Reservado = false;
            Data = DateTime.Now.ToString();
            ComandaBebidas = new ComandaBebidas();
            ComandaComidas = new ComandaComidas();
        }

        public bool Reservar()
        {
            if (Reservado)
            {
                return false;
            }
            else
            {
                Reservado = true;
                tamanhoDaMesa = 2;
                Data = DateTime.Now.ToString();
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
                Reservado = true;
                TamanhoDaMesa = numDeClientes;
                Data = DateTime.Now.ToString();
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
            

            if (Reservado == true)
            {
                c.Mesa = this;

                if (Clientes == null)
                {
                    Clientes = new Cliente[1];
                    Clientes[0] = c;

                    return true;
                }
                else if ( !(Clientes == null) && (Clientes.Length < TamanhoDaMesa) )
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
            else
            {
                return false;
            }

            


        }
        public bool AdicionarClientes(Cliente c)
        {
            
            if (Reservado == true)
            {
                c.Mesa = this;
                if (Clientes == null)
                {
                    Clientes = new Cliente[1];
                    Clientes[0] = c;

                    return true;
                }
                else if (!(Clientes == null) && (Clientes.Length < TamanhoDaMesa))
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
            else
            {
                return false;
            }


        }

        public bool RemoverClientes(Cliente c)
        {
            if (Clientes == null)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Clientes.Length; i++)
                {
                    if (Clientes[i] == c)
                    {
                        Cliente[] buffer = new Cliente[Clientes.Length - 1];

                        for (int j = 0; j < i; j++)
                        {
                            buffer[j] = Clientes[j];
                        }
                        for (int j = i; j < buffer.Length; j++)
                        {
                            buffer[j] = Clientes[j + 1];
                        }
                        Clientes = buffer;

                        return true;
                    }

                }

                return false;
            }
        }
        public bool RemoverClientes(string email)
        {
            if (Clientes == null)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Clientes.Length; i++)
                {
                    if (Clientes[i].Email == email)
                    {
                        RemoverClientes(Clientes[i]);
                    }
                }
            }
            return false;
              
        }
        
        
        public void AnotarPedido(string pedido, double preco, int tipo)
        {
            if (tipo == 0)
            {
                ComandaBebidas.AnotarPedido(pedido, preco);
            }
            else if(tipo == 1)
            {
                ComandaComidas.AnotarPedido(pedido, preco);
            }
            
        }


        public void ImprimeMesa()
        {
            Console.WriteLine($"Número da Mesa: {NumMesa}");
            Console.WriteLine($"Data: {Data}");
            Console.WriteLine($"Reservado: {Reservado}");
            if(Clientes != null)
            {
                Console.WriteLine($"Número de clientes: {Clientes.Length}");

                for (int i = 0; i < Clientes.Length; i++)
                {
                    Console.WriteLine($"\nCliente {i + 1}: ");
                    Clientes[i].ImprimeCliente();
                }

                Console.WriteLine($"\nConsumo da mesa:");
                Console.WriteLine($"\nComidas:");
                ComandaComidas.ListarConsumo();
                Console.WriteLine($"\nBebidas:");
                ComandaBebidas.ListarConsumo();
            }

        }
    }
}
