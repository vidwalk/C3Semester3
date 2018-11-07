using System;

public class FlipRoll : CoinDice
{
    public bool FlipCoin()
        {
            var rnd = new Random();
            return (rnd.Next(2) == 0);
        }

        public int RollDice(int sides)
        {
            var rnd = new Random();
            return rnd.Next(sides) + 1;
        }
}