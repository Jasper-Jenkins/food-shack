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
    public class SmoothiesController : ControllerBase
    {
        List<Smoothie> Smoothies = Program.Smoothies;
       
        // GET api/smoothie
        [HttpGet]
        public ActionResult<IEnumerable<Smoothie>> Get()
        {
            // for(int i =0; i< Smoothie.Count; i++){
                
            // }
    
             return Smoothies;
        } 
        // GET api/smoothie/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/smoothie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/smoothie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/smoothie/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
