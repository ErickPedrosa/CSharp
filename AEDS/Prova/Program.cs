using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prova{

    public class Program
    {
        public static void Main(string[] args){


            InstaPet instapet = new InstaPet();

            instapet.CadastraUsuario("Erick Pedrosa", "erick.pedrosa.b@gmail.com");
            instapet.CadastraUsuario("Júlia Almeida", "juju@gmail.com");
            instapet.CadastraUsuario("Kaio Fernandes", "kaioffn@gmail.com");

            instapet.CadastraFoto("juju@gmail.com", "www.foto1.com", "foto 1");
            instapet.CadastraFoto("juju@gmail.com", "www.foto2.com", "foto 2");
            instapet.CadastraFoto("juju@gmail.com", "www.foto3.com", "foto 3");
            instapet.CadastraFoto("kaioffn@gmail.com", "www.foto4.com", "foto 4");
            instapet.CadastraFoto("kaioffn@gmail.com", "www.foto5.com", "foto 5");
            instapet.CadastraFoto("kaioffn@gmail.com", "www.foto6.com", "foto 6");
            instapet.CadastraFoto("erick.pedrosa.b@gmail.com", "www.foto7.com", "foto 7");
            instapet.CadastraFoto("erick.pedrosa.b@gmail.com", "www.foto8.com", "foto 8");
            instapet.CadastraFoto("erick.pedrosa.b@gmail.com", "www.foto9.com", "foto 9");
        
            instapet.
        
        }

    }

}