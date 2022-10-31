using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadoLetivoAtv6
{
    public class Avaliacao
    {
        private int trimestre;
        private double nota;
        private int id;

        public int Trimestre { get; set; }
        public double Nota { get; set; }
        public int Id { get; set; }
        

        public Avaliacao(int trimestre, double nota, int id)
        {
            this.Trimestre = trimestre;
            this.Nota = nota;
            this.Id = id;
        }
    }

}
