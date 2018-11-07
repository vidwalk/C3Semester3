using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat(1, "Meow", "Caca", 30, DateTime.Today, "Tuna");
            Cat cat = new Cat{ Id = 1, Name = "Meow", Color = "Caucasian", Price = 30, FavoriteDish = "Tuna", Birthdate = DateTime.UtcNow };
           System.Console.WriteLine(cat.Name);
        }
    }
}
