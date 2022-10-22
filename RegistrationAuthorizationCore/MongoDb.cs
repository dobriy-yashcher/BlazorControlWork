using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace RegistrationAuthorizationCore
{
    public class MongoDb
    {
        public static IMongoCollection<User> collection =
            new MongoClient("mongodb://localhost:27017").GetDatabase("RegistrationAuthorizationControl").GetCollection<User>("UsersCollection");

        public static void AddToDataBase(User user)
        {
            collection.InsertOne(user);
        }

        public static void DeleteFromDataBase(User user)
        {
            var filter = new BsonDocument("_id", user._id);
            collection.DeleteOne(filter);
        }

        public static void ReplaceOneInDataBase(User user)
        {
            var filter = new BsonDocument("_id", user._id);
            collection.ReplaceOne(filter, user);
        }

        public static User FindById(string id)
        {
            var filter = new BsonDocument("_id", ObjectId.Parse(id));
            return collection.Find(filter).FirstOrDefault();
        }

        public static IMongoCollection<User> GetCollection()
        {
            return collection;
        }

        /*public static void Connect_cbusers()
        {
            var user = new Warrior();
            user.name = "tempuser";

            AddToDataBase(user);
            DeleteFromDataBase(user);
        }*/
    }
}
