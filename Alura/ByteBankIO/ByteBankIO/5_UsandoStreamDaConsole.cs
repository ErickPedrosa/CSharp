using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankIO
{
    partial class Program
    {
        public static void UsarStreamDeEntrada()
        {
            using (var stream = Console.OpenStandardInput())
            using (var st = new FileStream("entradaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesLidos = stream.Read(buffer, 0, buffer.Length);

                    st.Write(buffer, 0, bytesLidos);
                    st.Flush();

                    Console.WriteLine($"Bytes Lidos na Console: {bytesLidos}");
                }
                    

            }
        }
    }
}
