using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using food_shack.Models;
using food_shack.Interface;
namespace food_shack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
         List<IPurchasable> MenuItems = Program.MenuItems;
       
       
        // GET api/menu
        [HttpGet]
        public ActionResult<IEnumerable<IPurchasable>> Get()
        {
            return MenuItems;
        }

        // GET api/menu/5
        [HttpGet("{id}")]
        public ActionResult<IPurchasable> Get(int id)
        {
            if(id > -1 && id < MenuItems.Count){
                return MenuItems[id];
            }
            return null;
        }

        // POST api/menu
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/menu/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/menu/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
