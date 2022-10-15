using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    public class Data
    {
        private int dia;
        private int mes;
        private int ano;
        public int Dia { get; private set; }
        public int Mes { get; private set; }
        public int Ano { get; private set; }

        public Data(int dia, int mes, int ano)
        {
            bool diaValido, mesValido, anoValido;

            diaValido = (dia >= 1 && dia <= 31);
            mesValido = (mes >= 1 && mes <= 12);
            anoValido = (ano <= DateTime.Now.Year);

            if (diaValido && mesValido && anoValido)
            {
                this.Dia = dia;
                this.Mes = mes;
                this.Ano = ano;
            }
            else
            {
                this.Dia = DateTime.Now.Day;
                this.Mes = DateTime.Now.Month;
                this.Ano = DateTime.Now.Year;

            }
            
        }

        public Data()
        {
            int dia = 0, mes = 0, ano = 0;


            do
            {
                Console.WriteLine("Digite o dia:");
                dia = int.Parse(Console.ReadLine());
            } while (dia < 1 || dia > 31);

            do {
                Console.WriteLine("Digite o mes:");
                mes = int.Parse(Console.ReadLine());
            } while (mes < 1 || mes > 12);

            do {
                Console.WriteLine("Digite o ano:");
                ano = int.Parse(Console.ReadLine());
            }while (ano > DateTime.Now.Year);

            this.Dia = dia;
            this.Mes = mes;
            this.Ano = ano;
        }

        public string DataAtual()
        {
            return ($"{Dia}/{Mes}/{Ano}");
        }

        public void ImprimeData()
        {
            Console.WriteLine(this.DataAtual());
        }

    }
}
