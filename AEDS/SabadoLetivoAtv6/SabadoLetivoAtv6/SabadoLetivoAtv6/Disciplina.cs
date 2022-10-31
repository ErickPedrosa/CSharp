using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadoLetivoAtv6
{
    public class Disciplina
    {
        private static int numAvaliacoes = 2;

        private string nome;
        private string descricao;
        private int numAlunos;

        private Professor[] professores;
        private Avaliacao[] avaliacoes = new Avaliacao[numAvaliacoes];


        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int NumAlunos { get; set; }
        public Professor[] Professores { get; set; }

        public Disciplina()
        {
            
        }
    }
}
