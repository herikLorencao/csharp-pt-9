using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        private static void LerDadosConsole()
        {
            Console.WriteLine("Digite algum valor no console:");

            using (var consoleStream = Console.OpenStandardInput())
            using (var fs = new FileStream("saidaConsole.txt", FileMode.Create))
            {
                var buffer = new byte[1024];

                while (true)
                {
                    var bytesLidos = consoleStream.Read(buffer, 0, buffer.Length);
                    
                    fs.Write(buffer, 0, buffer.Length);
                    fs.Flush();

                    Console.WriteLine($"Bytes lidos do console: {bytesLidos}");
                }
            }
        }
    }
}
