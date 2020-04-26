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
            FilterDefinition<IProduto> filter = Builders<IProduto>.Filter.Eq(p => p.ID, produto.ID);
            UpdateDefinition<IProduto> changes = Builders<IProduto>.Update.Set(p => p, produto);

            connection.Collection.UpdateOne(filter, changes);
        }
    }
}
