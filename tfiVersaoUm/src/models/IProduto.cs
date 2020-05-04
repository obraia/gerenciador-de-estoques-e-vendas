using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;

namespace tfiVersaoUm
{
    interface IProduto : IComparable<IProduto>
    {
        ObjectId _id { get; set; }
        string Categoria { get; }
        string Nome { get; }
        double Preco { get; }
        double Imposto { get; }
        string TipoVenda { get; }
        double Quantidade { get; set; }
        double QuantidadeComprada { get; set; }
        double QuantidadeVendida { get; set; }
        DateTime DataCadastro { get; }
        string Descricao { get; }
        string EscreverArquivo();
        int CompareTo(IProduto produto);
    }
}
