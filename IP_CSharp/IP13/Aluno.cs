using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alunos
{
    public class Aluno
    {
        public static double MediaGeral { get; private set; }

        private double[] Notas { get; set; } 
        private string Nome { get; set; }
        private string Curso { get; set; }
        private int Idade { get; set; }
        public bool Aprovacao { get; private set; }

        public Aluno()
        {
            Aprovacao = false;
            Notas = new double[3];
        }
        public Aluno(string nome, string curso, int idade)
        {
            this.Nome = nome;
            this.Curso = curso;
            this.Idade = idade;

            Aprovacao = false;
            Notas = new double[3];
        }



        public void setAluno(string nome)
        {
            this.Nome = nome;
        }
        public void setAluno()
        {
            string nome;

            nome = Console.ReadLine();

            this.Nome = nome;
        }


        public void setCurso(string curso)
        {
            this.Curso = curso;
        }
        public void setCurso()
        {
            string curso;

            curso = Console.ReadLine();

            this.Curso = curso;
        }


        public void setIdade(int idade)
        {
            
            this.Idade = idade;
        }
        public void setIdade()
        {
            int idade;

            idade = int.Parse(Console.ReadLine());

            this.Idade = idade;
        }

        public void setNotas(double nota1, double nota2, double nota3)
        {
            this.Notas[0] = nota1;
            this.Notas[1] = nota2;
            this.Notas[2] = nota3;

            calcMedGeral(media());
        }
        public void setNotas(double[] nota)
        {
            this.Notas[0] = nota[0];
            this.Notas[1] = nota[1];
            this.Notas[2] = nota[2];

            calcMedGeral(media());
        }
        public void setNotas()
        {
            this.Notas[0] = double.Parse(Console.ReadLine());
            this.Notas[1] = double.Parse(Console.ReadLine());
            this.Notas[2] = double.Parse(Console.ReadLine());

            calcMedGeral(media());
        }

        public double media()
        {
            double media = 0;

            media = Notas[0] + Notas[1] + Notas[2];
            media = media / 3;

            

            return media;
        }

        private void calcMedGeral(double media)
        {
            if(MediaGeral == 0)
            {
                MediaGeral = media;
            }   
            MediaGeral = (MediaGeral + media) / 2;
        }

        public void verificaAprovacao()
        {
            if(media() >= 60)
            {
                this.Aprovacao = true;
            }
        }

        public string msgAprovacao()
        {
            verificaAprovacao();

            if(Aprovacao == true)
            {
                //Console.WriteLine($"Situação do Aluno: Aprovado");

                return "Situação do Aluno: Aprovado";
            }
            else
            {
                //Console.WriteLine($"Situação do Aluno: Reprovado");

                return "Situação do Aluno: Reprovado";
            }
        }


        public void imprime()
        {
            Console.WriteLine($"Nome: {Nome}\nCurso: {Curso}\nIdade: {Idade}\n\n1ª Nota: {Notas[0]}\n1ª Nota: {Notas[1]}\n1ª Nota: {Notas[2]}\nMédia: {media()}\n{msgAprovacao()}");

        }
        public void imprime(string tipo)
        {
            tipo = tipo.ToLower();

            if(tipo == "nome")
            {
                Console.WriteLine($"Nome: {Nome}");
            }
            if (tipo == "idade")
            {
                Console.WriteLine($"Idade: {Idade}");
            }
            if (tipo == "curso")
            {
                Console.WriteLine($"Curso: {Curso}");
            }
            if (tipo == "notas" || tipo == "nota")
            {
                Console.WriteLine($"1ª Nota: {Notas[0]}");
                Console.WriteLine($"2ª Nota: {Notas[1]}");
                Console.WriteLine($"3ª Nota: {Notas[2]}");
            }
            if (tipo == "media" || tipo == "média")
            {
                Console.WriteLine($"Média: {media()}");
            }
            if (tipo == "aprovacao" || tipo == "aprovação")
            {
                msgAprovacao();
            }
        }

        public static void imprimeMediaGeral()
        {
            Console.WriteLine($"A média geral dos alunos é: {MediaGeral}");
        }




    }


}
