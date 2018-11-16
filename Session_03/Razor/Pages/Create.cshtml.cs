using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Server.Entities;

namespace RazorPagesContacts.Pages
{
    public class CreateModel : PageModel
    {
        private readonly CatRepository _db;
        

        public CreateModel(CatRepository db)
        {
            _db = db;
        }

        [BindProperty]
        public Cat Cat { get; set; }
        public List<Cat> Cats{get; set;}

        public IActionResult OnPost()
        {
            _db.Post(Cat);
            _db.SaveAll();
            return RedirectToPage("/Index");
        }
        

        public void OnGet()
        {
            Cats = _db.GetAllCats();
        }
    }
}