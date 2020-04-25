using System;
using System.Drawing;
using System.IO;

namespace tfiVersaoUm
{
    public class Imagem
    {
        // carrega uma imagem para a memória
        public static Bitmap Carregar(string caminho)
        {
            if (File.Exists(caminho))
            {
                byte[] imageByte = File.ReadAllBytes(caminho);
                MemoryStream mStream = new MemoryStream();
                mStream.Write(imageByte, 0, Convert.ToInt32(imageByte.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            else
            {
                Bitmap bmp = new Bitmap(100, 100);
                using (Graphics graph = Graphics.FromImage(bmp))
                {
                    Rectangle ImageSize = new Rectangle(0, 0, 100, 100);
                    graph.FillRectangle(Brushes.White, ImageSize);
                }
                return bmp;
            }

        }

        public static void Copiar(string entradaImg, string saidaImg)
        {
            FileInfo fi = new FileInfo(entradaImg);
            Stream entrada = File.Open(entradaImg, FileMode.Open);
            Stream saida = File.Open(saidaImg, FileMode.Create);

            for (int i = 0; i < fi.Length; i++)
            {
                int b = entrada.ReadByte();
                saida.WriteByte((byte)b);
            }

            entrada.Close();
            saida.Close();
        }
    }
}
