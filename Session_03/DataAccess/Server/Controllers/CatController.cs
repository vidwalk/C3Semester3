using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Entities;

namespace Server.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class CatController : Controller {
        private readonly CatContext _context;

        public CatController (CatContext context) {
            _context = context;
            DbInitializer.Initialize (_context);
        }

        [HttpGet]
        public ActionResult<List<Cat>> Get () {


            return _context.cats.ToList ();
        }

        // GET api/values/MeowMeow1
        [HttpGet ("{name}")]
        public ActionResult<Cat> Get (string name) {
             return _context.cats.Single(c => c.Name.Equals(name));
        }
        [HttpGet ("{id}")]
        public ActionResult<Cat> Get (int id) {
             return _context.cats.Single(c => c.Id.Equals(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post ([FromBody] Cat cat) {
             if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }
            _context.Add (cat);
            _context.SaveChanges ();
             return CreatedAtAction ("Get", cat);
         }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { 
            
        }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}