using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança 2");

        double investimento = 1000.0;

        // Rendimento 0.5% (0.005) ao mês;
        double rendimento = 1.005;

        /*
        while (mes <= 12)
        {
            investimento += (investimento * rendimento);
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);

            mes++;
        }
        */
        for(int mes = 1; mes < 12; mes++)
        {
            investimento *= rendimento;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
        }



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}