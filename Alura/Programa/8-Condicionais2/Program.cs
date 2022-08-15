using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = (quantidadePessoas > 0);
        bool idadeMinima = (idadeJoao >= 18);
        bool podeEntrar = (idadeMinima || acompanhado);

        if (podeEntrar)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}