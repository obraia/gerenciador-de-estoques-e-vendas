using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices; // Round window
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    public partial class EditarProduto : Form
    {
        static string ImagemEntrada = "";
        static string ImagemSaida = "";
        static int Index;

        // Move Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Move Panel
        private void panel_move_MouseMove(object sender, MouseEventArgs e)
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

        public EditarProduto(int index)
        {
            Index = index;
            InitializeComponent();
            CarregarProduto();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            ImagemEntrada = @"Arquivos\Estoque\Imagens\" + ArquivoEstoque.ListaProdutos[Index].CodigoBarras + ".png";
            ImagemSaida = @"Arquivos\Estoque\Imagens\" + ArquivoEstoque.ListaProdutos[Index].CodigoBarras + ".png";
        }

        private void button_abrirImagem_Click(object sender, EventArgs e)
        {
            AbrirImagem();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_imagem_Click(object sender, EventArgs e)
        {
            AbrirImagem();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoController produtoController = new ProdutoController();

                IProduto produto;
                string codigo = textBox_id.Text;
                string categoria = comboBox_categoria.Text;
                string nome = textBox_nome.Text;
                double preco = double.Parse(textBox_preco.Text);
                double quantidade = double.Parse(textBox_quantidade.Text);
                DateTime dataCadastro = DateTime.Now;
                string descricao = textBox_descricao.Text;

                if (categoria != "" && nome != "" && descricao != "")
                {
                    if (ImagemEntrada != ImagemSaida)
                    {
                        Imagem.Copiar(ImagemEntrada, ImagemSaida);
                    }

                    switch (categoria)
                    {
                        case "Alimentos":
                            produto = new Alimento(codigo, nome, preco, (int)quantidade, 0, dataCadastro, descricao);
                            break;
                        case "Limpeza":
                            produto = new Limpeza(codigo, nome, preco, (int)quantidade, 0, dataCadastro, descricao);
                            break;
                        case "Higiene pessoal":
                            produto = new HigienePessoal(codigo, nome, preco, (int)quantidade, 0, dataCadastro, descricao);
                            break;
                        case "Hortifruti":
                        produto = new Limpeza(codigo, nome, preco, (int)quantidade, 0, dataCadastro, descricao);
                            break;

                        default:
                            produto = new Outros(codigo, nome, preco, (int)quantidade, (int)quantidade, dataCadastro, descricao);
                            break;
                    }

                    int response = produtoController.Update(produto);
             
                    if(response > 0)
                    {
                        ArquivoEstoque.ListaProdutos[Index] = produto;

                        string message = "Produto editado com sucesso";
                        string caption = "Sucesso";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        ArquivoEstoque.SalvarArquivo();
                        this.Close();
                    }
                    else
                    {
                        string message = "Ocorreu algum erro ao tentar editar o produto";
                        string caption = "Erro";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    }
                                        
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
            catch (Exception b)
            {
                string message = b.Message;//"Preencha todos os campos de forma válida";
                string caption = "Erro";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }

        }

        private void CarregarProduto()
        {
            textBox_nome.Text = ArquivoEstoque.ListaProdutos[Index].Nome;
            textBox_id.Text = ArquivoEstoque.ListaProdutos[Index].CodigoBarras;
            textBox_quantidade.Text = ArquivoEstoque.ListaProdutos[Index].Quantidade.ToString();
            textBox_preco.Text = ArquivoEstoque.ListaProdutos[Index].Preco.ToString("F2");
            textBox_descricao.Text = ArquivoEstoque.ListaProdutos[Index].Descricao;
            pictureBox_imagem.BackgroundImage = Imagem.Carregar(@"Arquivos\Imagens\Estoque\" + ArquivoEstoque.ListaProdutos[Index].CodigoBarras + ".png");

            if (ArquivoEstoque.ListaProdutos[Index].Categoria == "Alimentos")
            {
                comboBox_categoria.SelectedIndex = 0;
            }
            else if (ArquivoEstoque.ListaProdutos[Index].Categoria == "Higiene pessoal")
            {
                comboBox_categoria.SelectedIndex = 1;
            }
            else if (ArquivoEstoque.ListaProdutos[Index].Categoria == "Hortifruti")
            {
                comboBox_categoria.SelectedIndex = 2;
            }
            else if (ArquivoEstoque.ListaProdutos[Index].Categoria == "Limpeza")
            {
                comboBox_categoria.SelectedIndex = 3;
            }
            else if (ArquivoEstoque.ListaProdutos[Index].Categoria == "Outros")
            {
                comboBox_categoria.SelectedIndex = 4;
            }
        }

        private void AbrirImagem()
        {
            OpenFileDialog abrirImagem = new OpenFileDialog();
            abrirImagem.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            abrirImagem.Title = "Selecione uma imagem para o produto.";
            if (abrirImagem.ShowDialog() == DialogResult.OK)
            {
                ImagemEntrada = abrirImagem.FileName;
                pictureBox_imagem.BackgroundImage = Imagem.Carregar(abrirImagem.FileName);
            }
        }

    }
}
