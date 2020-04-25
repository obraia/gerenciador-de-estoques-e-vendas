using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // Move panel

namespace tfiVersaoUm
{
    public partial class AdicionarFornecedor : Form
    {
        static string ImagemEntrada = "";
        static string ImagemSaida = "";

        // Move Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Round Window
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        // Drop Shadow
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        public AdicionarFornecedor()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            ReleaseCapture();
            CarregarFornecedor();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            int numeroDeCadastro = 0;

            if (ArquivoFornecedores.ListaFornecedores.Count == 0)
            {
                numeroDeCadastro = 1;
            }else
            {
                numeroDeCadastro = ArquivoFornecedores.ListaFornecedores[ArquivoFornecedores.ListaFornecedores.Count - 1].NumeroDeCadastro + 1;

            }

            string nome = textBoxNome.Text;
            string categoria = comboBoxCategoria.Text;
            string id = TextBoxCNPJ.Text;
            string estado = comboBoxUF.Text;
            string cep = TextBoxCEP.Text;
            string telefone = TextBoxTelefone.Text;
            string email = textBoxEmail.Text;

            if(nome != null && categoria != "Categoria" && id != null & estado != null && cep != null && telefone != null && email != null)
            {
                ImagemSaida = @"Arquivos\Imagens\Fornecedores\" + numeroDeCadastro + ".png";
                Imagem.Copiar(ImagemEntrada, ImagemSaida);
                Fornecedor fornecedor = new Fornecedor(numeroDeCadastro, nome, categoria, id, estado, cep, telefone, email);
                ArquivoFornecedores.ListaFornecedores.Add(fornecedor);

                string message = "Fornecedor adicionado com sucesso";
                string caption = "Sucesso";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                ArquivoFornecedores.SalvarArquivo();

                this.Close();
            }
            else
            {
                string message = "Preecnha todos os campos";
                string caption = "Erro";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string CEP = TextBoxCEP.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirImagem();
        }

        private void AbrirImagem()
        {
            OpenFileDialog abrirImagem = new OpenFileDialog();
            abrirImagem.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            abrirImagem.Title = "Selecione uma imagem para o produto.";
            if (abrirImagem.ShowDialog() == DialogResult.OK)
            {
                ImagemEntrada = abrirImagem.FileName;

                pictureBoxImagem.BackgroundImage = Imagem.Carregar(abrirImagem.FileName);
            }
        }

        private void CarregarFornecedor()
        {
            comboBoxCategoria.Items.Insert(0, "Categoria");
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxUF.SelectedIndex = 0;
        }

        private void buttonCarregarImg_Click(object sender, EventArgs e)
        {
            AbrirImagem();
        }
    }
}
