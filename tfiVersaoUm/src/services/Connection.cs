using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MongoDB.Driver;

namespace tfiVersaoUm
{
    class Connection
    {
        private MongoClient Cliente;
        private IMongoDatabase Database;
        public IMongoCollection<IProduto> Collection;

        public Connection(string collection)
        {
            try
            {
                Cliente = new MongoClient("mongodb+srv://obraia:2025glaciene@cluster0-2jhg5.mongodb.net/test?retryWrites=true&w=majority");
                Database = Cliente.GetDatabase("loja");
                Collection = Database.GetCollection<IProduto>(collection);
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados");
            }       
        }

        public void Store(IProduto produto)
        {
            this.Collection.InsertOne(produto);
        }

        public void Update(IProduto produto)
        {
            FilterDefinition<IProduto> filter =  Builders<IProduto>.Filter.Eq(p => p.ID, produto.ID);
            UpdateDefinition<IProduto> changes = Builders<IProduto>.Update.Set(p => p, produto);

            this.Collection.UpdateOne(filter, changes);
        }
    }
}
