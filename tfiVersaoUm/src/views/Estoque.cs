using System;
using System.Drawing;
using System.Windows.Forms;
using MongoDB.Bson.Serialization;

namespace tfiVersaoUm
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            BsonClassMap.RegisterClassMap<Alimento>();
            BsonClassMap.RegisterClassMap<HigienePessoal>();
            BsonClassMap.RegisterClassMap<Hortifruti>();
            BsonClassMap.RegisterClassMap<Limpeza>();
            BsonClassMap.RegisterClassMap<Outros>();

            ProdutoController produtoController = new ProdutoController();
            ArquivoEstoque.ListaProdutos = produtoController.Index();

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
                    case DialogResult.Yes:
                        RemoverProduto(index);
                        LimparComponentes();
                        CarregarTabela();
                        ArquivoEstoque.SalvarArquivo();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void RemoverProduto(int index)
        {
            ProdutoController produtoController = new ProdutoController();

            IProduto produto = ArquivoEstoque.ListaProdutos[index];

            int response = produtoController.Delete(produto);

            if (response > 0)
            {
                ArquivoEstoque.RemoverProduto(index);

                string message = "Produto excluido com sucesso";
                string caption = "Sucesso";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
            }
            else
            {
                string message = "Ocorreu algum erro ao tentar excluir o produto";
                string caption = "Erro";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
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
            string categoria;

            if (listView_estoque.SelectedItems.Count > 0)
            {
                ListViewItem selItem = listView_estoque.SelectedItems[0];
                index = selItem.Index;

                lb_valorTotal.Text = "R$ " + (ArquivoEstoque.ListaProdutos[index].Preco * ArquivoEstoque.ListaProdutos[index].Quantidade).ToString("F2");
                lb_dataCadastro.Text = ArquivoEstoque.ListaProdutos[index].DataCadastro.ToString();
                textBox_descricao.Text = ArquivoEstoque.ListaProdutos[index].Descricao;
                pictureBox_produto.Image = Imagem.Carregar(@"Arquivos\Imagens\Estoque\" + Id.ToString(ArquivoEstoque.ListaProdutos[index]._id) + ".png");

                categoria = ArquivoEstoque.ListaProdutos[index].Categoria;

                switch (categoria)
                {
                    case "Alimentos":
                        pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\alimentos.png");
                        break;
                    case "Limpeza":
                        pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\limpeza.png");
                        break;
                    case "Higiene pessoal":
                        pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\higienePessoal.png");
                        break;
                    case "Hortifruti":
                        pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\hortifruti.png");
                        break;

                    default:
                        pictureBox_categoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\outros.png");
                        break;
                }

                try //Gerar código de barras do produto
                {
                    Zen.Barcode.CodeEan13BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.CodeEan13WithChecksum;
                    pB_codigoBarras.Image = brCode.Draw(Id.ToString(ArquivoEstoque.ListaProdutos[index]._id), 60, 20);
                }
                catch { }
            }
        }

        public void CarregarTabela()
        {
            listView_estoque.Items.Clear();

            foreach (var produto in ArquivoEstoque.ListaProdutos)
            {
                string codigoBarras = Id.ToString(produto._id);
                string categoria = produto.Categoria;
                string nome = produto.Nome;
                string preco = "R$ " + produto.Preco.ToString("F2");
                string quantidade = produto.Quantidade.ToString();
                string dataDeCadastro = produto.DataCadastro.ToString();
                string descricao = produto.Descricao;

                string[] row = { codigoBarras, categoria, nome, preco, quantidade };
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
                index = listView_estoque.SelectedItems[0].Index;

                EditarProduto editarProduto = new EditarProduto(index);
                editarProduto.ShowDialog();
            }
            else
            {
                string message = "Nenhum produto selecionado para edição";
                string caption = "Atenção";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);
            }
        }

        private void listView_estoque_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    ArquivoEstoque.ListaProdutos.Sort((IProduto p1, IProduto p2) => p1._id.ToString().CompareTo(p2._id.ToString()));
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
                    break;
            }

            CarregarTabela();
        }
    }
}

