using System;
using MongoDB.Driver;

namespace TFTStats.Models
{
    public class MongoAccessModel
    {
        private IMongoClient _client;
        private IMongoDatabase _db;
        private IMongoCollection<Match> _MatchCollection;
        public MongoAccessModel(string database,string connectionString)
        {
            _client = new MongoClient(connectionString);
            _db = _client.GetDatabase(database);
            _MatchCollection = _db.GetCollection<Match>("Matches");
        }
        public CommandResult InsertNewMatch(Match match)
        {
            var result = new CommandResult();
            try
            {
                _MatchCollection.InsertOne(match);
                result.isSuccess = true;
            }
            catch(Exception ex)
            {
                result.message = ex.ToString();
                result.isSuccess = false;
            }

            return result;
        }
    }
}