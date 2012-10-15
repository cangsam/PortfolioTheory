using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using portfolioServices.DomainObjects;

namespace portfolioServices.db
{
    public class TestDbConnector
    {

        public bool StoreStock()
        {
            string connectionString = "mongodb://localhost";
            MongoServer server = MongoServer.Create(connectionString);
            MongoDatabase db = server.GetDatabase("test");
            //var stockCollection = db.GetCollection("stocks");

            MongoCollection<User> stockCollection = db.GetCollection<User>("User");

//            BsonClassMap.RegisterClassMap<User>(cm =>
//            {
//                cm.AutoMap();
//                cm.MapIdField("id");
//                cm.MapField("username");
//                cm.MapField("password");
//                cm.MapField("stockHistory");
//            });
//
//            if (!BsonClassMap.IsClassMapRegistered(typeof(User)))
//            {
//                 register class map for MyClass
//            }
            var userCollection = db.GetCollection<User>("user");
            User user = new User();
            user.username = "bobby1";
            var stockHistory = new StockHistory();
            stockHistory.symbol = "EA";
            user.id = 1;
            user.stockHistory = new List<StockHistory>();
            user.stockHistory.Add(stockHistory);
            userCollection.Insert(user);
            
            var userDocument = new BsonDocument();

            
            //userDocument.Insert(user);
//            stockDocument["symbol"] = "msft";
//            stockDocument["price"] = 23.44;
//
//            stockCollection.Insert(stockDocument);

//            var stockDocument = new BsonDocument();
//            stockDocument["symbol"] = "msft";
//            stockDocument["price"] = 23.44;
//            stockCollection.Insert(stockDocument);

            return true;
        }
    }
}