using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacoes
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }
        public void Registrar(Diretor diretor)
        {
            this.totalBonificacao += diretor.getBonificacao();
        }


        public double getBonificacao()
        {

            return this.totalBonificacao;

        }
    }
}
