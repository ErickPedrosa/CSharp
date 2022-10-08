using ByteBankIO;
using System.Linq.Expressions;
using System.Text;
using System;

partial class Program
{
    static void Main(string[] args)
    {
        var caminhoArquivo = "contas.txt";

        using(var stream = new FileStream(caminhoArquivo, FileMode.Open))
        {
            var reader = new StreamReader(stream);

            //var texto = reader.ReadToEnd();

            //int numero = reader.Read();

            while (!reader.EndOfStream)
            {
                var linha = reader.ReadLine();


                Console.WriteLine(linha);

            }


        }
        

        Console.ReadLine();
    }
        
               

}