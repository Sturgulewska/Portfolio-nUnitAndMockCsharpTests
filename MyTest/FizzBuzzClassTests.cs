using CsharpConsoleTest;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    class FizzBuzzClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            //arrange
            var mock = new Mock<ICalculatorClass>(); // atrapa interfejsu
            var fizzBuzz = new FizzBuzzClass(mock.Object, 2, 4);
            //act and assert
            Assert.IsTrue(fizzBuzz.Number1 == 2 && fizzBuzz.Number2 == 4 && fizzBuzz._calculatorClass == mock.Object);
            Assert.IsInstanceOf(typeof(FizzBuzzClass), fizzBuzz);

        }
        [Test]
        public void CheckDividePositiveNumberByThree()
        {
            //arrange
            var mock = new Mock<ICalculatorClass>(); // atrapa interfejsu
            mock.Setup(m => m.Substruct(9, 6)).Returns(3); // metoda multiplay podstawi zawsze 27
            var fizzBuzz = new FizzBuzzClass(mock.Object, 9, 6);
            //act
            var actual = fizzBuzz.CheckFizzBuzz();
            var expect = "Fizz";
            //assert
            Assert.AreEqual(expect, actual);
        }
        public void CheckDividePositiveNumberByFive() {
            //arrange
            var mock = new Mock<ICalculatorClass>(); // atrapa interfejsu, mock tylko w przypadku interfejsów!!
            mock.Setup(m => m.Multiply(5, 10)).Returns(50); 
            var fizzBuzz = new FizzBuzzClass(mock.Object, 5, 10);
            //act
            var actual = fizzBuzz.CheckFizzBuzz();
            var expect = "Buzz";
            //assert
            Assert.AreEqual(expect, actual);
        }

        public void CheckDividePositiveNumberByFiveAndThree()
        {
            //arrange
            var mock = new Mock<ICalculatorClass>(); // atrapa interfejsu, mock tylko w przypadku interfejsów!!
            mock.Setup(m => m.Add(15, 10)).Returns(25); 
            var fizzBuzz = new FizzBuzzClass(mock.Object, 15, 10);
            //act
            var actual = fizzBuzz.CheckFizzBuzz();
            var expect = "FizzBuzz";
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}

