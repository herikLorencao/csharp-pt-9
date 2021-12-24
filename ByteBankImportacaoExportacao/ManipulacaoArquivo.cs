using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        private static void LerArquivoComReader()
        {
            using (var fileStream = new FileStream("contas.txt", FileMode.Open))
            using (var fileReader = new StreamReader(fileStream))
            {
                while (!fileReader.EndOfStream)
                {
                    var linha = fileReader.ReadLine();
                    EscreverArquivoComWriter(linha);
                }
            }
        }

        private static void EscreverArquivoComWriter(string linha)
        {
            using (var fileStream = new FileStream("contasExportadas.csv", FileMode.Create))
            using (var writter = new StreamWriter(fileStream))
            {
                writter.WriteLine(linha);
            }

            Console.WriteLine("Arquivo criado com sucesso ...");
        }

        private static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(' ');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var agenciaComInt = int.Parse(agencia);
            var numeroComInt = int.Parse(numero);
            var saldoDouble = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var conta = new ContaCorrente(agenciaComInt, numeroComInt);
            conta.Depositar(saldoDouble);
            conta.Titular = titular;

            return conta;
        }

        private static void EscreverComFlush()
        {
            using (var fileStream = new FileStream("flushTeste.txt", FileMode.Create))
            using (var writter = new StreamWriter(fileStream))
            {
                for (int i = 0; i < 10; i++)
                {
                    writter.WriteLine($"Linha {i}");
                    writter.Flush();

                    Console.WriteLine($"Linha {i} adicionada.");
                    Console.WriteLine("Tecle enter para continuar ...");

                    Console.ReadLine();
                }
            }
        }
    }
}
