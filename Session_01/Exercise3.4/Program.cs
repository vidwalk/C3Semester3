using System;

namespace Exercise3._4
{
    class Player{
        public void Shout(String s)
        {
            System.Console.WriteLine(s);
        }
        public void Shout(int i)
        {
            System.Console.WriteLine(i + " is my lucky number!");
        }
        public void Shout(Enemy e)
        {
            System.Console.WriteLine( "The enemy can do "+ e.Damage + " damage to me.");
        }
    }

    public class Enemy
    {
        private int damage;

        public int Damage { get => damage; set => damage = value; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Enemy overwatchTeammate = new Enemy(){ Damage = 20};
            Player player = new Player();
            player.Shout("I AM CIO'GONC");
            player.Shout(9000);
            player.Shout(overwatchTeammate);
        }
    }
}
