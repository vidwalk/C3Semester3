using System;
using System.Linq;
using Server;
using Server.Entities;

namespace Server{
    public static class DbInitializer
    {
        public static void Initialize(CatContext context)
        {
            context.Database.EnsureCreated();
            
             if(context.cats.Any())
            {
                return;
            }
            
            var cats = new Cat[]
            {
                new Cat{  Name = "MeowMeow1", Color = "Caucasian", Price = 400, FavoriteDish = "Tuna", Birthdate = DateTime.Today },
                new Cat{  Name = "MeowMeow2", Color = "AfricanAmerican", Price = 500, FavoriteDish = "Tuna", Birthdate = DateTime.Today},
                new Cat{  Name = "MeowMeow3", Color = "Asian", Price = 450, FavoriteDish = "Tuna", Birthdate = DateTime.Today}
            };
            foreach(Cat p in cats)
            {
                context.Add(p);
            }
            context.SaveChanges();
        }
    }
}