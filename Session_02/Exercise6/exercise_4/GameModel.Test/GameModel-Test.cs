using System;
using Xunit;

namespace GameModel.Test
{
    public class GameModelTest
    {
        [Fact]
        public void Battle_HitPointsAre0InHarmlessHero_ShouldReturnTrue()
        {
            //Arrange
            FlipRoll flipRoll = new FlipRoll();
            Combat combat = new Combat(flipRoll);
            Hero hero1 = new Hero{Strength = 4, HitPoints = 1, Defence = 1};
            Hero hero2 = new Hero{Strength = 2, HitPoints = 1, Defence = 1};
            //Act
            combat.Battle(hero1, hero2);
            //Assert
           Assert.True(hero2.HitPoints == 0);
        }
        [Fact]
        public void Battle_HitPointsAre0InOneHero_ShouldReturnTrue()
        {
            //Arrange
            FlipRoll flipRoll = new FlipRoll();
            Combat combat = new Combat(flipRoll);
            Hero hero1 = new Hero{Strength = 4, HitPoints = 1, Defence = 1};
            Hero hero2 = new Hero{Strength = 4, HitPoints = 1, Defence = 1};
            //Act
            combat.Battle(hero1, hero2);
            //Assert
           Assert.True(hero2.HitPoints == 0 || hero1.HitPoints == 0);
        }

        [Fact]
        public void Ambush_HitPointsAre0InAmbushedHeroWhenRollIs1_ShouldReturnTrue()
        {
            //Arrange
            FlipRoll flipRoll = new FlipRoll();
            Combat combat = new Combat(flipRoll);
            Hero hero1 = new Hero{Strength = 10, HitPoints = 4, Defence = 0};
            Hero hero2 = new Hero{Strength = 4, HitPoints = 1, Defence = 1};
            //Act
            combat.Ambush(hero2, hero1, 1);
            //Assert
           Assert.Equal(0, hero1.HitPoints); //Added ref to fix Method swap wasn't working because it changed just the thing inside the method
           //also added rollValue to make it easier to test and have more control over the randomness
        }
        [Fact]
        public void HitAndRun_HitPointsAre0InHitHeroWhenRollIs1_ShouldReturnTrue()
        {
            //Arrange
            FlipRoll flipRoll = new FlipRoll();
            Combat combat = new Combat(flipRoll);
            Hero hero1 = new Hero{Strength = 10, HitPoints = 2, Defence = 0};
            Hero hero2 = new Hero{Strength = 4, HitPoints = 1, Defence = 1};
            //Act
            combat.HitAndRun(hero2, hero1, 1);
            //Assert
           Assert.True(hero2.HitPoints > 0); 
           Assert.Equal(0, hero1.HitPoints);

        }
    }
}
