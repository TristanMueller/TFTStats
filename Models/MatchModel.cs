using System;
using System.Collections.Generic;
using Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace TFTStats.Models
{
    public class Match
    {
        [BsonId]
        public ObjectId _id {get;set;}
        public Info info { get; set; }
        public Metadata metadata { get; set; }
    }
    public class Companion
    {
        public int skin_ID { get; set; }
        public string content_ID { get; set; }
        public string species { get; set; }
    }

    public class Trait
    {
        public int tier_total { get; set; }
        public int style { get; set; }
        public string name { get; set; }
        public int tier_current { get; set; }
        public int num_units { get; set; }
    }

    public class Unit
    {
        public int tier { get; set; }
        public IList<int> items { get; set; }
        public string character_id { get; set; }
        public string name { get; set; }
        public int rarity { get; set; }
    }

    public class Participant
    {
        public int placement { get; set; }
        public int level { get; set; }
        public int last_round { get; set; }
        public double time_eliminated { get; set; }
        public Companion companion { get; set; }
        public IList<Trait> traits { get; set; }
        public int players_eliminated { get; set; }
        public string puuid { get; set; }
        public int total_damage_to_players { get; set; }
        public IList<Unit> units { get; set; }
        public int gold_left { get; set; }
    }

    public class Info
    {
        public long game_datetime { get; set; }
        public IList<Participant> participants { get; set; }
        public int tft_set_number { get; set; }
        public double game_length { get; set; }
        public int queue_id { get; set; }
        public string game_version { get; set; }
    }

    public class Metadata
    {
        public string data_version { get; set; }
        public IList<string> participants { get; set; }
        public string match_id { get; set; }
    }

    public class MatchFunction
    {
        public string _leagueAPIKey { get; set; }
        public MongoAccessModel _mongoAccessModel { get; set; }
        public MatchFunction(MongoAccessModel mongoAccessModel)
        {
            _mongoAccessModel = mongoAccessModel;
            _leagueAPIKey = "RGAPI-69929401-64de-44d0-882c-eaeb6b2c5d3c";
        }
        public CommandResult InsertMatch(Match match)
        {
            var result = new CommandResult();
            try
            {
                _mongoAccessModel._MatchCollection.InsertOne(match);
                result.isSuccess = true;
            }
            catch(Exception ex)
            {
                result.message = ex.ToString();
                result.isSuccess = false;
            }

            return result;
        
        }
        public QueryResult GetMatch(string match_id)
        {
            var queryResult = new QueryResult();
            var filter = Builders<Match>.Filter.Eq("metadata.match_id", "NA1_3270573449");
            queryResult.result = _mongoAccessModel._MatchCollection.Find(filter).ToList();
            queryResult.isSuccess = true;
            return queryResult;
        }
        public CommandResult PopulateMatchCollection()
        {
            var CommandResult = new CommandResult();
            try
            {
                var response = HttpRequestHelper.Get("https://na1.api.riotgames.com/tft/league/v1/challenger?api_key=" + _leagueAPIKey);
                League challengerLeague = Newtonsoft.Json.JsonConvert.DeserializeObject<League>(response);
                foreach (var summoner in challengerLeague.entries)
                {
                    response = HttpRequestHelper.Get("https://na1.api.riotgames.com/lol/summoner/v4/summoners/" +  summoner.summonerId + "?api_key=" + _leagueAPIKey);
                    Summoner challengerSummoner = Newtonsoft.Json.JsonConvert.DeserializeObject<Summoner>(response);
                    response = HttpRequestHelper.Get("https://americas.api.riotgames.com/tft/match/v1/matches/by-puuid/" + challengerSummoner.puuid + "/ids?count=20&api_key=" + _leagueAPIKey);
                    List<string> challengerMatches = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(response);
                    foreach (var match in challengerMatches)
                    {
                        response = HttpRequestHelper.Get("https://americas.api.riotgames.com/tft/match/v1/matches/" + match + "?api_key=" + _leagueAPIKey);
                        Match challengerMatch = Newtonsoft.Json.JsonConvert.DeserializeObject<Match>(response);
                        if(InsertMatch(challengerMatch).isSuccess == false)
                        {
                            System.Threading.Thread.Sleep(60000);
                        }
                    }
                }
                CommandResult.isSuccess = true;
            }
            catch(Exception ex)
            {
                CommandResult.message = ex.ToString();
                CommandResult.isSuccess = false;
            }
            return CommandResult;
        }
    }
}