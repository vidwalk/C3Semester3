using System;

namespace Exercise3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = Int32.Parse(Console.ReadLine());
            String message = "";
            message = (score > 1337) ? "This is a new highscore" : "You need more points to beat the highscore!";
            System.Console.WriteLine(message);
        }
    }
}
