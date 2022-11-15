using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    partial class Program
    {
        public static void EscritaBinaria()
        {
            var caminhoArquivo = "contaCorrente.txt";

            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(456);
                writer.Write(789546);
                writer.Write(19.85);
                writer.Write("Gustavo Pereira");

            }
            
        }
        public static void LeituraBinaria()
        {
            var caminhoArquivo = "contaCorrente.txt";

            using (var stream = new FileStream(caminhoArquivo, FileMode.Open))
            using (var reader = new BinaryReader(stream))
            {
                var agencia = reader.ReadInt32();
                var numeroConta = reader.ReadInt32();
                var saldo = reader.ReadDouble();
                var titular = reader.ReadString();

                Console.WriteLine($"ag: {agencia} / Num. Conta: {numeroConta} / Saldo: {saldo} / Titular: {titular}");
            }
        }

    }
}
