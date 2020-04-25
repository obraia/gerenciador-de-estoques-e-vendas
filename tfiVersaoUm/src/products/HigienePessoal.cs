using System;

namespace tfiVersaoUm
{
    class HigienePessoal : IProduto, IComparable<IProduto>
    {
        public double Imposto { get => 0.27;}
        public string ID { get; private set; }
        public string Categoria { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public string TipoVenda { get; set; }
        public double Quantidade { get; set; }
        public double QuantidadeComprada { get; set; }
        public double QuantidadeVendida { get; set; }
        public DateTime DataCadastro { get; private set; }
        public string Descricao { get; private set; }

        public int CompareTo(IProduto produto)
        {
            // Se o número de vendas for igual então faz a ordenação de acordo com o maior preco
            if (this.QuantidadeVendida == produto.QuantidadeVendida)
            {
                return produto.Preco.CompareTo(this.Preco);
            }
            // Ordenação padrão : do maior número de vendas para o menor
            return produto.QuantidadeVendida.CompareTo(this.QuantidadeVendida);
        }

        public HigienePessoal()
        {
        }

        public HigienePessoal(string id, string nome, double preco, int quantidade, int quantidadeVendida, DateTime dataCadastro, string descricao)
        {
            ID = id;
            Categoria = "Higiene pessoal";
            Nome = nome;
            Preco = preco;
            TipoVenda = "Unidade";
            Quantidade = quantidade;
            QuantidadeVendida = quantidadeVendida;
            DataCadastro = dataCadastro;
            Descricao = descricao;
        }

        public string EscreverArquivo()
        {
            return ID + ";" + Categoria + ";" + Nome + ";" + Preco.ToString("F2") + ";" + Quantidade + ";" + QuantidadeVendida + ";" + DataCadastro.ToString() + ";" + Descricao;
        }
    }
}
