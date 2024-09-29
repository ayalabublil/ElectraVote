using calender;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectraVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private static List<State> states = new List<State>() { };

        // GET: api/<StatesController>
        [HttpGet]
        public IEnumerable<State> Get()
        {
            return states;
        }

        // GET api/<StatesController>/5
        [HttpGet("{id}")]
        public State Get(int id)
        {
            var index = states.FindIndex(e => e.id == id);
            return states[index];
        }

        // POST api/<StatesController>
        [HttpPost]
        public void Post([FromBody] State s)
        {
            states.Add(new State { id = 2, name = s.name});
        }

        // PUT api/<StatesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] State s)
        {
            var index = states.FindIndex(e => e.id == id);
            states[index].name = s.name;
        }

        // DELETE api/<StatesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = states.FindIndex(e => e.id == id);
            states.Remove(states[index]);
        }
    }
}
