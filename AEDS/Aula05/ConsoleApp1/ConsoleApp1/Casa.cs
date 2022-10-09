using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05
{
    public class Casa
    {
        private string cor = "";
        private int totalDePortas;
        public Porta[] portas;

        
        public string Cor { 
            get {
                return this.cor; 
            } 
            private set
            {

            }
        }
        
        public Casa()
        {
            
        }

        public Casa(string cor, Porta[] portas)
        {
            this.portas = new Porta[portas.Length];

            this.cor = cor;
            this.totalDePortas = portas.Length;
            this.portas = portas;
        }


        public void Pinta(string cor)
        {
            this.cor = cor;
        }

        public void AdicionaPorta(Porta porta)
        {
            if (portas == null)
            {
                portas = new Porta[1];
                portas[0] = porta;

                totalDePortas = 1;
            }
            else
            {
                totalDePortas++;

                Porta[] portasBuf = new Porta[totalDePortas];

                for (int i = 0; i < (totalDePortas - 1); i++)
                {
                    portasBuf[i] = portas[i];
                }
                portasBuf[totalDePortas - 1] = porta;

                portas = portasBuf;
            }
        }

        public int TotalPortasAbertas()
        {
            int total = 0;

            foreach(Porta porta in portas)
            {
                if (!(porta.EstaFechada()))
                {
                    total++;
                }
            }

            return total;
        }
        public int TotalPortas()
        {
            return this.totalDePortas;
        }
    }
}
