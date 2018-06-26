using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using food_shack.Models;
using food_shack.Repositories;

namespace food_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SandwichesController : ControllerBase
    {
        // List<Sandwich> Sandwiches = Program.Sandwiches;
        
        private readonly SandwichRepository db;
        public SandwichesController(SandwichRepository repo)
        {
            db = repo;
        }

        // GET api/sandwiches
        [HttpGet]
        public IEnumerable<Sandwich> Get()
        {
            return db.GetAll();
        }

        // GET api/sandwiches/5
        [HttpGet("{id}")]
        public Sandwich Get(int id)
        {
            return db.GetById(id);
        }

        // POST api/sandwiches
        [HttpPost]
        public Sandwich Post([FromBody]Sandwich newSandwich)
        {
            if (ModelState.IsValid)
            {
                return db.AddSandwich(newSandwich);
            }
            return null;
        }

        // PUT api/sandwiches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/sandwiches/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
