using System;
using System.Windows.Forms;

namespace tfiVersaoUm
{
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
            ArquivoFornecedores.LerArquivo();
            CarregarTabela();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarFornecedor adicionarFornecedor = new AdicionarFornecedor();
            adicionarFornecedor.ShowDialog();
            CarregarTabela();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void listViewFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarProdutoTabela();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            AbrirEditarFornecedores();
        }

        private void listViewFornecedores_DoubleClick(object sender, EventArgs e)
        {
            AbrirEditarFornecedores();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (listViewFornecedores.SelectedItems.Count > 0)
            {
                ListViewItem selItem = listViewFornecedores.SelectedItems[0];
                index = selItem.Index;

                string message = "Tem certeza que deseja remover o fornecedor?";
                string caption = "Atenção";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Exclamation);

                switch (result)
                {
                    case DialogResult.Yes:   // Yes button pressed
                        ArquivoFornecedores.RemoverFornecedor(index);
                        CarregarTabela();
                        LimparComponentes();
                        ArquivoFornecedores.SalvarArquivo();
                        break;
                    case DialogResult.No:    // No button pressed
                        break;
                }
            }
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {

        }

        void CarregarTabela()
        {
            listViewFornecedores.Items.Clear();

            foreach (var fornecedor in ArquivoFornecedores.ListaFornecedores)
            {
                string nome = fornecedor.Nome;
                string id = fornecedor.ID;
                string estado = fornecedor.Estado;
                string cep = fornecedor.CEP;
                string telefone = fornecedor.Telefone;
                string email = fornecedor.Email;

                string[] row = { nome, id, estado };
                var listViewItem = new ListViewItem(row);
                listViewFornecedores.Items.Add(listViewItem);
            }
        }

        void CarregarProdutoTabela()
        {
            int index = 0;

            if (listViewFornecedores.SelectedItems.Count > 0)
            {
                ListViewItem selItem = listViewFornecedores.SelectedItems[0];
                index = selItem.Index;

                pictureBoxFornecedor.Image = Imagem.Carregar(@"Arquivos\Imagens\Fornecedores\" + ArquivoFornecedores.ListaFornecedores[index].NumeroDeCadastro + ".png");
                labelFornecedor.Text = ArquivoFornecedores.ListaFornecedores[index].Nome.ToUpper();
                labelTelefone.Text = ArquivoFornecedores.ListaFornecedores[index].Telefone;
                labelEmail.Text = ArquivoFornecedores.ListaFornecedores[index].Email;

                if (ArquivoFornecedores.ListaFornecedores[index].Categoria == "Alimentos")
                {
                    pictureBoxCategoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\alimentos.png");
                }
                else if (ArquivoFornecedores.ListaFornecedores[index].Categoria == "Limpeza")
                {
                    pictureBoxCategoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\limpeza.png");
                }
                else if (ArquivoFornecedores.ListaFornecedores[index].Categoria == "Higiene pessoal")
                {
                    pictureBoxCategoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\higienePessoal.png");
                }
                else if (ArquivoFornecedores.ListaFornecedores[index].Categoria == "Hortifruti")
                {
                    pictureBoxCategoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\hortifruti.png");
                }
                else if (ArquivoFornecedores.ListaFornecedores[index].Categoria == "Outros")
                {
                    pictureBoxCategoria.Image = Imagem.Carregar(@"Arquivos\Imagens\Categorias\outros.png");
                }
            }
        }

        void AbrirEditarFornecedores()
        {
            int index = 0;

            if (listViewFornecedores.SelectedItems.Count > 0)
            {
                ListViewItem selItem = listViewFornecedores.SelectedItems[0];
                index = selItem.Index;

                EditarFornecedor editarFornecedor = new EditarFornecedor(index);
                editarFornecedor.ShowDialog();
                CarregarTabela();
            }
        }

        private void LimparComponentes()
        {
            pictureBoxFornecedor.Image = Imagem.Carregar("");
            labelFornecedor.Text = "";
            labelTelefone.Text = "";
            labelEmail.Text = "";

            pictureBoxCategoria.Image = Imagem.Carregar("");
        }
           
    }
}
