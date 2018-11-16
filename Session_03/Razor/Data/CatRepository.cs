using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Server.Entities {
    public class CatRepository {
        private readonly CatContext _context;

        public CatRepository (CatContext context) {
            _context = context;
            DbInitializer.Initialize (_context);
        }

        public List<Cat> GetAllCats () {
            return _context.cats.ToList ();
        }
        public Cat GetACatByName (string name) {
            return _context.cats.Single (c => c.Name.Equals (name));
        }

        public Cat GetCatById (int id) {
            return _context.cats.Single (c => c.Id.Equals (id));
        }
        public void Post (Cat cat) {
             
            _context.Add (cat);
         }
        public bool SaveAll () {
            return _context.SaveChanges () > 0;
        }
    }
}