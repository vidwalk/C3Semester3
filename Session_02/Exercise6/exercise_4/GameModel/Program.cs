using GameModel;
using System;

class Program {
        static void Main (string[] args) {
            
            FlipRoll flipRoll = new FlipRoll();
            Combat combat = new Combat(flipRoll);
            Hero hero1 = new Hero{Strength = 10, HitPoints = 100, Defence = 1};
            Hero hero2 = new Hero{Strength = 20, HitPoints = 1, Defence = 1};
           
            System.Console.WriteLine(hero1.HitPoints);
            combat.Ambush(hero2, hero1, 1);
            System.Console.WriteLine(hero1.HitPoints);
            // Method swap was tested and fixed with ref
        }
}
