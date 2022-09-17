using System;
using Alunos;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Aula 13 - IP - Refeito em C#\n");

        Aluno aluno = new Aluno();

        aluno.setAluno();
        aluno.setCurso();
        aluno.setIdade();
        aluno.setNotas();



        Aluno aluno2 = new Aluno("Erick", "Informática", 17);

         

        aluno2.setAluno("Erick Pedrosa");
        aluno2.setCurso("Info");
        aluno2.setIdade(18);
        aluno2.setNotas();


        aluno.imprime();
        aluno2.imprime();

        Aluno.imprimeMediaGeral();


    }

}