using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers {
    //
    [Route ("api/[controller]")]
    [ApiController]
    // *Controller. the * gives the name of the route
    public class TodoController : ControllerBase {
        private readonly TodoContext _context;

        public TodoController (TodoContext context) {
            _context = context;

            if (_context.TodoItems.Count () == 0) {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.TodoItems.Add (new TodoItem { Name = "Item1" });
                _context.SaveChanges ();
            }
        }

        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll () {
            return _context.TodoItems.ToList ();
        }

        //The [HttpGet] attribute denotes a method that responds to an HTTP GET request. The URL path for each method is constructed as follows:
        [HttpGet ("{id}", Name = "GetTodo")]
        public ActionResult<TodoItem> GetById (long id) {
            var item = _context.TodoItems.Find (id);
            if (item == null) {
                return NotFound ();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Post ([FromBody] TodoItem item) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }
            _context.Add (item);
            _context.SaveChanges ();
            return CreatedAtAction ("GetById", new { id = item.Id }, item);
        }

        [HttpPut ("{id}")]
        public IActionResult Update (long id, TodoItem item) {
            var todo = _context.TodoItems.Find (id);
            if (todo == null) {
                return NotFound ();
            }

            todo.IsComplete = item.IsComplete;
            todo.Name = item.Name;

            _context.TodoItems.Update (todo);
            _context.SaveChanges ();
            return NoContent ();
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete (long id) {
            var todo = _context.TodoItems.Find (id);
            if (todo == null) {
                return NotFound ();
            }

            _context.TodoItems.Remove (todo);
            _context.SaveChanges ();
            return NoContent ();
        }

    }
}