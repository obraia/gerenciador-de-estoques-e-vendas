using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace tfiVersaoUm
{
    class ProdutoController
    {
        private static Connection connection = new Connection("produtos");

        public void Store(IProduto produto)
        {
            connection.Collection.InsertOne(produto);
        }

        public void Update(IProduto produto)
        {
            FilterDefinition<IProduto> filter = Builders<IProduto>.Filter.Eq("ID", produto.ID);
            connection.Collection.ReplaceOne(filter, produto);
        }
    }
}
