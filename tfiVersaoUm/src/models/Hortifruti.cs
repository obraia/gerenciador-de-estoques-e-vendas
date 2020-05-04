using System;
using MongoDB.Bson;

namespace tfiVersaoUm
{
    class Hortifruti : Produto, IComparable<IProduto>
    {
        public override double Imposto { get => 0.27; }
        public override string Categoria { get => "Hortifruti"; }
        public override string TipoVenda { get => "Quilo"; }

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

        public Hortifruti(long codigoBarras, string nome, double preco, double quantidade, double quantidadeVendida, DateTime dataCadastro, string descricao) : base(codigoBarras, nome, preco, quantidade, quantidadeVendida, dataCadastro, descricao)
        {

        }
    }
}
