using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    partial class Program
    {
        public static void LidandoComStreamReader()
        {
            var caminhoArquivo = "contas.txt";

            using (var stream = new FileStream(caminhoArquivo, FileMode.Open))
            {
                var reader = new StreamReader(stream);

                //var texto = reader.ReadToEnd();

                //int numero = reader.Read();

                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();

                    var contaCorrente = ConverterStringParaConta(linha);

                    var msg = $"{contaCorrente.Titular.Nome}: Conta número: {contaCorrente.Numero}, ag: {contaCorrente.Agencia}, Saldo: {contaCorrente.Saldo}";


                    Console.WriteLine(msg);

                }


            }

        }

        static ContaCorrente ConverterStringParaConta(string linha)
        {
            var campos = linha.Split(',');

            var agencia = int.Parse(campos[0]);
            var numero = int.Parse(campos[1]);
            var saldo = double.Parse(campos[2].Replace('.', ','));
            var nomeDoTitular = campos[3];

            var resultado = new ContaCorrente(agencia, numero);

            resultado.Depositar(saldo);

            var titular = new Cliente();
            titular.Nome = nomeDoTitular;

            resultado.Titular = titular;


            return resultado;

        }


    }
}
