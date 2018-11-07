using System;
using Xunit;

namespace fizzbuzz.Test
{
    public class FizzBuzzTest
    {
        // Zero
        [Fact]
        public void CreateAStringFizzBuzzObject_ShouldCreateObject()
        {
            //Arrange
            StringFizzBuzz fizzbuzz = new StringFizzBuzz(0);
            //Act
            
            //Assert
            Assert.NotNull(fizzbuzz);
        }

        //One
        [Fact]
        public void CreateASpecialStringWithStringFizzBuzzObject_ShouldCreateString()
        {
            //Arrange
            StringFizzBuzz fizzbuzz = new StringFizzBuzz(0);
            //Act
            string result = fizzbuzz.SpecialNumbering();
            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void CreateASpecialStringWithStringFizzBuzzObjectThatGets1_ShouldCreateStringWithNumber1()
        {
            //Arrange
            StringFizzBuzz fizzbuzz = new StringFizzBuzz(1);
            //Act
            string result = fizzbuzz.SpecialNumbering();
            //Assert
            Assert.Equal("1",result);
        }

        // Many/More

        [Fact]
        public void CreateASpecialStringWithStringFizzBuzzObjectThatGets2_ShouldCreateStringWithNumber1And2()
        {
            //Arrange
            StringFizzBuzz fizzbuzz = new StringFizzBuzz(2);
            //Act
            string result = fizzbuzz.SpecialNumbering();
            //Assert
            Assert.Equal("1, 2",result);
        }

        //Boundary Behaviors
        [Fact]
        public void CreateASpecialStringWithStringFizzBuzzObjectThatGets3_ShouldCreateStringWithFizz()
        {
            //Arrange
            StringFizzBuzz fizzbuzz = new StringFizzBuzz(3);
            //Act
            string result = fizzbuzz.SpecialNumbering();
            //Assert
            Assert.Equal("1, 2, Fizz",result);
        }

        [Fact]
        public void CreateASpecialStringWithStringFizzBuzzObjectThatGets5_ShouldCreateStringWithBuzz()
        {
            //Arrange
            StringFizzBuzz fizzbuzz = new StringFizzBuzz(5);
            //Act
            string result = fizzbuzz.SpecialNumbering();
            //Assert
            Assert.Equal("1, 2, Fizz, 4, Buzz",result);
        }

        [Fact]
        public void CreateASpecialStringWithStringFizzBuzzObjectThatGets15_ShouldCreateStringWithFizzBuzz()
        {
            //Arrange
            StringFizzBuzz fizzbuzz = new StringFizzBuzz(15);
            //Act
            string result = fizzbuzz.SpecialNumbering();
            //Assert
            Assert.Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz", result);
        }

    }
}
