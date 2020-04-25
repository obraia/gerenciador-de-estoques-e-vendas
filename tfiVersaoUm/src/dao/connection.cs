using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MongoDB.Driver;

namespace tfiVersaoUm.src.dao
{
    class Connection
    {
        public Connection()
        {
            try
            {
                var cliente = new MongoClient("mongodb+srv://obraia:<password>@cluster0-2jhg5.mongodb.net/test?retryWrites=true&w=majority");
                var database = cliente.GetDatabase("loja");
                var colection = database.GetCollection<IProduto>("produtos");
            }
            catch(MongoAuthenticationException e)
            {
                MessageBox.Show(e.Message);
            }       
        } 
    }
}
