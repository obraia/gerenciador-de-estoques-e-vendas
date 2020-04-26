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
        MongoClient Cliente;
        IMongoDatabase Database;
        IMongoCollection<IProduto> Collection;

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
    }
}
