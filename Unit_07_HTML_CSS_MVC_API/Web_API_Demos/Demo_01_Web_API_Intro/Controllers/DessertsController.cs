using Demo_01_Web_API_Intro.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// HTTP Verbs:
/*
 * GET      - Request informfation from a web address (URL). Retrieves data without modifying it.
 * POST     - Sends data to a server. Creates a new record. Data is in the 'body' of the the web request.
 * PUT      - Sends data to a server. Update an existing record (the ENTIRE record) by replacing it with the new data. Requires the full data for the update.
 * PATCH    - Sends data to a server. Update a part of an existing record. Only requires the fields that need to be updated.
 * DELETE   - Request to delete an existing on the server.
 * 
 */
// These HTTP verbs fulfill CRUD ( CREATE, READ, UPDATE, DELETE)


namespace Demo_01_Web_API_Intro.Controllers
{
    // URL: https://localhost:7242/api/Desserts
    [Route("api/[controller]")]
    [ApiController]
    public class DessertsController : ControllerBase
    {
        // GET: api/Desserts
        [HttpGet]
        public ActionResult<List<Dessert>> Get()
        {
            return Ok(Dessert.Desserts);
        }

        // GET api/Desserts/5
        [HttpGet("{id}")]
        public ActionResult<Dessert> Get(int id)
        {
            Dessert result = Dessert.Desserts.FirstOrDefault(x => x.Id == id);

            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/Desserts
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Desserts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Desserts/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            Dessert dessertToDelete = Dessert.Desserts.FirstOrDefault(x => x.Id == id);
            return Dessert.Desserts.Remove(dessertToDelete);
        }
    }
}
