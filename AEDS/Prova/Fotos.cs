using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prova{

    public class Fotos{

        private string url;
        private string descricao;
        

        public string Url { get; set; }
        public string Descricao { get; set; }

        public Fotos(string url, string descricao){
            this.Url = url;
            this.Descricao = descricao;

        }
        
        public void Mostra(){

            System.Console.WriteLine($"URL: {Url}");
            System.Console.WriteLine($"Descrição: {Descricao}");

        }
    }

}