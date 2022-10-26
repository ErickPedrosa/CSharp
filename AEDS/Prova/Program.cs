using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prova{

    public class Program
    {
        public static void Main(string[] args){


            Usuario user = new Usuario("Erick", "2021951140@teiacoltec.org");

            user.CadastraFoto("A", "AAA");
            user.CadastraFoto("B", "BBB");
            user.CadastraFoto("B", "CCC");

            user.AlteraDescricao(2, "DDD");
            
            user.Imprime();
        }

    }

}