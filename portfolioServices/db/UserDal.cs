using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using portfolioServices.DomainObjects;

namespace portfolioServices.db
{
    public class UserDal
    {
        public bool InsertUser<T>(T genericObject)
        {
            string connectionString = "mongodb://localhost";
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase db = server.GetDatabase("test");

            string tableName = typeof(T).Name;
            var collection = db.GetCollection<T>(tableName);
            collection.Insert(genericObject);

            return true;
        }

        public T GetUser<T>(int id)
        {
            string connectionString = "mongodb://localhost";
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase db = server.GetDatabase("test");

            string tableName = typeof(T).Name;
            var collection = db.GetCollection<T>(tableName);
            T someObject = collection.FindOneById(id);

            return someObject;
        }
        
    }
}