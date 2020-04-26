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

            BuscarProduto(codigoDeBarras);
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
                BuscarProduto(codigoDeBarras);
            }
        }

        void BuscarProduto(string codigoDeBarras)
        {
            bool adicionado = false;
            double quantidadePeso = 0;

            if (ListaCompra.Count > 0)
            {
                foreach (IProduto produto in ListaCompra)
                {
                    // caso o produto já tenha entrado na lista de compras
                    // será incrementado +1 em sua quantidade

                    if (codigoDeBarras == produto.CodigoBarras)
                    {
                        if (produto.Quantidade > 0)
                        {
                            double preco = CarregarProduto(produto, ref quantidadePeso);

                            if (quantidadePeso < produto.Quantidade)
                            {
                                if (produto.TipoVenda == "Quilo")
                                {
                                    ValorTotalSemImposto += preco;
                                    ValorTotal += preco + (preco * produto.Imposto);
                                    produto.Quantidade -= quantidadePeso;
                                    produto.QuantidadeComprada += quantidadePeso;
                                }
                                else
                                {
                                    ValorTotalSemImposto += produto.Preco;
                                    ValorTotal = ValorTotal + produto.Preco + (produto.Preco * produto.Imposto);
                                    produto.Quantidade--;
                                    produto.QuantidadeComprada++;
                                    produto.QuantidadeVendida++;
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
                    if (codigoDeBarras == produtoEstoque.CodigoBarras)
                    {
                        if (produtoEstoque.Quantidade > 0)
                        {
                            var aux = produtoEstoque;
                            ListaCompra.Add(aux);

                            double preco = CarregarProduto(aux, ref quantidadePeso);

                            if (quantidadePeso < produtoEstoque.Quantidade)
                            {
                                if (aux.TipoVenda == "Quilo")
                                {
                                    ValorTotalSemImposto += preco;
                                    ValorTotal = ValorTotal + preco + (preco * aux.Imposto);
                                    aux.Quantidade -= quantidadePeso;
                                    aux.QuantidadeComprada = quantidadePeso;
                                }
                                else
                                {

                                    ValorTotalSemImposto += produtoEstoque.Preco;
                                    ValorTotal = ValorTotal + produtoEstoque.Preco + (produtoEstoque.Preco * produtoEstoque.Imposto);
                                    aux.Quantidade--;
                                    aux.QuantidadeComprada++;
                                    aux.QuantidadeVendida++;
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
            labelValorTotal.Text = "R$ " + ValorTotal.ToString("F2");
        }

        double CarregarProduto(IProduto produto, ref double quantidade)
        {
            double preco = 0;

            string caminhoImagem = @"Arquivos\Imagens\Estoque\" + produto.CodigoBarras + ".png";
            pictureBoxProduto.Image = Imagem.Carregar(caminhoImagem);
            labelNome.Text = produto.Nome;

            if (produto.TipoVenda == "Quilo")
            {
                QuantidadeQuilo quantidadeQuilo = new QuantidadeQuilo();
                quantidadeQuilo.ShowDialog();
                quantidade = quantidadeQuilo.Peso;
                preco = produto.Preco * quantidade;
                labelPreco.Text = "Preço: R$ " + preco.ToString("F2");
            }
            else if (produto.TipoVenda == "Unidade")
            {
                labelPreco.Text = "Preço: R$ " + produto.Preco.ToString("F2");
                preco = produto.Preco;
            }

            try //Gerar código de barras do produto
            {
                Zen.Barcode.CodeEan13BarcodeDraw brCode = Zen.Barcode.BarcodeDrawFactory.CodeEan13WithChecksum;
                pictureBoxCodigoBarras.Image = brCode.Draw(produto.CodigoBarras, 60, 20);
            }
            catch
            {

            }
            return preco;
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
        }

        void LimparCampos()
        {
            listViewCompras.Items.Clear();
            ListaCompra.Clear();
            textBoxCodigoBarras.Text = "";
            labelNome.Text = "Nome do produto";
            labelImposto.Text = "0,00%";
            labelPreco.Text = "Preço: R$ 0,00";
            labelValorTotal.Text = "R$ 0,00";
            pictureBoxCodigoBarras.Image = pictureBoxCodigoBarras.InitialImage;
            pictureBoxProduto.Image = pictureBoxProduto.InitialImage;
            ValorTotal = 0;
        }

        void ConfirmarCompra()
        {
            ArquivoEstoque.SalvarArquivo();
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

        private void Venda_Load(object sender, EventArgs e)
        {

        }
    }
}
