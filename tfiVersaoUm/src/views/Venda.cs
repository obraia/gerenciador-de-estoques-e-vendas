using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    public partial class Venda : Form
    {

        static List<IProduto> ListaCompra = new List<IProduto>();
        static double ValorTotal = 0;
        static double ValorTotalSemImposto = 0;

        public Venda()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string codigoDeBarras = textBoxCodigoBarras.Text;

            if (codigoDeBarras.Length > 12)
            {
                codigoDeBarras = codigoDeBarras.Substring(0, 12);
            }

            textBoxCodigoBarras.Text = "";

            AdicionarProduto(codigoDeBarras);
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            if (ListaCompra.Count > 0)
            {
                string message = "Deseja confirmar a compra?";
                string caption = "Confirmar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                switch (result)
                {
                    case DialogResult.Yes:   // Yes button pressed
                        ConfirmarCompra();
                        break;
                    case DialogResult.No:    // No button pressed
                        break;
                }
            }
            else
            {
                string message = "Adicione algum produto a compra";
                string caption = "Erro";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            string message = "Deseja limpar a lista de compra?";
            string caption = "Limpar lista";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);

            switch (result)
            {
                case DialogResult.Yes:   // Yes button pressed
                    LimparLista();
                    LimparCampos();
                    ArquivoEstoque.LerArquivo();
                    break;
                case DialogResult.No:    // No button pressed
                    break;
            }
        }

        private void textBoxCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string codigoDeBarras = textBoxCodigoBarras.Text;

                if (codigoDeBarras.Length > 12)
                {
                    codigoDeBarras = codigoDeBarras.Substring(0, 12);
                }
                textBoxCodigoBarras.Text = "";
                AdicionarProduto(codigoDeBarras);
            }
        }

        IProduto BuscarProduto(string codigoDeBarras)
        {
            foreach (IProduto produto in ArquivoEstoque.ListaProdutos)
            {
                if (Id.ToString(produto._id) == codigoDeBarras) return produto;
            }

            return null;
        }

        void AdicionarProduto(string codigoDeBarras)
        {
            IProduto produto = BuscarProduto(codigoDeBarras);

            if (produto != null)
            {
                if (produto.Quantidade > 0)
                {
                    if (produto.TipoVenda == "Unidade")
                    {
                        produto.Quantidade--;
                        produto.QuantidadeVendida++;
                        produto.QuantidadeComprada++;
                        ValorTotalSemImposto += produto.Preco;
                        ValorTotal += produto.Preco + (produto.Preco * produto.Imposto);
                    }
                    else if (produto.TipoVenda == "Quilo")
                    {
                        QuantidadeQuilo quantidadeQuilo = new QuantidadeQuilo();
                        quantidadeQuilo.ShowDialog();
                        double quantidade = quantidadeQuilo.Peso;
                        produto.Quantidade -= quantidade;
                        produto.QuantidadeVendida += quantidade;
                        produto.QuantidadeComprada += quantidade;
                        ValorTotalSemImposto += produto.Preco * quantidade;
                        ValorTotal += produto.Preco * quantidade + (produto.Preco * quantidade * produto.Imposto);
                    }
                }
                else
                {
                    string message = "Produto indisponível no estoque";
                    string caption = "Estoque";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);
                }

                if (ListaCompra.IndexOf(produto) == -1)
                {
                    ListaCompra.Add(produto);
                }

                CarregarTabela();
                CarregarProduto(produto);
            }

            /*
            if (ListaCompra.Count > 0)
            {
                foreach (IProduto produto in ListaCompra)
                {
                    // caso o produto já tenha entrado na lista de compras
                    // será incrementado +1 em sua quantidade

                    if (codigoDeBarras == Id.ToString(produto._id))
                    {
                        if (produto.Quantidade > 0)
                        {
                            double preco = CarregarProduto(produto, ref quantidadePeso);

                            if (quantidadePeso < produto.Quantidade)
                            {
                                if (produto.TipoVenda == "Unidade")
                                {
                                    ValorTotalSemImposto += produto.Preco;
                                    ValorTotal = ValorTotal + produto.Preco + (produto.Preco * produto.Imposto);
                                    produto.Quantidade--;
                                    produto.QuantidadeComprada++;
                                    produto.QuantidadeVendida++;
                                }
                                else
                                {
                                    ValorTotalSemImposto += preco;
                                    ValorTotal += preco + (preco * produto.Imposto);
                                    produto.Quantidade -= quantidadePeso;
                                    produto.QuantidadeComprada += quantidadePeso;
                                }

                                CarregarTabela();
                                adicionado = true;

                                labelImposto.Text = (produto.Imposto * 100).ToString("F2") + "%";
                                break;
                            }
                            else
                            {
                                string message = "Produto indisponível no estoque";
                                string caption = "Estoque";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result;
                                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);
                                adicionado = true;
                                break;
                            }
                        }
                        else
                        {
                            string message = "Quantidade indisponível no estoque";
                            string caption = "Estoque";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);
                            adicionado = true;
                            break;
                        }
                    }
                }
            }

            if (adicionado == false)
            {
                foreach (IProduto produtoEstoque in ArquivoEstoque.ListaProdutos)
                {
                    if (codigoDeBarras == Id.ToString(produtoEstoque._id))
                    {
                        if (produtoEstoque.Quantidade > 0)
                        {
                            var aux = produtoEstoque;
                            ListaCompra.Add(aux);

                            double preco = CarregarProduto(aux, ref quantidadePeso);

                            if (quantidadePeso < produtoEstoque.Quantidade)
                            {
                                if (aux.TipoVenda == "Unidade")
                                {
                                    ValorTotalSemImposto += produtoEstoque.Preco;
                                    ValorTotal = ValorTotal + produtoEstoque.Preco + (produtoEstoque.Preco * produtoEstoque.Imposto);
                                    aux.Quantidade--;
                                    aux.QuantidadeComprada++;
                                    aux.QuantidadeVendida++;
                                }
                                else
                                {
                                    ValorTotalSemImposto += preco;
                                    ValorTotal = ValorTotal + preco + (preco * aux.Imposto);
                                    aux.Quantidade -= quantidadePeso;
                                    aux.QuantidadeComprada = quantidadePeso;
                                }

                                CarregarTabela();
                                adicionado = true;

                                labelImposto.Text = (produtoEstoque.Imposto * 100).ToString("F2") + "%";
                                break;
                            }
                            else
                            {
                                string message = "Quantidade indisponível no estoque";
                                string caption = "Estoque";
                                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                DialogResult result;
                                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);

                                adicionado = true;
                                break;
                            }
                        }
                        else
                        {
                            string message = "Produto indisponível no estoque";
                            string caption = "Estoque";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);

                            adicionado = true;
                            break;
                        }
                    }
                }
            }
            */
        }

        void CarregarProduto(IProduto produto)
        {
            string caminhoImagem = @"Arquivos\Imagens\Estoque\" + Id.ToString(produto._id) + ".png";
            pictureBoxProduto.Image = Imagem.Carregar(caminhoImagem);
            labelNome.Text = produto.Nome;
            labelPreco.Text = "Preço Uni/Kg: R$ " + produto.Preco.ToString("F2");
            labelImposto.Text = (produto.Imposto * 100).ToString("F2") + "%";

            try //Gerar código de barras do produto
            {
                Zen.Barcode.CodeEan13BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.CodeEan13WithChecksum;
                pictureBoxCodigoBarras.Image = brCode.Draw(Id.ToString(produto._id), 60, 20);
            }
            catch { }
        }

        void CarregarTabela()
        {
            listViewCompras.Items.Clear();

            foreach (var produto in ListaCompra)
            {
                string nome = produto.Nome;
                string preco = "R$ " + produto.Preco.ToString("F2");
                string quantidade = produto.QuantidadeComprada.ToString();
                string descricao = produto.Descricao;

                string[] row = { nome, preco, quantidade };
                var listViewItem = new ListViewItem(row);
                listViewCompras.Items.Add(listViewItem);
            }

            labelValorTotal.Text = "R$ " + ValorTotal.ToString("F2");
        }

        void LimparLista()
        {
            listViewCompras.Items.Clear();
            ListaCompra.Clear();
        }

        void LimparCampos()
        {
            textBoxCodigoBarras.Text = "";
            labelNome.Text = "Nome do produto";
            labelImposto.Text = "0,00%";
            labelPreco.Text = "Preço Uni/Kg: R$ 0,00";
            labelValorTotal.Text = "R$ 0,00";
            pictureBoxCodigoBarras.Image = pictureBoxCodigoBarras.InitialImage;
            pictureBoxProduto.Image = pictureBoxProduto.InitialImage;
            ValorTotal = 0;
        }

        void ConfirmarCompra()
        {
            ProdutoController produtoController = new ProdutoController();

            foreach (IProduto produto in ListaCompra)
            {
                produtoController.Update(produto);
            }

            ArquivoFinanceiro.SalvarSaldo(ValorTotalSemImposto);

            GerarNotaFiscal();
            ArquivoVenda.GerarRelatorioVendas(ValorTotal, DateTime.Now);

            // zerar itens comprados anteriormente
            foreach (IProduto produto in ArquivoEstoque.ListaProdutos)
            {
                produto.QuantidadeComprada = 0;
            }

            string message = "Valor total da compra: R$ " + ValorTotal.ToString("F2");
            string caption = "Compra finalizada";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

            LimparLista();
            LimparCampos();
        }

        void GerarNotaFiscal()
        {
            string ArquivoNota = "";

            string message = "Deseja gerar a nota fiscal?";
            string caption = "Nota fiscal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

            switch (result)
            {
                case DialogResult.Yes:   // Yes button pressed
                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "Text Files | *.txt";
                    save.DefaultExt = "txt";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        ArquivoNota = save.FileName;
                        ArquivoVenda.GerarNotaFiscal(ListaCompra, ValorTotal, ArquivoNota);
                    }
                    break;
                case DialogResult.No:    // No button pressed
                    break;
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (listViewCompras.SelectedItems.Count > 0)
            {
                index = listViewCompras.SelectedItems[0].Index;

                RemoverProduto(index);
            }
            else
            {
                string message = "Nenhum produto selecionado para remoção";
                string caption = "Atenção";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);
            }
        }

        private void RemoverProduto(int index)
        {
            if (ListaCompra[index].QuantidadeComprada == 1)
            {
                ListaCompra.RemoveAt(index);
                LimparCampos();
                CarregarTabela();
            }
            else
            {
                ListaCompra[index].QuantidadeComprada--;
            }

            CarregarTabela();
        }
    }
}
