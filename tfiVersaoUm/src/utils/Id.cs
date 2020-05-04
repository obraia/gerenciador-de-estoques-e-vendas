using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace tfiVersaoUm
{
    class Id
    {
        public static string ToString(ObjectId id)
        {
            return id.ToString().TrimStart('0');
        }
    }
}
