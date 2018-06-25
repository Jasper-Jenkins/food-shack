using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace food_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SandwichesController : ControllerBase
    {
        // GET api/sandwich
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/sandwich/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/sandwich
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/sandwich/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/sandwich/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}