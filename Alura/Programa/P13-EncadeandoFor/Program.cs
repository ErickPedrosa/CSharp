using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando For");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("*");
                if(j >= i)
                {
                    break;
                }
            }
            Console.WriteLine();
        }



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}