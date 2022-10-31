using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadoLetivoAtv6
{
    public class Professor
    {
        private string nome;
        private string escolaridade;
        private int matricula;
        private int numDisciplinas;
        private Disciplina[] disciplinas;

        public string Nome { get; set; }
        public string Escolaridade { get; set; }
        public int Matricula { get; set; }
        public int NumDisciplinas { get; set; }
        public Disciplina[] Disciplinas {
            get
            {
                return this.disciplinas;
            }
            set
            {
                if(value.Length == numDisciplinas)
                {
                    this.disciplinas = value;
                }
            }
        }


        public Professor(int numDisciplinas)
        {
            this.NumDisciplinas = numDisciplinas;

            Disciplinas = new Disciplina[NumDisciplinas];
        }

        public Professor()
        {

        }

        public void AdicionaDisciplina(Disciplina disciplina)
        {
            if(Disciplinas == null)
            {
                NumDisciplinas = 1;
                Disciplinas = new Disciplina[NumDisciplinas];

                Disciplinas[0] = disciplina;
            }
            else
            {
                NumDisciplinas++;

                Disciplina[] disciplinasBuff = new Disciplina[NumDisciplinas];

                for (int i = 0; i < (NumDisciplinas - 1); i++)
                {
                    disciplinasBuff[i] = Disciplinas[i];
                }
                disciplinasBuff[NumDisciplinas - 1] = disciplina;

                Disciplinas = disciplinasBuff;

            }
        }
    
    
    
    
    
    
    
    
    }
}
