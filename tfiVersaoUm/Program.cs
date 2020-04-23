using System;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GerarArquivos.GerarDiretorios();
            GerarArquivos.GerarArquivosText();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
