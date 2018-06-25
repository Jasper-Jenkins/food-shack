using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using food_shack.Models;

namespace food_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaladsController : ControllerBase
    {
        List<Salad> Salads = Program.Salads;
        // GET api/salad
        [HttpGet]
        public ActionResult<IEnumerable<Salad>> Get()
        {
            return Salads;
        }

        // GET api/salad/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/salad
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/salad/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/salad/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
