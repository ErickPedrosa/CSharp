using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Investimento a longo prazo");

        double investimento = 1000.0;

        // Rendimento 0.5% (0.005) ao mês;
        double rendimento = 1.005;

        for (int anos = 1; anos <= 5; anos++)
        {

            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= rendimento;
                Console.WriteLine("No mês " + mes + " do ano " + anos + " você tem R$" + investimento);
            }

            rendimento += 0.001;
        }
        



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}