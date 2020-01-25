using System;
using System.Collections.Generic;

namespace TFTStats.Models
{
    public class Match
    {
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
        public MongoAccessModel _mongoAccessModel { get; set; }
        public MatchFunction(MongoAccessModel mongoAccessModel)
        {
            _mongoAccessModel = mongoAccessModel;
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
    }
}