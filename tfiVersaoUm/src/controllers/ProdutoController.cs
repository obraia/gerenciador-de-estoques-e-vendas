using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MongoDB.Driver;

namespace tfiVersaoUm
{
    class ProdutoController
    {
        private static Connection connection = new Connection("produtos");

        public List<IProduto> Index()
        {
            try
            {
                FilterDefinition<IProduto> filter = Builders<IProduto>.Filter.Empty;
                List<IProduto> response = connection.Collection.Find(filter).ToList();
                return response;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return new List<IProduto>();
            }
        }

        public int Store(IProduto produto)
        {
            try
            {
                connection.Collection.InsertOne(produto);
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }

        public int Update(IProduto produto)
        {
            try
            {
                FilterDefinition<IProduto> filter = Builders<IProduto>.Filter.Eq("_id", produto._id);
                ReplaceOneResult response = connection.Collection.ReplaceOne(filter, produto);
                return (int)response.ModifiedCount;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }

        public int Delete(IProduto produto)
        {
            try
            {
                FilterDefinition<IProduto> filter = Builders<IProduto>.Filter.Eq("_id", produto._id);
                DeleteResult response = connection.Collection.DeleteOne(filter);
                return (int)response.DeletedCount;
            }
            catch
            {
                return 0;
            }
        }
    }
}
