using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/Items")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        IItemSource ItemsDatabase;
        public ItemsController(IItemSource itemsDatabase)
        {
            ItemsDatabase = itemsDatabase;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return ItemsDatabase.GetItems().Select(x => x.Name);
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return ItemsDatabase.GetItems().First(x => x.ID == id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            ItemsDatabase.AddNewItem(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
