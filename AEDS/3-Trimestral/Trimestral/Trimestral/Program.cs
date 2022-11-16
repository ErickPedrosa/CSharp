using System.Linq.Expressions;
using System.Text;
using System;

namespace Trimestral
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* ----- Debug Comanda ----- */
            /*
            Comanda comanda = new Comanda();

            comanda.AnotarPedido("Churrasco", 20);
            comanda.AnotarPedido("Vinho", 60);
            comanda.AnotarPedido("Champanhe", 100);
            Console.WriteLine(comanda.Calcular10Porcento());
            Console.WriteLine(comanda.DividirConta(2));

            comanda.ListarConsumo();
            */


            /* ----- Debug Cliente ----- */
            /*
            Cliente cliente = new Cliente("Erick", "erick@gmail.com");
            Mesa mesa = new Mesa();
            
            mesa.Reservar(3);
            mesa.AdicionarClientes(cliente);

            cliente.ImprimeCliente();
            mesa.Clientes[0].ImprimeCliente();
            */


            /* ----- Debug Mesa ----- */
            /*
            Mesa mesa = new Mesa();

            Console.WriteLine(mesa.Reservado);
            Console.WriteLine(mesa.AdicionarClientes("J", "J@g.com"));
            mesa.Reservar(2);
            Console.WriteLine(mesa.Reservado);
            Console.WriteLine(mesa.AdicionarClientes("L", "L@g.com"));
            Console.WriteLine(mesa.AdicionarClientes("M", "M@g.com"));
            Console.WriteLine(mesa.AdicionarClientes("N", "N@g.com"));
            mesa.AnotarPedido("a", 10);
            mesa.AnotarPedido("b", 0.50);
            mesa.AnotarPedido("c", 1540);
            mesa.Comanda.ListarConsumo();
            */

            /* ----- Debug Restaurante ----- */
                                                        
            Restaurante r = new Restaurante("Bill's", "R. das Cerejeiras, 144", 5); // Zero ou menos mesas levanta uma Exception;

            Console.WriteLine(r.Nome);
            Console.WriteLine(r.Endereco);
            Console.WriteLine(r.AdicionaOuRemoveMesas(0));
            Console.WriteLine(r.AdicionaOuRemoveMesas(-5));
            Console.WriteLine(r.AdicionaOuRemoveMesas(-10));
            Console.WriteLine(r.AdicionaOuRemoveMesas(-3));
            Console.WriteLine(r.Mesa.Length);
            Console.WriteLine(r.AdicionaOuRemoveMesas(2));
            Console.WriteLine(r.Mesa.Length);

            r.Mesa[0].Reservar(4);
            r.Mesa[1].Reservar(1);
            r.Mesa[3].Reservar(2);

            r.Mesa[0].AdicionarClientes("Vivi", "v@gmail.com");
            r.Mesa[0].AdicionarClientes("Honda", "h@gmail.com");
            r.Mesa[0].AdicionarClientes("El Maia", "l@gmail.com");
            r.Mesa[0].AdicionarClientes("João", "j@gmail.com");

            r.Mesa[1].AdicionarClientes("Erick", "e@gmail.com");
            r.Mesa[1].AdicionarClientes("Gabi", "g@gmail.com"); // Retorna False pois a reserva é para 1;

            r.Mesa[3].AdicionarClientes("Juju", "j@gmail.com");
            r.Mesa[3].AdicionarClientes("Kaio", "k@gmail.com");

            r.Mesa[0].AnotarPedido("Espaguete integral ao alho e óleo", 35);
            r.Mesa[0].AnotarPedido("Bolo de carne vegano", 40);
            r.Mesa[0].AnotarPedido("Estrogonofe de berinjela", 15);
            r.Mesa[1].AnotarPedido("Filé de frango com molho de mostarda", 30);
            r.Mesa[1].AnotarPedido("Rocambole de carne moída", 45);
            r.Mesa[3].AnotarPedido("Frango xadrez", 30);
            r.Mesa[3].AnotarPedido("Suflê de Chuchu", 25);

            Console.WriteLine("\n\n");
            r.ImprimeRestaurante();
            


        }

    }
}
