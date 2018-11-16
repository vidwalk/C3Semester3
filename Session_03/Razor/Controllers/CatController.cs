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
        private readonly CatRepository _context;

        public CatController (CatRepository context) {
            _context = context;
            
        }

        [HttpGet]
        public ActionResult<List<Cat>> Get () {
            return _context.GetAllCats();
        }

        // GET api/values/MeowMeow1
        [HttpGet ("{name}")]
        public ActionResult<Cat> Get (string name) {
             return _context.GetACatByName(name);
        }
        [HttpGet ("{id}")]
        public ActionResult<Cat> Get (int id) {
             return _context.GetCatById(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post ([FromBody] Cat cat) {
             if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }
            _context.Post(cat);
            _context.SaveAll();
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