using calender;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectraVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartiesController : ControllerBase
    {
        private static List<Party> parties = new List<Party>() { };

        // GET: api/<PartiesController>
        [HttpGet]
        public IEnumerable<Party> Get()
        {
            return parties;
        }

        // GET api/<PartiesController>/5
        [HttpGet("{id}")]
        public Party Get(int id)
        {
            var index = parties.FindIndex(e => e.id == id);
            return parties[index];
        }

        // POST api/<PartiesController>
        [HttpPost]
        public void Post([FromBody] Party p)
        {
            parties.Add(new Party { id = 2, name = p.name });
        }

        // PUT api/<PartiesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Party p)
        {
            var index = parties.FindIndex(e => e.id == id);
            parties[index].name = p.name;
        }

        // DELETE api/<PartiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = parties.FindIndex(e => e.id == id);
            parties.Remove(parties[index]);
        }
    }
}
