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
        private static void EscreverBinario()
        {
            using (var fileStream = new FileStream("binario.txt", FileMode.Create))
            using (var writter = new BinaryWriter(fileStream))
            {
                writter.Write(100);
                writter.Write(12905);
                writter.Write(4000.50);
                writter.Write("João da Silva");
            }

            Console.WriteLine("Escrita realizada com sucesso, tecle enter para finalizar ...");
        }

        private static void LerBinario()
        {
            using (var fileStream = new FileStream("binario.txt", FileMode.Open))
            using (var reader = new BinaryReader(fileStream))
            {
                var agencia = reader.ReadInt32();
                var numero = reader.ReadInt32();
                var saldo = reader.ReadDouble();
                var titular = reader.ReadString();

                Console.WriteLine($"Ag.: {agencia} | Número: {numero} | Saldo: {saldo} | Titular: {titular}");
            }

            Console.WriteLine("Leitura realizada com sucesso, tecle enter para finalizar ...");
        }
    }
}
