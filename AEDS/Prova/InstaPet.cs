using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prova{

    public class InstaPet{

        private Usuario[] user;
        private int NumUsuarios;

        public Usuario[] User{ get; set; }

        public InstaPet(){
            NumUsuarios = 0;
        }


        public void CadastraUsuario(string nome, string email){
            Usuario usuario = new Usuario(nome, email);

            if (user == null)
            {
                user = new Usuario[1];
                user[0] = usuario;
            }
            else
            {
                Usuario[] userBuff = new Usuario[user.Length + 1];

                for (int i = 0; i < user.Length; i++)
                {
                    userBuff[i] = user[i];
                }
                userBuff[user.Length] = usuario;

                user = userBuff;
            }

            NumUsuarios++;
        }

        public void CadastraFoto(string email, string url, string desc){

            for(int i = 0; i < user.Length; i++){
                if(user[i].Email == email){

                    user[i].CadastraFoto(url, desc);

                }
            }


        }

        public int QntPets(string email){
            for(int i = 0; i < user.Length; i++){
                if(user[i].Email == email){
                    return user[i].NumPets; 
                }
            }
            return (-1);
        }

        public int QntUsuarios(){
            return NumUsuarios;
        }

        public Fotos[] ListarPets(string email){
            

            for(int i = 0; i < user.Length; i++){
                if(user[i].Email == email){

                    return user[i].Pict;

                }
            }
            
            return null;
        }

        public void ImprimePets(string email){

            for(int i = 0; i < user.Length; i++){

                if(user[i].Email == email){

                    user[i].ImprimePets();
                    
                }
                
            }
        }

        public Usuario[] ListarUsuarios(){

            return User;

        }

        public void ImprimeUsuarios(){

            int i = 1;
            foreach (Usuario u in user)
            {
                System.Console.WriteLine($"Usuário {i}:");
                u.Imprime();

                i++;
            }
            
        }

        public void AlteraDescricao(string email, int n, string desc){

            for(int i = 0; i < user.Length; i++){

                if(user[i].Email == email){

                    user[i].AlteraDescricao(n, desc);
                    
                }
                
            }


        }



    }

}