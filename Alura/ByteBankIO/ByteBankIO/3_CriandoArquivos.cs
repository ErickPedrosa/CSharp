using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoArquivo = "contasExportadas.csv";

            using(var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                var contaString = "456, 7895, 4785.40, Gustavo Santos";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaString);

                stream.Write(bytes, 0, bytes.Length);
            }

        }

        static void CriarArquivoComWriter()
        {
            var caminhoArquivo = "contasExportadas.csv";

            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                writer.Write("652,45612,856.45,Pedro");
            }
            
        }

        static void TestaEscrita()
        {
            var caminhoArquivo = "teste.txt";

            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            using (var writer = new StreamWriter(stream))
            {
                for (int i = 0; i < 1000; i++)
                {
                    writer.WriteLine($"Linha {i}");
                    writer.Flush(); //Persiste o Buffer no Stream;
                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                    /*if(i%5 == 0)
                    {
                        writer.Flush();
                    }*/
                    
                    Console.ReadLine();
                }
                
            }
        }


    }

}
