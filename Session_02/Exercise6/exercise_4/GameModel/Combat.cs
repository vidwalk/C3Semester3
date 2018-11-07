using System;

namespace GameModel
{
    public class Combat
    {
        public FlipRoll flipRoll;

        public Combat(FlipRoll flipRoll)
        {
            this.flipRoll = flipRoll;
        }
        /*
         * Two Heroes battle until a winner is found.
         */
        public void Battle(Hero hero1, Hero hero2)
        {
            var attacking = hero1;
            var defending = hero2;

            if (flipRoll.FlipCoin())
            {
                swap(ref attacking, ref defending);
            }

            while (attacking.IsAlive() && defending.IsAlive())
            {
                defending.Defend(attacking);
                swap(ref attacking, ref defending);
            }
        }

        private void swap(ref Hero attacking, ref Hero defending)
        {
            var temp = attacking;
            attacking = defending;
            defending = temp;
        }

        /* 
         * The attacking hero get to attack first, and will
         * get an extra attack if 20 is rolled.
         */
        public void Ambush(Hero attacking, Hero defending, int rollValue)
        {

            if (flipRoll.RollDice(rollValue) == rollValue)
            {
                defending.Defend(attacking);
            }

            while (attacking.IsAlive() && defending.IsAlive())
            {
                System.Console.WriteLine(defending.HitPoints);
                defending.Defend(attacking);
                swap(ref defending, ref attacking);
            }
        }

        /*
         * The attacking hero will succesfully deal damage without
         * getting hit if a 6'er is rolled.
         */
        public void HitAndRun(Hero attacking, Hero defending,int rollValue)
        {
            if (flipRoll.RollDice(rollValue) == rollValue)
            {
                defending.Defend(attacking);
            }
        }

    }

}