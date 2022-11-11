using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prova
{

    public class Program
    {

        public static void Main(string[] args)
        {


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

            //System.Console.WriteLine($"Quantidade de usuários de InstaPet: {instapet.QntUsuarios()}");

            int qntPets = instapet.QntPets("juju@gmail.com");
            //System.Console.WriteLine($"Quantidade de pets/fotos de juju@gmail.com: {qntPets}\n\n");

            instapet.AlteraDescricao("erick.pedrosa.b@gmail.com", 3, "Nova Descrição");

            //instapet.ImprimePets("kaioffn@gmail.com");
            //instapet.ImprimePets("juju@gmail.com");
            //instapet.ImprimePets("erick.pedrosa.b@gmail.com");

            instapet.ImprimeUsuarios();

            Usuario[] usuarios = instapet.ListarUsuarios();
            Fotos[] fotos = instapet.ListarPets("juju@gmail.com");

            /*
            for(int i = 0; i < usuarios.Length; i++){
                System.Console.WriteLine($"Usuário {i}:");
                usuarios[i].Imprime();
            }
            
            for(int i = 0; i < fotos.Length; i++)
            {
                System.Console.WriteLine($"Foto {i}: ");
                fotos[i].Mostra();

                
            }
            */

        }


    }




}
