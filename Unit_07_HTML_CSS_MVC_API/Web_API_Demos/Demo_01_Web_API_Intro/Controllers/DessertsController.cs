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
            try
            {
                return Ok(Dessert.Desserts);

            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // GET api/Desserts/5
        [HttpGet("{id}")]
        public ActionResult<Dessert> Get(int id)
        {
            try
            {
                Dessert result = Dessert.Desserts.FirstOrDefault(x => x.Id == id);

                if (result is null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // POST api/Desserts
        [HttpPost]
        public ActionResult<Dessert> Post(Dessert dessert)
        {
            try
            {
                Dessert.Desserts.Add(dessert); // In this demo, we are simply adding our dessert to the static list of desserts, instead of adding and saving to a database.

                Dessert savedDessert = Dessert.Desserts.First(d => d.Id == dessert.Id); // Making sure the dessert was actually saved

                return Ok(savedDessert);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/Desserts/5
        [HttpPut("{id}")]
        public ActionResult<Dessert> Put(int id, [FromBody] string Name)
        {
            throw new NotImplementedException();
        }

        // PUT api/Desserts/5
        [HttpPatch("{id}")]
        public ActionResult<Dessert> UpdateName(int id, [FromBody] string Name)
        { 

            if (Dessert.Desserts.Exists(d => d.Id == id))
            {
                Dessert.Desserts.First(d => d.Id == id).Name = Name;
            }

            return Ok(Dessert.Desserts.First(d => d.Id == id));
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
