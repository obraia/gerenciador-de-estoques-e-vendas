using System;
using System.IO;

namespace tfiVersaoUm
{
    class GerarArquivos
    {
        static string ArquivoEstoque = @"Arquivos\estoque.txt";
        static string ArquivoSaldo = @"Arquivos\saldo.txt";
        static string ArquivoFornecedores = @"Arquivos\fornecedores.txt";
        static string ArquivoRelatorioVendas = @"Arquivos\Relatorios\relatorioVendas.txt";
        static string ArquivoRelatorioProdutos = @"Arquivos\Relatorios\relatorioProdutos.txt";

        static string DiretorioArquivos = @"Arquivos";
        static string DiretorioImagens = @"Arquivos\Imagens";
        static string DiretorioImagensProdutos = @"Arquivos\Imagens\Estoque";
        static string DiretorioImagensCetegorias = @"Arquivos\Imagens\Categorias";
        static string DiretorioImagensFornecedores = @"Arquivos\Imagens\Fornecedores";
        static string DiretorioRelatorios = @"Arquivos\Relatorios";

        public static void GerarDiretorios()
        {
            if (!Directory.Exists(DiretorioArquivos))
            {
                Directory.CreateDirectory(DiretorioArquivos);
            }
            if (!Directory.Exists(DiretorioImagens))
            {
                Directory.CreateDirectory(DiretorioImagens);
            }
            if (!Directory.Exists(DiretorioImagensProdutos))
            {
                Directory.CreateDirectory(DiretorioImagensProdutos);
            }
            if (!Directory.Exists(DiretorioImagensCetegorias))
            {
                Directory.CreateDirectory(DiretorioImagensCetegorias);
            }
            if (!Directory.Exists(DiretorioImagensFornecedores))
            {
                Directory.CreateDirectory(DiretorioImagensFornecedores);
            }
            if (!Directory.Exists(DiretorioRelatorios))
            {
                Directory.CreateDirectory(DiretorioRelatorios);
            }
        }

        public static void GerarArquivosText()
        {
            if (!File.Exists(ArquivoEstoque))
            {
                File.Create(ArquivoEstoque);
            }
            if (!File.Exists(ArquivoSaldo))
            {
               using (StreamWriter sw = new StreamWriter(ArquivoSaldo)) { sw.Write("0"); }
            }
            if (!File.Exists(ArquivoFornecedores))
            {
                File.Create(ArquivoFornecedores);
            }
            if (!File.Exists(ArquivoRelatorioVendas))
            {
                File.Create(ArquivoRelatorioVendas);
            }
            if (!File.Exists(ArquivoRelatorioProdutos))
            {
                File.Create(ArquivoRelatorioProdutos);
            }
        }
    }
}
