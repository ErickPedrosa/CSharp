using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos");

        double salario = 3000.15;
        Console.WriteLine(salario);


        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // Long é um inteiro de 64 bits;
        long x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

}
