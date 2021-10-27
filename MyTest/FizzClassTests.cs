using System;
using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class FizzClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            var fizzBuzzObject = new FizzClass(2);
            // acctual
            // assert
            Assert.IsTrue(fizzBuzzObject.Number==2);
            Assert.IsInstanceOf(typeof(FizzClass), fizzBuzzObject);
        }
        
        
        [Test]
        public void CheckDividePositiveNumberByThree()
        {
            //arrange
            var fizzBuzzObject = new FizzClass(9);

            //act
            var actual = fizzBuzzObject.CheckFizzBuzz();
            var expect = "Fizz";
            //assert
            Assert.AreEqual(expect, actual );
        }

        [Test]
        public void CheckDivideNegativeNumberByThree()
        {//arrange
            var fizzBuzzTest = new FizzClass(-9);
            //act
            var actual = fizzBuzzTest.CheckFizzBuzz();
            var expecte = "Fizz";
            //assert
            Assert.AreEqual(expecte, actual);
        }

        [Test]
        public void CheckDividePositiveNumberByFive()
        {
            var fizzBuzzObject = new FizzClass(10);

            //act
            var actual = fizzBuzzObject.CheckFizzBuzz();
            var expect = "Buzz";
            
            Assert.AreEqual(expect, actual );
        }

        [Test]
        public void CheckDivideNegativeNumberByFive()
        {//arrange
            var fizzBuzzTest = new FizzClass(-10);
            //act
            var actual = fizzBuzzTest.CheckFizzBuzz();
            var expect = "Buzz";
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDividePositiveNumberByFiveAndThree()
        {
            //arrange
            var fizzBuzzTest = new FizzClass(15);
            //act
            var actual = fizzBuzzTest.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDivideNegativeNumberByFiveAndThree()
        {
            //arrange
            var fizzBuzzTest = new FizzClass(-15);
            //act
            var actual = fizzBuzzTest.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckNotDevicePositiveNumberByFiveAndThree()
        {
            //Arrange
            var fizzBuzzClass = new FizzClass(4);

            //Act and Assert
            Assert.Throws<Exception>(() => fizzBuzzClass.CheckFizzBuzz());

        }
        [Test]
        public void CheckNotDeviceNegativeNumberByFiveAndThree()
        {
            //arrange
            var fizzBuzzTest = new FizzClass(-7);
            //assert
            Assert.Throws<Exception>(() => fizzBuzzTest.CheckFizzBuzz());
        }


        
    }
}