using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace Server.Entities {
    public class CatRepository {
        private readonly CatContext _context;

        public CatRepository(CatContext context)
        {
            _context = context;
        }

        public IEnumerable<Cat> GetAllCats()
        {
            return _context.cats.ToList();
        }

        public Cat GetACatByName(string name)
        {
            return _context.cats.Single(c => c.Name.Equals(name));
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}