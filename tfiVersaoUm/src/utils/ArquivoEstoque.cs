using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    class ArquivoEstoque
    {
        public static List<IProduto> ListaProdutos = new List<IProduto>();
        static string caminhoArquivo = @"Arquivos\estoque.txt";

        public static void LerArquivo()
        {
            ListaProdutos.Clear();

            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    using (StreamReader sr = new StreamReader(caminhoArquivo))
                    {
                        while (!sr.EndOfStream)
                        {
                            string linha = sr.ReadLine();

                            IProduto produto;

                            string[] aux = linha.Split(';');
                            long codigoBarras = long.Parse(aux[0]);
                            string categoria = aux[1];
                            string nome = aux[2];
                            double preco = double.Parse(aux[3]);
                            double quantidade = double.Parse(aux[4]);
                            double quantidadeVendida = double.Parse(aux[5]);
                            DateTime dataDeCadastro = DateTime.Parse(aux[6]);
                            string descricao = aux[7];

                            switch (categoria)
                            {
                                case "Alimentos":
                                    produto = new Alimento(codigoBarras, nome, preco, (int)quantidade, (int)quantidadeVendida, dataDeCadastro, descricao);
                                    break;
                                case "Limpeza":
                                    produto = new Limpeza(codigoBarras, nome, preco, (int)quantidade, (int)quantidadeVendida, dataDeCadastro, descricao);
                                    break;
                                case "Higiene pessoal":
                                    produto = new HigienePessoal(codigoBarras, nome, preco, (int)quantidade, (int)quantidadeVendida, dataDeCadastro, descricao);
                                    break;
                                case "Hortifruti":
                                    produto = new Hortifruti(codigoBarras, nome, preco, quantidade, quantidadeVendida, dataDeCadastro, descricao);
                                    break;

                                default:
                                    produto = new Outros(codigoBarras, nome, preco, (int)quantidade, (int)quantidadeVendida, dataDeCadastro, descricao);
                                    break;
                            }

                            ListaProdutos.Add(produto);
                        }
                    }
                }
                else
                {
                    string message = "Arquivo do estoque não encontrado";
                    string caption = "Erro";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
            catch
            {
                string message = "Erro ao carregar estoque";
                string caption = "Erro";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }

        }

        public static void SalvarArquivo()
        {
            using (StreamWriter sr = new StreamWriter(caminhoArquivo))
            {
                foreach (var produto in ListaProdutos)
                {
                    sr.WriteLine(produto.EscreverArquivo());
                }
            }
        }

        public static void RemoverProduto(int index)
        {
            File.Delete(@"Arquivos\Imagens\Estoque\" + ListaProdutos[index]._id.ToString() + ".png");
            ListaProdutos.RemoveAt(index);
        }

    }
}
