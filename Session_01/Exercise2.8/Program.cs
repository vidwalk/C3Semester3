using System;

namespace Exercise2._8 {
    class Gun {
        public static int gunCount;
        public static int bulletCount;
        private int shotsFired;
        public Gun () {
            gunCount++;
        }

        public int ShotsFired { get => shotsFired; set => shotsFired = value; }

        public void Shoot () {
            ShotsFired++;
            System.Console.WriteLine ("BANG!");
            bulletCount++;
        }
    }
    class Program {
        static void Main (string[] args) {
            Gun gun1 = new Gun ();
            Gun gun2 = new Gun ();
            Gun gun3 = new Gun ();
            gun1.Shoot ();
            gun2.Shoot ();
            gun3.Shoot ();
            gun1.Shoot ();
            gun3.Shoot ();
            System.Console.WriteLine ("Bullets Shot: " + Gun.bulletCount);
            System.Console.WriteLine ("Bullets shot by Gun 1: " + gun1.ShotsFired);
            System.Console.WriteLine ("Bullets shot by Gun 2: " + gun2.ShotsFired);
        }
    }
}