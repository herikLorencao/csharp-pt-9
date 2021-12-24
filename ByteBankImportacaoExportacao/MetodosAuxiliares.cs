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
        private static void LeituraEscritaAuxiliares()
        {
            File.WriteAllText("auxiliar.txt", "Conteúdo completo do arquivo");
            Console.WriteLine("Escrita do arquivo auxiliar.txt realizada!");

            var bytes = File.ReadAllBytes("binario.txt");
            Console.WriteLine($"Arquivo contas possui: {bytes.Length} bytes");

            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);
        }
    }
}
