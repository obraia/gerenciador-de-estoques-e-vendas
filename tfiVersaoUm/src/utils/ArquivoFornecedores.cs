using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    class ArquivoFornecedores
    {
        public static List<Fornecedor> ListaFornecedores = new List<Fornecedor>();
        static string caminhoArquivo = @"Arquivos\fornecedores.txt";

        public static void LerArquivo()
        {
            ListaFornecedores.Clear();

            if (File.Exists(caminhoArquivo))
            {
                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        //Numero de cadastro;Nome do Fornecedor;CNPJ;Estado;CEP;Telefone;Email

                        string[] aux = linha.Split(';');

                        int numeroDeCadastro = int.Parse(aux[0]);
                        string nome = aux[1];
                        string categoria = aux[2];
                        string id = aux[3];
                        string estado = aux[4];
                        string cep = aux[5];
                        string telefone = aux[6];
                        string email = aux[7];

                        string descricao = aux[6];

                        Fornecedor fornecedor = new Fornecedor(numeroDeCadastro, nome, categoria ,id, estado, cep, telefone, email);
                        ListaFornecedores.Add(fornecedor);
                    }
                }
            }
            else
            {
                string message = "Erro ao carregar arquivo";
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
                foreach (var fornecedor in ListaFornecedores)
                {
                    sr.WriteLine(fornecedor.EscreverArquivo());
                }
            }
        }

        public static void RemoverFornecedor(int index)
        {
            File.Delete(@"Arquivos\Imagens\Fornecedores\" + ListaFornecedores[index].NumeroDeCadastro + ".png");
            ListaFornecedores.RemoveAt(index);
        }
    }
}
