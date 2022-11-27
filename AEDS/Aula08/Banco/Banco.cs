using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    public class Banco
    {
        private Conta[] contas;

        public Conta[] Contas { get { return contas; } }

        public void Adicionar(Conta c)
        {
            if (contas == null)
            {
                contas = new Conta[1];
                contas[0] = c;

            }
            else
            {

                Conta[] contasBuf = new Conta[contas.Length + 1];

                for (int i = 0; i < (contas.Length); i++)
                {
                    contasBuf[i] = contas[i];
                }
                contasBuf[contas.Length] = c;

                contas = contasBuf;
            }
        }
        public Conta RetornaConta(int x)
        {
            return contas[x];
        }
        public int TotalDeContas()
        {
            return contas.Length;
        }

    }
}
