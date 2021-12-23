using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            LerArquivoComReader();
            Console.ReadLine();
        }

        private static void LerArquivoComReader()
        {
            using (var fileStream = new FileStream("contas.txt", FileMode.Open))
            using (var fileReader = new StreamReader(fileStream))
            {
                while (!fileReader.EndOfStream)
                {
                    var linha = fileReader.ReadLine();
                    Console.WriteLine(linha);
                }
            }
        }
    }
}
