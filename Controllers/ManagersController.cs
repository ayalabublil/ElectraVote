using calender;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectraVote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {

        private static List<Manager> managers = new List<Manager>() { };

        // GET: api/<ManagersController>
        [HttpGet]
        public IEnumerable<Manager> Get()
        {
            return managers;
        }

        // GET api/<ManagersController>/5
        [HttpGet("{id}")]
        public Manager Get(int id)
        {
            var inedx = managers.FindIndex(e => e.id == id);
            return managers[inedx];
        }

        // POST api/<ManagersController>
        [HttpPost]
        public void Post([FromBody] Manager m)
        {
            managers.Add(new Manager { id = m.id, firstName = m.firstName, lastName = m.lastName, password = m.password });
        }

        // PUT api/<ManagersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Manager m)
        {
            var inedx = managers.FindIndex(e => e.id == id);
            managers[inedx].firstName = m.firstName;
            managers[inedx].lastName = m.lastName;
            managers[inedx].password = m.password;
        }

        // DELETE api/<ManagersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var inedx = managers.FindIndex(e => e.id == id);
            managers.Remove(managers[inedx]);
        }
    }
}
