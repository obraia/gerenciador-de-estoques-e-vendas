using System;
using System.Collections.Generic;
using System.IO;

namespace tfiVersaoUm
{
    class ArquivoVenda
    {
        public static List<RelatorioVendas> ListaRelatorios = new List<RelatorioVendas>();
        static string relatorioVendas = @"Arquivos\Relatorios\relatorioVendas.txt";
        static string relatorioProdutos = @"Arquivos\Relatorios\relatorioProdutos.txt";

        public static void LerRelatorioVendas()
        {
            if (File.Exists(relatorioVendas))
            {
                using (StreamReader sr = new StreamReader(relatorioVendas))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        string[] aux = linha.Split(';');
                        double valor = double.Parse(aux[0]);
                        DateTime data = DateTime.Parse(aux[1]);
                        RelatorioVendas relatorio = new RelatorioVendas(valor, data);
                        ListaRelatorios.Add(relatorio);
                    }
                }
            }
        }

        public static void GerarRelatorioProdutos(List<IProduto> lista)
        {
            using (StreamWriter sw = new StreamWriter(relatorioProdutos))
                foreach (IProduto produto in lista)
                {
                    if (produto.TipoVenda != "Quilo")
                    {
                        string codigo = produto._id.ToString();
                        string nome = produto.Nome;
                        double quantidadeVendida = produto.QuantidadeComprada;
                        string linha = codigo + ";" + nome + ";" + quantidadeVendida;
                        sw.WriteLine();
                    }
                }
        }

        public static void GerarRelatorioVendas(double valorTotal, DateTime dataDaVenda)
        {
            using (StreamWriter sr = File.AppendText(relatorioVendas))
            {
                sr.WriteLine(valorTotal.ToString("F2") + ";" + dataDaVenda);
            }
        }

        public static void GerarNotaFiscal(List<IProduto> lista, double valorTotal, string arquivoNota)
        {
            using (StreamWriter sr = new StreamWriter(arquivoNota))
            {
                sr.WriteLine();
                sr.WriteLine("---------- PUC MARKET ----------");
                sr.WriteLine();
                foreach (IProduto produto in lista)
                {
                    string linha = produto.Nome + " - Quantidade: " + produto.QuantidadeComprada + " - Valor da unidade: R$ " + produto.Preco.ToString("F2");
                    sr.WriteLine(linha);
                }
                sr.WriteLine();
                sr.WriteLine("Valor total da compra: R$ " + valorTotal.ToString("F2"));
                sr.WriteLine();
                sr.WriteLine("----------------------------------");

            }
        }
    }
}
