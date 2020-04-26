using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace tfiVersaoUm
{
    class Produto : IProduto
    {
        public ObjectId _id { get; set; }
        public virtual double Imposto { get;  private set; }
        public string CodigoBarras { get; private set; }
        public virtual string Categoria { get; private set; }
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public virtual string TipoVenda { get; set; }
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

        public Produto(string codigoBarras, string nome, double preco, double quantidade, double quantidadeVendida, DateTime dataCadastro, string descricao)
        {
            CodigoBarras = codigoBarras;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            QuantidadeVendida = quantidadeVendida;
            DataCadastro = dataCadastro;
            Descricao = descricao;
        }

        public string EscreverArquivo()
        {
            return CodigoBarras + ";" + Categoria + ";" + Nome + ";" + Preco.ToString("F2") + ";" + Quantidade + ";" + QuantidadeVendida + ";" + DataCadastro.ToString() + ";" + Descricao;
        }
    }
}
