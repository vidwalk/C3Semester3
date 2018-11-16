using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Tier3ServerDatabase.common;

namespace Tier3ServerDatabase.database{
    public class RepositoryDatabaseAdapter{
        private readonly DatabaseAdapter _context;

        //Initializing the Repository with the proper dbcontext
        public RepositoryDatabaseAdapter(DatabaseAdapter context)
        {
            _context = context;
        }

        // Method for getting a list of all the movies
        public List<Movie> getAllMovies()
        {
            return _context.movies.ToList();
        }

        // Getting a string of all the movies
        public String getStringMovies()
        {
            String result = "";
             foreach(Movie m in getAllMovies())
            {
                result = result + m.ToString();
            }
            return result;
        }

        //Method for adding a Movie to the database
        public bool addMovie(Movie movie)
        {
            _context.Add(movie);
           return SaveAll();
        }

        //Method to save all the data inputted
        public bool SaveAll () {
            return _context.SaveChanges () > 0;
        }
    }
}