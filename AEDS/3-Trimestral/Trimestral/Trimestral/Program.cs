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
            /*                                           
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
            r.Mesa[0].RemoverClientes("j@gmail.com");

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
            */

            Menu();



        }

        public static void Menu()
        {
            bool ativo = true;

            Restaurante rest = new Restaurante("Buchinho Cheio", "Av. Presidente Antonio Carlos", 4);

            do
            {
                EscreveLinha(50);
                Console.WriteLine($"Bem vindos ao Restaurante {rest.Nome}");
                EscreveLinha(50);

                Opcoes();
                EscreveLinha(50);

                Console.WriteLine("Qual operação você deseja realizar: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        ativo = false;
                        break;
                    case 1:
                        EscreveLinha(50);
                        EscreveLinha(50);
                        rest.ImprimeRestaurante();
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine("");

                        break;


                    case 2:
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine($"Digite o número de mesas que irão aumentar (digite um número negativo para diminuir): ");
                        int n = int.Parse(Console.ReadLine());
                        rest.AdicionaOuRemoveMesas(n);
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine("");
                        break;


                    case 3:
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine($"Digite o número da mesa que você deseja reservar: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Digite o número de pessoas para a mesa que você deseja reservar: ");
                        int numPessoas = int.Parse(Console.ReadLine());
                        rest.Mesa[x - 1].Reservar(numPessoas);
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine("");
                        break;


                    case 4:
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine($"Digite o número da mesa que você o cliente deseja se assentar: ");
                        int y = int.Parse(Console.ReadLine());
                        y = y - 1;
                        if(rest.Mesa[y].Reservado)
                        {
                            Console.WriteLine("Mesa reservada corretamente\n");
                            Console.WriteLine($"Digite o nome do cliente: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine($"Digite o email do cliente: ");
                            string email = Console.ReadLine();
                            rest.Mesa[y].AdicionarClientes(nome, email);
                        }
                        else
                        {
                            Console.WriteLine("Mesa não reservada. Impossível assentar-se!!!");
                            
                        }
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine("");
                        break;


                    case 5:
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine($"Digite o número da mesa que você deseja remover um cliente: ");
                        int z = int.Parse(Console.ReadLine());
                        z = z - 1;
                        if (rest.Mesa[z].Reservado)
                        {
                            Console.WriteLine("Mesa reservada corretamente\n");
                            Console.WriteLine($"Digite o email do cliente: ");
                            string email = Console.ReadLine();
                            rest.Mesa[z].RemoverClientes(email);
                        }
                        else
                        {
                            Console.WriteLine("Mesa não reservada, portanto não há ninguem para remover!!!");

                        }
                        EscreveLinha(50);
                        EscreveLinha(50);
                        Console.WriteLine("");
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    default:
                        break;
                }


                 


            } while (ativo);
        }

        public static void Opcoes()
        {
            Console.WriteLine(@"1 - Imprimir situação atual do restaurante
2 - Aumentar/Reduzir o número de mesas
3 - Reservar uma mesa
4 - Adicionar um cliente a uma mesa
5 - Remover um cliente de uma mesa
6 - Fazer um pedido
7 - Listar a conta total de uma mesa
8 - Calcular 10%
9 - Dividir a conta
0 - Sair do Restaurante");
        }

        public static void EscreveLinha(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine("");

        }

    }
}
