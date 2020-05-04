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
                string mongoUrl = dotenv.mongoURL; // Substituir por url do mongoDB
                Cliente = new MongoClient(mongoUrl);
                Database = Cliente.GetDatabase("loja");
                Collection = Database.GetCollection<IProduto>(collection);
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocorreu um erro ao conectar ao banco de dados");
            }    
        }
    }
}
