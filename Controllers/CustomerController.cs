using System.Collections.Generic;
using HttpRepl.Model;
using Microsoft.AspNetCore.Mvc;

namespace HttpRepl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static readonly Dictionary<int, Customer> _customers = new Dictionary<int, Customer>();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _customers.Values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return _customers[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _customers.Add(value.Id, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            _customers[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customers.Remove(id);
        }
    }
}