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
    public class SaladsController : ControllerBase
    {
        // List<Salad> Salads = Program.Salads;
    
        private readonly SaladRepository db;
        public SaladsController(SaladRepository repo)
        {
        }

        // GET api/smoothies
        [HttpGet]
        public IEnumerable<Salad> Get()
        {
            return db.GetAll();
        }

        // GET api/smoothies/5
        [HttpGet("{id}")]
        public Salad Get(int id)
        {
            return db.GetById(id);
        }

        // POST api/smoothies
        [HttpPost]
        public Salad Post([FromBody]Salad newSalad)
        {
            if (ModelState.IsValid)
            {
                return db.AddSalad(newSalad);
            }
            return null;
        }

        // PUT api/smoothies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/smoothies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
