using System;

class Programa
{
    static double PesoProva1 = 4.0, PesoProva2 = 3.0, PesoProva3 = 3.0, PesoTotal = PesoProva1 + PesoProva2 + PesoProva3;

    static void Main(string[] args)
    {
        Console.WriteLine("Aula 04 - IP - Refeito em C#\n");

        bool continuar = true;
        int opcao = 0;



        while (continuar)
        {
            Console.WriteLine($"\nDigite o exercício que você deseja executar");
            Console.WriteLine($"1 - Soma de 5 inteiros");0
            Console.WriteLine($"2 - Media de 5 números reais");
            Console.WriteLine($"3 - Imprimir o número H");
            Console.WriteLine($"4 - O aumento de um funcionário");
            Console.WriteLine($"5 - Média ponderada de 3 provas");
            Console.WriteLine($"\n0 - Sair");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (opcao)
            {
                case 0:
                    continuar = false;
                    break;

                case 1:
                    soma();
                    break;

                case 2:
                    media();
                    break;

                case 3:
                    numH();
                    break;

                case 4:
                    aumento();
                    break;

                case 5:
                    notaFinal();
                    break;

                default:
                    break;

            }
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }

    static void soma()
    {
        int[] vetor = new int[5];

        Console.WriteLine($"Digite o 1º inteiro");
        vetor[0] = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Digite o 2º inteiro");
        vetor[1] = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Digite o 3º inteiro");
        vetor[2] = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Digite o 4º inteiro");
        vetor[3] = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o 5º inteiro");
        vetor[4] = int.Parse(Console.ReadLine());

        int soma;

        soma = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];

        Console.WriteLine($"\nA soma dos 5 inteiros foi: {soma}");
    }

    static void media()
    {
        float[] vetor = new float[6];

        Console.WriteLine($"Digite o 1º número");
        vetor[0] = float.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o 2º número");
        vetor[1] = float.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o 3º número");
        vetor[2] = float.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o 4º número");
        vetor[3] = float.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o 5º número");
        vetor[4] = float.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o 6º número");
        vetor[5] = float.Parse(Console.ReadLine());

        float soma;

        soma = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4] + vetor[5];

        float media = soma / vetor.Length;

        Console.WriteLine($"\nA média total foi de: {media}");

    }

    static void numH()
    {
        double h;

        h = 1.0 + (1.0 / 2.0) + (1.0 / 3.0) + (1.0 / 4.0) + (1.0 / 5.0);

        Console.WriteLine($"O número H é igual a: {h}");

    }

    static void aumento()
    {
        double salario, porcentagem, aumento, novoSalario;
        

        Console.WriteLine($"Digite o salário do funcionário: ");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o aumento do salário em porcentagem: ");
        porcentagem = double.Parse(Console.ReadLine());


        aumento = (salario / 100.0) * porcentagem;

        novoSalario = salario + aumento;

        Console.WriteLine($"\nO novo salário do funcionário será R${novoSalario}");

    }

    static void notaFinal()
    {
        double[] provas = new double[3];
        double media;

        Console.WriteLine($"Digite a nota do aluno na prova 1: ");
        provas[0] = double.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a nota do aluno na prova 2: ");
        provas[1] = double.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a nota do aluno na prova 3: ");
        provas[2] = double.Parse(Console.ReadLine());


        media = ( (provas[0] * PesoProva1) + (provas[1] * PesoProva2) + (provas[2] * PesoProva3) ) / PesoTotal;

        Console.WriteLine($"\nA média ponderada das provas é: {media}");

    }


}