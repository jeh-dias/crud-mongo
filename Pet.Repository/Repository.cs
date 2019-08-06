using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Petshop_Estrelas.Domain;
using Petshop_Estrelas.Repository.Interfaces;
using Petshop_Estrelas.Repository.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petshop_Estrelas.Repository
{

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public static List<T> _list { get; set; }
        public static object _syncObj = new object();
        private readonly ILogger _logger;
        private readonly string _databaseName;
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase mongoDatabase;


        public Repository(ILogger logger, string databaseName)
        {
            if (_list == null)
            {
                lock (_syncObj)
                {
                    if (_list == null)
                    {
                        _list = new List<T>();
                    }
                }
            }
            _logger = logger;
            _databaseName = databaseName;
            mongoClient = ConnectionFactory.GetConnection("mongodb://localhost:27017");
            mongoDatabase = mongoClient.GetDatabase(databaseName);
        }

        public bool Add(T obj)
        {
            var collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
            collection.InsertOne(obj);
            return true;
        }

        public bool Delete(T obj)
        {
            var collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
            //collection.DeleteOne(obj);
            return true;
        }

        public List<T> GetAll()
        {
            var collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
            var data = collection.AsQueryable().ToList();
            return data;
        }

        public T GetById(int id)
        {
            //var collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
            //var filter = Builders<Pet>.Filter.Eq("id", id);
            //return collection.Find(filter).ToList();
            return null;
        }

        public bool Update(T obj)
        {
            var collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
            //collection.UpdateOneAsync(obj);
            return true;
        }
    }
}
