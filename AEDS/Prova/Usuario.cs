using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova{

    public class Usuario{

        private Fotos[] pict;
        private string nome;
        private string email;

        public Fotos[] Pict { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public void CadastraFoto(string link, string desc){
            Fotos foto = new Fotos(link, desc);
            
            if(this.pict == null){

                this.pict = new Fotos[1];
                this.pict[0] = foto;

            }
            else
            {
                Fotos[] fotosBuff = new Fotos[pict.Length + 1];

                for (int i = 0; i < pict.Length; i++)
                {
                    fotosBuff[i] = pict[i];
                }
                fotosBuff[pict.Length] = foto;

                pict = fotosBuff;
            }

        }

        public void AlteraDescricao(int n, string novaDesc){

            pict[n - 1].Descricao = novaDesc;
        
        }

        public Usuario(string nome, string email){
            this.Nome = nome;
            this.Email = email;
        }

        public void Imprime(){
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Email: {Email}");
            
            int i = 1;
            foreach (Fotos f in pict)
            {
                System.Console.WriteLine($"Foto {i}: ");
                f.Mostra();

                i++;
            }

        }


    }

}