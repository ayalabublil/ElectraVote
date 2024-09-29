using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectraVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotersController : ControllerBase
    {
        private static List<Voter> voters = new List<Voter>() {};


        // GET: api/<VotersController>
        [HttpGet]
        public IEnumerable<Voter> Get()
        {
            return voters;
        }

        // GET api/<VotersController>/5
        [HttpGet("{id}")]
        public Voter Get(int id)
        {
            var index = voters.FindIndex(e => e.id == id);
            return voters[index];
        }

        // POST api/<VotersController>
        [HttpPost]
        public void Post([FromBody] Voter v)
        {
            voters.Add(new Voter { id = 2, firstName = v.firstName, adress = v.adress, lastName = v.lastName, phone = v.phone, partyCode = v.partyCode, stateCode = v.stateCode });
        }

        // PUT api/<VotersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Voter v)
        {
                var index = voters.FindIndex(e => e.id == id);
                voters[index].firstName = v.firstName;
                voters[index].adress = v.adress;
                voters[index].lastName = v.lastName;
                voters[index].stateCode = v.stateCode;
                voters[index].partyCode = v.partyCode;
                voters[index].phone = v.phone;
        }

        // DELETE api/<VotersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = voters.FindIndex(e => e.id == id);
            voters.Remove(voters[index]);
        }
    }
}
