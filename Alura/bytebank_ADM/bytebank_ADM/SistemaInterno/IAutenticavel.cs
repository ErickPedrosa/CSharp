using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {

        public bool Autenticar(string senha);


    }
}
