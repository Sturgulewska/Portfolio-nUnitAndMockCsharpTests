using CsharpConsoleTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    public class FizzBuzzTests
    {   
        public FizzBuzz fizzBuzz;
        [SetUp]
        public void CheckDevicePositiveNumberByThree()
        {
            //Arrange
          fizzBuzz = new FizzBuzz();
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(3);
            var expect = "Fizz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckDeviceNegativeNumberByThree()
        {
            //Arrange
           fizzBuzz = new FizzBuzz();
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-6);
            var expect = "Fizz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        //8 ntestów
        [Test]
        public void CheckDevicePositiveNumberByFive()
        {
            //Arrange
           fizzBuzz = new FizzBuzz();
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(5);
            var expect = "Buzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckDeviceNegativeNumberByFive()
        {
            //Arrange
          fizzBuzz = new FizzBuzz();
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-10);
            var expect = "Buzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckDevicePositiveNumberByFiveAndThree()
        {
            //Arrange
            fizzBuzz = new FizzBuzz();
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(15);

            var expect = "FizzBuzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckDeviceNegativeNumberByFiveAndThree()
        {
            //Arrange
            fizzBuzz = new FizzBuzz();
            //Act
            var actual = fizzBuzz.CheckFizzBuzz(-30);

            var expect = "FizzBuzz";
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckNotDevicePositiveNumberByFiveAndThree()
        {
            //Arrange
         fizzBuzz = new FizzBuzz();
            //Act
          //  var actual = fizzBuzz.CheckFizzBuzz(4);

            //Act and Assert
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(4));

        }
        [Test]
        public void CheckNotDeviceNegativeNumberByFiveAndThree()
        {
            //Arrange
         fizzBuzz = new FizzBuzz();
            //Act
            //  var actual = fizzBuzz.CheckFizzBuzz(4);

            //Act and Assert
            Assert.Throws<Exception>(() => fizzBuzz.CheckFizzBuzz(-7));
        }
        
    }
}
