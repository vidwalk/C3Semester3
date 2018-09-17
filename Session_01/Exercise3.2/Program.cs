using System;

namespace Exercise3._2 {
    interface IExplodable<T> {
        void Explode (T radius);
    }
    class Bomb : IExplodable<double>
    {
        public void Explode(double radius)
        {
            System.Console.WriteLine("BOOM!");
            System.Console.WriteLine("The explosion has the radius of " + radius + "km");
        }
    }
    class Program {
        static void Main (string[] args) {
            Bomb bomb = new Bomb();
            bomb.Explode(30);
            bomb.Explode(300);
            bomb.Explode(3000);
            System.Console.WriteLine("The world is gone");
        }
    }
}