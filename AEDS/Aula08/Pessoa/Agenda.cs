using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula08
{
    public class Agenda
    {

        private Pessoa[] pessoas;
        private int quantidadeAmigos;
        private int quantidadeConhecidos;
        public Pessoa[] Pessoas { get => pessoas; set => pessoas = value; }
        public int QuantidadeAmigos { get => quantidadeAmigos; set => quantidadeAmigos = value; }
        public int QuantidadeConhecidos { get => quantidadeConhecidos; set => quantidadeConhecidos = value; }

        
        public Agenda(int quantidadePessoas)
        {
            QuantidadeAmigos = 0;
            QuantidadeConhecidos = 0;

            Pessoas = new Pessoa[quantidadePessoas];

            for (int i = 0; i < quantidadePessoas; i++)
            {
                Random r = new Random();
                int tipo = r.Next(1, 3);

                if (tipo == 1) // Amigo
                {
                    Amigo a = new Amigo();
                    Pessoas[i] = a;
                    QuantidadeAmigos++;

                }else if(tipo == 2) // Conhecido
                {
                    Conhecido c = new Conhecido();
                    Pessoas[i] = c;
                    QuantidadeConhecidos++;
                }

            }
        }


        public void AddInformacoes()
        {
            Amigo amigo = new Amigo();
            Conhecido conhecido = new Conhecido();

            for (int i = 0; i < Pessoas.Length; i++)
            {
                Console.WriteLine($"\n\nPessoa {i + 1}\n");

                Console.WriteLine("Digite o nome: ");
                Pessoas[i].Nome = Console.ReadLine();

                Console.WriteLine("Digite a idade: ");
                Pessoas[i].Idade = int.Parse(Console.ReadLine());


                if (Pessoas[i].GetType() == amigo.GetType())
                {
                    Amigo a = (Amigo)Pessoas[i];
                    Console.WriteLine("Digite a data de aniversário: ");
                    a.DataDeAniversario = Console.ReadLine();

                }
                else if (Pessoas[i].GetType() == conhecido.GetType())
                {
                    Conhecido c = (Conhecido)Pessoas[i];
                    Console.WriteLine("Digite o email: ");
                    c.Email = Console.ReadLine();
                    
                }
            }

            

        }

    
        public void ImprimeAniversarios()
        {
            Amigo amigo = new Amigo();

            for (int i = 0; i < Pessoas.Length; i++)
            {

                if (Pessoas[i].GetType() == amigo.GetType())
                {
                    Amigo a = (Amigo)Pessoas[i];
                    Console.WriteLine($"Amigo: {a.Nome}\nAniversário: {a.DataDeAniversario}\n");
                }
            }

        }

        public void ImprimeEmail()
        {
            Conhecido conhecido = new Conhecido();

            for (int i = 0; i < Pessoas.Length; i++)
            {

                if (Pessoas[i].GetType() == conhecido.GetType())
                {
                    Conhecido c = (Conhecido)Pessoas[i];
                    Console.WriteLine($"Conhecido: {c.Nome}\nEmail: {c.Email}\n");
                }
            }

        }

    }
}
