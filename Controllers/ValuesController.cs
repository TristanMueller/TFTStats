using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TFTStats.Models;

namespace TFTStats.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public MongoAccessModel _mongoAccessModel { get; set; }
        public ValuesController(MongoAccessModel mongoAccessModel)
        {
            _mongoAccessModel = mongoAccessModel;
        }
        // GET api/values
        [HttpGet]
        public CommandResult PopulateMatches()
        {                
            var matchFunction = new MatchFunction(_mongoAccessModel);
            return matchFunction.PopulateMatchCollection();
        }

        [HttpGet]
        [Route("/getbymatch")]
        public QueryResult GetMatch()
        {
            var matchFunction = new MatchFunction(_mongoAccessModel);
            return matchFunction.GetMatch("");
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
