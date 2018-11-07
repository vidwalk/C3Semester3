using System;
using Xunit;

namespace GameModel.Tests {
    public class HeroTest {
        [Theory]
        [InlineData (1)]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue (int value) {
            // Arrange
            Hero hero = new Hero { HitPoints = value };
            // Act
            Boolean result = hero.IsAlive ();
            // Assert
            Assert.True (result);
        }

        [Theory]
        [InlineData (0)]
        public void IsAlive_HitPointsAreZero_ShouldReturnFalse (int value) {
            // Arrange
            Hero hero = new Hero { HitPoints = value };
            // Act
            Boolean result = hero.IsAlive ();
            // Assert
            Assert.False (result);
        }

        [Theory]
        [InlineData (-1)]
        public void IsAlive_HitPointsAreBelowZero_ShouldReturnFalse (int value) {
            // Arrange
            Hero hero = new Hero { HitPoints = value };
            // Act
            Boolean result = hero.IsAlive ();
            // Assert
            Assert.False (result);
        }

        [Fact]
        public void Attack_NotAlive_ShouldReturnZero () {
            // Arrange
            Hero hero = new Hero ();
            // Act
            int result = hero.Attack ();
            // Assert
            Assert.Equal (0, result);
        }

        [Theory]
        [InlineData (4)]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly (int value) {
            // Arrange
            Hero hero = new Hero { Strength = value };
            // Act
            int result = hero.Attack ();
            // Assert
            Assert.Equal (hero.Strength / 2, result);
        }

        [Theory]
        [InlineData (1)]
        public void Attack_WithWeaponWithAttackOne_ShouldReturnAttackValue (int value) {
            // Arrange
            Hero hero = new Hero { Strength = 4, MainHandWeapon = new Weapon { Attack = value } };
            // Act
            int result = hero.Attack ();
            // Assert
            Assert.Equal (hero.Attack (), result);
        }

        [Fact]
        public void Attack_WithWeapon_ShouldReturnAttackValue () {
            // Arrange
            Hero hero = new Hero { Strength = 4, MainHandWeapon = new Weapon { Attack = 2 } };
            // Act
            int result = hero.Attack ();
            // Assert
            Assert.Equal (hero.Attack (), result);
        }

        [Theory]
        [InlineData (0,2)]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints (int value, int hitpointsValue) {
            // Arrange
            Hero hero = new Hero { Strength = 4, HitPoints = hitpointsValue, Defence = value };
            Hero villain = new Hero { Strength = 2 };
            // Act
            int check = hero.HitPoints - villain.Attack () + hero.Defence;
            hero.Defend (villain);
            int result = hero.HitPoints;
            // Assert
            Assert.Equal (check, result);
        }

        [Theory]
        [InlineData (1)]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints (int value) {
            // Arrange
            Hero hero = new Hero { Strength = 4, HitPoints = 2, Defence = value };
            Hero villain = new Hero { Strength = 4 };
            // Act
            int check = hero.HitPoints - villain.Attack () + hero.Defence;
            hero.Defend (villain);
            int result = hero.HitPoints;
            // Assert
            Assert.Equal (check, result);
        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero () {
            // Arrange
            Hero hero = new Hero { Strength = 4, HitPoints = 2, Defence = 1 };
            Hero villain = new Hero { Strength = 6 };
            // Act
            int check = hero.HitPoints - villain.Attack () + hero.Defence;
            hero.Defend (villain);
            int result = hero.HitPoints;
            // Assert
            Assert.False (result < 0);
        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException () {
            // Arrange
            Hero hero = new Hero { Strength = 4, HitPoints = 2, Defence = 1 };
            Hero villain = null;
            // Act
            // Assert
            Assert.Throws<ArgumentNullException> (() => hero.Defend (villain));
        }
    }
}