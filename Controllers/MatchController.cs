using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFTStats.Models;

namespace TFTStats.Controllers
{
    [ApiController]
    public class MatchController : ControllerBase
    {
        public MongoAccessModel _mongoAccessModel { get; set; }
        public MatchController(MongoAccessModel mongoAccessModel)
        {
            _mongoAccessModel = mongoAccessModel;
        }
        // GET api/values
        [HttpGet]
        [Route("api/[controller]/PopulateMatches")]
        public CommandResult PopulateMatches()
        {                
            var matchFunction = new MatchFunction(_mongoAccessModel);
            return matchFunction.PopulateMatchCollection();
        }

        [HttpGet]
        [Route("api/[controller]/GetMatchById")]
        public QueryResult GetMatch(string match_id)
        {
            var matchFunction = new MatchFunction(_mongoAccessModel);
            return matchFunction.GetMatch(match_id);
        }
        [HttpGet]
        [Route("api/[controller]/PurgeMatches")]
        public CommandResult PurgeMatches()
        {
            var matchFunction = new MatchFunction(_mongoAccessModel);
            return matchFunction.PurgeMatchCollection();
        }
    }
}
