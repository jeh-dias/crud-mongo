using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop_Estrelas.Repository.Utilities
{
    public class ConnectionFactory
    {
        public static MongoClient GetConnection(string connectionString)
        {
            return new MongoClient(connectionString);
        }
    }
}
