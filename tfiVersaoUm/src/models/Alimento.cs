﻿using System;
using MongoDB.Bson;

namespace tfiVersaoUm
{
    class Alimento : Produto
    {
        public override double Imposto { get => 0.25; }
        public override string Categoria { get => "Alimentos"; } 
        public override string TipoVenda { get => "Unidade"; }

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

        public Alimento(long codigoBarras, string nome, double preco, int quantidade, int quantidadeVendida, DateTime dataCadastro, string descricao) : base(codigoBarras, nome, preco, quantidade, quantidadeVendida, dataCadastro, descricao)
        {

        }
    }
}
