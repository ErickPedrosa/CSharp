using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    public class Porta
    {
        private bool estaTrancada = true;
        private bool estaFechada = true;

        
        public void Trancar()
        {
            if (estaFechada)
            {
                estaTrancada = true;
            }
            
        }
        public void Destrancar()
        {
            if (estaTrancada)
            {
                estaTrancada = false;
            }
        }

        public void Abrir()
        {
            if (!estaTrancada)
            {
                estaFechada = false;
            }
        }
        public void Fechar()
        {
            if (!estaFechada)
            {
                estaFechada = true;
            }
        }

        public bool EstaTrancada()
        {
            return this.estaTrancada;
        }
        
        public bool EstaFechada()
        {
            return this.estaFechada;
        }

    }
}
