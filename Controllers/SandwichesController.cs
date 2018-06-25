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
    public class SandwichesController : ControllerBase
    {
        List<Sandwich> Sandwiches = Program.Sandwiches;
        // GET api/sandwich
        [HttpGet]
        public ActionResult<IEnumerable<Sandwich>> Get()
        {
            
            return Sandwiches;
        }

        // GET api/sandwich/5
        [HttpGet("{id}")]
        public ActionResult<Sandwich> Get(int id)
        {
            
            if(id > -1 && id < Sandwiches.Count){
                return Sandwiches[id];
            }
            return null;
        }

        // POST api/sandwich
        [HttpPost]
        public ActionResult<List<Sandwich>> Post([FromBody]Sandwich newSandwich)
        {
            if (ModelState.IsValid)
            {
                Sandwiches.Add(newSandwich);
                return Sandwiches;
            }
            return null;
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
