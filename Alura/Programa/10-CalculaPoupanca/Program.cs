using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000.0;

        // Rendimento 0.5% (0.005) ao mês;
        double rendimento = 0.005;
        
        int mes = 1;

        while(mes <= 12)
        {
            investimento += (investimento * rendimento);
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);

            mes++;
        }




        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}