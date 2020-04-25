using System;
using System.IO;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    class ArquivoFinanceiro
    {
        static string caminhoArquivoSaldo = @"Arquivos\saldo.txt";

        public static double LerArquivoSaldo()
        {
            double saldo = 0;
            try
            {
                if (File.Exists(caminhoArquivoSaldo))
                {
                    using (StreamReader sr = new StreamReader(caminhoArquivoSaldo))
                    {
                        string linha = sr.ReadLine();
                        string[] aux = linha.Split(';');

                        for (int i = 0; i < aux.Length; i++)
                        {
                            saldo += double.Parse(aux[i]);
                        }     
                    }
                }
                else
                {
                    string message = "Arquivo do saldo não encontrado";
                    string caption = "Erro";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
            catch
            {
                string message = "Erro ao carregar saldo";
                string caption = "Erro";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }

            return saldo;
        }

        public static void SalvarSaldo(double saldo)
        {
            using (StreamWriter sr = File.AppendText(caminhoArquivoSaldo))
            {
                sr.Write(";"+saldo);
            }
        }

    }
}
