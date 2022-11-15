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


        public Restaurante(string nome, string endereco, int numMesas)
        {
            this.Nome = nome;
            this.Endereco = endereco;

            if (numMesas < 1)
            {
                throw new Exception("Valor de mesas deve ser maior que zero!!!");
            }
            else
            {
                this.Mesa = new Mesa[numMesas];
                for (int i = 0; i < this.Mesa.Length; i++)
                {
                    Mesa[i] = new Mesa();
                }
            }
            
        }
        
        public bool AdicionaOuRemoveMesas(int aumento)
        {
            
            int novoTamanho = Mesa.Length + aumento;
            if (novoTamanho < 1)
            {
                return false;
            }


            if (aumento < 0)
            {
                Console.WriteLine($"Você realmente deseja remover {(aumento * (-1))} mesas ? S - Sim / N - Não\nObs: Você irá perder todos os conteúdos das {(aumento * (-1))} últimas mesas");
                char c = char.Parse(Console.ReadLine().ToUpper());
                if (c == 'S')
                {
                    Mesa[] mesasBuff = new Mesa[novoTamanho];

                    for (int i = 0; i < novoTamanho; i++)
                    {
                        mesasBuff[i] = Mesa[i];

                    }

                    Mesa = mesasBuff;

                    return true;
                }
                else
                {
                    return false;
                }



            }
            else if(aumento > 0)
            {
                Mesa[] mesasBuff = new Mesa[novoTamanho];

                for (int i = 0; i < Mesa.Length; i++)
                {
                    mesasBuff[i] = Mesa[i];

                }
                for (int i = Mesa.Length; i < novoTamanho; i++)
                {
                    Mesa novaMesa = new Mesa();

                    mesasBuff[i] = novaMesa;

                }
                Mesa = mesasBuff;

                return true;
            }
            else
            {
                return false;
            }
        }


        public void ImprimeRestaurante()
        {
            Console.WriteLine($"Nome do Restaurante: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Número de Mesas: {Mesa.Length}");
            for (int i = 0; i < Mesa.Length; i++)
            {
                Console.WriteLine($"\nMesa {i + 1}: ");
                Mesa[i].ImprimeMesa();
            }
        }
    }
}
