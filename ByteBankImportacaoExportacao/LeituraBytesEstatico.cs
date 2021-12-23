using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        private static void LerBufferEstatico()
        {
            var fileStream = new FileStream("contas.txt", FileMode.Open);
            var buffer = new byte[1024];
            var quantidadeBytesLidos = -1;

            while (quantidadeBytesLidos != 0)
            {
                quantidadeBytesLidos = fileStream.Read(buffer, 0, 1024);
                EscreverBuffer(buffer, quantidadeBytesLidos);
            }

            fileStream.Read(buffer, 0, 1024);
        }
        private static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var encoding = Encoding.UTF8;
            var texto = encoding.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);
        }
    }
}
