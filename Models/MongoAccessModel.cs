using System;
using MongoDB.Driver;

namespace TFTStats.Models
{
    public class MongoAccessModel
    {
        public IMongoClient _client;
        public IMongoDatabase _db;
        public IMongoCollection<Match> _MatchCollection;
        public MongoAccessModel(string database,string connectionString)
        {
            _client = new MongoClient(connectionString);
            _db = _client.GetDatabase(database);
            _MatchCollection = _db.GetCollection<Match>("Matches");
        }
    }
}