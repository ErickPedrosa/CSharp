using ByteBankIO;
using System.Linq.Expressions;
using System.Text;
using System;

partial class Program
{
    static void LidandoComFileStreamDiretamente(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";


        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numBytesLidos = -1;

            var buffer = new byte[1024]; // 1KB


            while (numBytesLidos != 0)
            {
                buffer = new byte[1024];
                GC.Collect();


                numBytesLidos = fluxoDoArquivo.Read(buffer, 0, buffer.Length);
                EscreverBuffer(buffer, numBytesLidos);
            }

            fluxoDoArquivo.Close();

            Console.ReadLine();
        }




    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();
        string texto = utf8.GetString(buffer, 0, bytesLidos);

        Console.Write(texto);

        /*
        foreach (var myByte in buffer)
        {
            Console.Write(myByte);
            Console.Write(" ");
        }
        */



    }

}