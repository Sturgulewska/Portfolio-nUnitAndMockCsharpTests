using System;
using System.Collections.Generic;
using System.Text;
using CsharpConsoleTest;
using NUnit;
using NUnit.Framework;

namespace MyTests
{
    public class CalculatorTests
    
    //CheckCreativeObject - > instanceOf
    {
        public Calculator calculator;
        [SetUp]
        public void CheckCreateObject()
        {
            //arrange
            calculator = new Calculator();
            //act
            //assert
            Assert.IsInstanceOf(typeof(Calculator), calculator);
        }

        [Test]
        public void CheckAddTwoPosituveNumbers()
        {
            //Arrange
           // var calculator = new Calculator();
            //Act
            var actual = calculator.Add(5, 6);
            var expect = 11;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckAddTwoNegativeNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Add(-5, -6);
            var expect = -11;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckAddNegativePositiveNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Add(-5, 6);
            var expect = 1;
            //Assert
            Assert.IsTrue(expect == actual);
        }

        [Test]
        public void CheckAddPositiveNegativeNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Add(5, -6);
            var expect = -1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstructTwoPosituveNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Substruct(5, 6);
            var expect = -1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstructTwoNegativeNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Substruct(-5, -6);
            var expect = 1;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstrctNegativePositiveNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Substruct(-5, 6);
            var expect = -11;
            //Assert
            Assert.AreEqual(expect,actual);
        }

        [Test]
        public void CheckSubstructPositiveNegativeNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Substruct(5, -6);
            var expect = 11;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplyTwoPosituveNumbers()
        {
            //Arrange
          //  calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(5, 6);
            var expect = 30;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplyTwoNegativeNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(-5, -6);
            var expect = 30;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplyNegativePositiveNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(-5, 6);
            var expect = -30;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplyPositiveNegativeNumbers()
        {
            //Arrange
          //  calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(5, -6);
            var expect = -30;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDivideTwoPosituveNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Divide(10, 2);
            var expect = 5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDivideTwoNegativeNumbers()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act
            var actual = calculator.Divide(-15, -3);
            var expect =5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDivideNegativePositiveNumbers()
        {
            //Arrange
       //     calculator = new Calculator();
            //Act
            var actual = calculator.Divide(-15, 5);
            var expect = -3;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDividePositiveNegativeNumbers()
        {
            //Arrange
        //    calculator = new Calculator();
            //Act
            var actual = calculator.Divide(50, -10);
            var expect = -5;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDividePositiveByZero()
        {
            //Arrange
          //  calculator = new Calculator();
            //Act//Assert
            Assert.Throws<DivideByZeroException>(()=>calculator.Divide(5,0));
        }

        [Test]
        public void CheckDivideNegativeByZero()
        {
            //Arrange
         //   calculator = new Calculator();
            //Act//Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(-5, 0));
        }

        [Test]
        public void CheckDivideZeroByZero()
        {
            //Arrange
          //  calculator = new Calculator();
            //Act//Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(0, 0));
        }

    }
}
