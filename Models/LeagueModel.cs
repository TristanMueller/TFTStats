using System.Collections.Generic;

namespace Models
{
    public class Entry
    {
        public string summonerName { get; set; }
        public bool hotStreak { get; set; }
        public int wins { get; set; }
        public bool veteran { get; set; }
        public int losses { get; set; }
        public string rank { get; set; }
        public bool inactive { get; set; }
        public bool freshBlood { get; set; }
        public string summonerId { get; set; }
        public int leaguePoints { get; set; }
    }

    public class League
    {
        public string tier { get; set; }
        public string leagueId { get; set; }
        public IList<Entry> entries { get; set; }
        public string queue { get; set; }
        public string name { get; set; }
    }

}