using System;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            ArquivoEstoque.LerArquivo();
            InitializeComponent();
            CarregarTabela();
        }

        private void button_adicionar_Click(object sender, EventArgs e)
        {
            AdicionarProduto addProduto = new AdicionarProduto();
            addProduto.ShowDialog();
            CarregarTabela();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (listView_estoque.SelectedItems.Count > 0)
            {
                ListViewItem selItem = listView_estoque.SelectedItems[0];
                index = selItem.Index;

                string message = "Tem certeza que deseja excluir o produto?";
                string caption = "Atenção";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);

                switch (result)
                {
                    case DialogResult.Yes:   // Yes button pressed
                        ArquivoEstoque.RemoverProduto(index);
                        LimparComponentes();
                        CarregarTabela();
                        ArquivoEstoque.SalvarArquivo();
                        break;
                    case DialogResult.No:    // No button pressed
                        break;
                }
            }
        }

        private void LimparComponentes()
        {
            lb_valorTotal.Text = "R$ 0,00";
            lb_dataCadastro.Text = "00/00/0000";
            textBox_descricao.Text = "";
            pictureBox_produto.Image = Imagem.Carregar("");
            pictureBox_categoria.Image = Imagem.Carregar("");
        }

        private void button_atualizar_Click(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            EditarProduto();
            CarregarTabela();
        }

        private void listView_estoque_DoubleClick(object sender, EventArgs e)
        {
            EditarProduto();
            CarregarTabela();
        }

        private void listView_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarProdutoTabela();
        }

        void CarregarProdutoTabela()
        {
            int index = 0;

            if (listView_estoque.SelectedItems.Count > 0)
            {
                ListViewItem selItem = listView_estoque.SelectedItems[0];
                index = selItem.Index;

                lb_valorTotal.Text = "R$ " + (ArquivoEstoque.ListaProdutos[index].Preco * ArquivoEstoque.ListaProdutos[index].Quantidade).ToString("F2");
                lb_dataCadastro.Text = ArquivoEstoque.ListaProdutos[index].DataCadastro.ToString();
                textBox_descricao.Text = ArquivoEstoque.ListaProdutos[index].Descricao;
                pictureBox_produto.Image = Imagem.Carregar(@"Arquivos\Imagens\Estoque\" + ArquivoEstoque.ListaProdutos[index].ID + ".png");

                if (ArquivoEstoque.ListaProdutos[index].Categoria == "Alimentos")
                {
                    pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\alimentos.png");
                }
                else if (ArquivoEstoque.ListaProdutos[index].Categoria == "Limpeza")
                {
                    pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\limpeza.png");
                }
                else if (ArquivoEstoque.ListaProdutos[index].Categoria == "Higiene pessoal")
                {
                    pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\higienePessoal.png");
                }
                else if (ArquivoEstoque.ListaProdutos[index].Categoria == "Hortifruti")
                {
                    pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\hortifruti.png");
                }
                else if (ArquivoEstoque.ListaProdutos[index].Categoria == "Outros")
                {
                    pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\outros.png");
                }

                try //Gerar código de barras do produto
                {
                    Zen.Barcode.CodeEan13BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.CodeEan13WithChecksum;
                    pB_codigoBarras.Image = brCode.Draw(ArquivoEstoque.ListaProdutos[index].ID, 60, 20);
                }
                catch
                {

                }
            }
        }

        public void CarregarTabela()
        {
            listView_estoque.Items.Clear();

            foreach (var produto in ArquivoEstoque.ListaProdutos)
            {
                string id = produto.ID;
                string categoria = produto.Categoria;
                string nome = produto.Nome;
                string preco = "R$ " + produto.Preco.ToString("F2");
                string quantidade = produto.Quantidade.ToString();
                string dataDeCadastro = produto.DataCadastro.ToString();
                string descricao = produto.Descricao;

                string[] row = { id, categoria, nome, preco, quantidade };
                var listViewItem = new ListViewItem(row);
                listView_estoque.Items.Add(listViewItem);
            }
        }

        private void EditarProduto()
        {
            int index = 0;

            if (listView_estoque.SelectedItems.Count > 0)
            {
                ListViewItem selItem = listView_estoque.SelectedItems[0];
                index = selItem.Index;

                EditarProduto editarProd = new EditarProduto(index);
                editarProd.ShowDialog();
            }
        }

        private void listView_estoque_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    ArquivoEstoque.ListaProdutos.Sort((IProduto p1, IProduto p2) => p1.ID.CompareTo(p2.ID));
                    break;

                case 1:
                    ArquivoEstoque.ListaProdutos.Sort((IProduto p1, IProduto p2) => p1.Categoria.CompareTo(p2.Categoria));
                    break;

                case 2:
                    ArquivoEstoque.ListaProdutos.Sort((IProduto p1, IProduto p2) => p1.Nome.CompareTo(p2.Nome));
                    break;

                case 3:
                    ArquivoEstoque.ListaProdutos.Sort((IProduto p1, IProduto p2) => p1.Preco.CompareTo(p2.Preco));
                    break;

                case 4:
                    ArquivoEstoque.ListaProdutos.Sort((IProduto p1, IProduto p2) => p1.Quantidade.CompareTo(p2.Quantidade));
                    break;

                default:
                    MessageBox.Show("Default");
                    break;
            }

            CarregarTabela();
        }
    }
}

