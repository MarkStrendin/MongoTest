using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting...");
            MongoClient dbClient = new MongoClient("mongodb://10.0.0.120");
            List<BsonDocument> dbList = dbClient.ListDatabases().ToList();
            Console.WriteLine("Databases:");
            foreach(BsonDocument db in dbList)
            {
                Console.WriteLine(db);
            }


        }
    }
}
