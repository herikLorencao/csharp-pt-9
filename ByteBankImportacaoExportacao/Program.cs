using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileStream = new FileStream("contas.txt", FileMode.Open);
            var buffer = new byte[1024];
            var quantidadeBytesLidos = -1;

            while (quantidadeBytesLidos != 0)
            {
                quantidadeBytesLidos = fileStream.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            fileStream.Read(buffer, 0, 1024);

            Console.ReadLine();
        }

        private static void EscreverBuffer(byte[] buffer)
        {
            var encoding = Encoding.UTF8;
            var texto = encoding.GetString(buffer);

            Console.Write(texto);
        }
    }
}
