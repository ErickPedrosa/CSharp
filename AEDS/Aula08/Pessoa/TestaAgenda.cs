using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public static class TestaAgenda
    {

        public static void TesteAgenda()
        {

            Console.WriteLine("Digite o número de pessoas vocês desjam colocar na agenda: ");
            int n = int.Parse(Console.ReadLine());

            Agenda agenda = new Agenda(n);

            agenda.AddInformacoes();

            Console.WriteLine($"Núm. de Amigos: {agenda.QuantidadeAmigos}");
            Console.WriteLine($"Núm. de Conhecidos: {agenda.QuantidadeConhecidos}");

            Console.WriteLine("\nAniversários de seus amigos na agenda:");
            agenda.ImprimeAniversarios();

            Console.WriteLine("\nEmails de seus conhecidos na agenda:");
            agenda.ImprimeEmail();
            

            Console.ReadLine();
        }


    }
}
