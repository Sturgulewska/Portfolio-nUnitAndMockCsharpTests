using CsharpConsoleTest;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    class CalcTests
    {
        [Test]
        public void CheckCreateObject()
        {
            //mock
            var mock = new Mock<IRandomize>();

            //arrange 
            var calc = new Calc(2, 5, 7, 9, mock.Object, mock.Object);
            //act and assert
            Assert.IsInstanceOf(typeof(Calc), calc);
            Assert.IsTrue(calc.Number1 == 2 && calc.Number2 == 5 && calc.Number3 == 7 && calc.Number4 == 9 && calc.Randomize1 == mock.Object && calc.Randomize2 == mock.Object);
        }

        [Test]
        public void CheckAddTwoPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(2, 5)).Returns(4);
            mockNumber2.Setup(m => m.RandomNumber(7, 9)).Returns(8);

            var calc = new Calc(2, 5, 7, 9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Add();
            var expect = 12;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckAddPositiveAndNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(2, -5)).Returns(-3);
            mockNumber2.Setup(m => m.RandomNumber(7, -9)).Returns(-2);

            var calc = new Calc(2, -5, 7, -9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Add();
            var expect = -5;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckAddNegativeAndPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(-2, 5)).Returns(3);
            mockNumber2.Setup(m => m.RandomNumber(-7, 9)).Returns(2);

            var calc = new Calc(-2, 5, -7, 9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Add();
            var expect = 5;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckAddTwoNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(-2, -5)).Returns(-4);
            mockNumber2.Setup(m => m.RandomNumber(-7, -9)).Returns(-8);

            var calc = new Calc(-2, -5, -7, -9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Add();
            var expect = -12;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstracktTwoPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(2, 5)).Returns(4);
            mockNumber2.Setup(m => m.RandomNumber(7, 9)).Returns(8);

            var calc = new Calc(2, 5, 7, 9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Substruct();
            var expect = -4;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstracktPositiveAndNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(2, -5)).Returns(1);
            mockNumber2.Setup(m => m.RandomNumber(7, -9)).Returns(-7);

            var calc = new Calc(2, -5, 7, -9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Substruct();
            var expect = 8;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstracktNegativeAndPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(-2, 5)).Returns(-1);
            mockNumber2.Setup(m => m.RandomNumber(-7, 9)).Returns(7);

            var calc = new Calc(-2, 5, -7, 9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Substruct();
            var expect = -8;

            //assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckSubstracktNegativeAndNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(-2, -5)).Returns(-4);
            mockNumber2.Setup(m => m.RandomNumber(-7, -9)).Returns(-8);

            var calc = new Calc(-2, -5, -7, -9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Substruct();
            var expect = 4;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayTwoPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(2, 5)).Returns(4);
            mockNumber2.Setup(m => m.RandomNumber(7, 9)).Returns(8);



            var calc = new Calc(2, 5, 7, 9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Multiply();
            var expect = 32;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayPositiveAndNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(2, -5)).Returns(1);
            mockNumber2.Setup(m => m.RandomNumber(7, -9)).Returns(-6);



            var calc = new Calc(2, -5, 7, -9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Multiply();
            var expect = -6;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayNegativeAndPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(-3, 5)).Returns(-2);
            mockNumber2.Setup(m => m.RandomNumber(-7, 9)).Returns(5);



            var calc = new Calc(-3, 5, -7, 9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Multiply();
            var expect = -10;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayNegativeAndNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(-3, -5)).Returns(-4);
            mockNumber2.Setup(m => m.RandomNumber(-7, -9)).Returns(-8);



            var calc = new Calc(-3, -5, -7, -9, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Multiply();
            var expect = 32;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDivideTwoPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(10, 13)).Returns(12);

            mockNumber2.Setup(m => m.RandomNumber(2, 6)).Returns(4);

            var calc = new Calc(10, 13, 2, 6, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Divide();
            var expect = 3;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDividePositiveAndNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();
            mockNumber1.Setup(m => m.RandomNumber(10, -13)).Returns(8);

            mockNumber2.Setup(m => m.RandomNumber(2, -6)).Returns(-4);
            var calc = new Calc(10, -13, 2, -6, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Divide();
            var expect = -2;

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckDivideNegativeAndPositiveNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();

            mockNumber1.Setup(m => m.RandomNumber(-10, 13)).Returns(-8);

            mockNumber2.Setup(m => m.RandomNumber(-2, 6)).Returns(4);



            var calc = new Calc(-10, 13, -2, 6, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Divide();
            var expect = -2;

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckDivideNegativeAndNegativeNumber()

        {
            var mockNumber1 = new Mock<IRandomize>();
            var mockNumber2 = new Mock<IRandomize>();


            mockNumber1.Setup(m => m.RandomNumber(-10, -13)).Returns(-12);
            mockNumber2.Setup(m => m.RandomNumber(-2, -6)).Returns(-4);



            var calc = new Calc(-10, -13, -2, -6, mockNumber1.Object, mockNumber2.Object);

            //act
            var actual = calc.Divide();
            var expect = 3;

            //assert
            Assert.AreEqual(expect, actual);
        }











        /*
        var mock = new Mock<ICalculatorClass>(); // atrapa interfejsu
        var fizzBuzz = new FizzBuzzClass(mock.Object, 2, 4);
        //act and assert
        Assert.IsTrue(fizzBuzz.Number1 == 2 && fizzBuzz.Number2 == 4 && fizzBuzz._calculatorClass == mock.Object);
            Assert.IsInstanceOf(typeof(FizzBuzzClass), fizzBuzz);

                    mock.Setup(m => m.Multiply(3, 9)).Returns(27); // metoda multiplay podstawi zawsze 27

          */
    }
}
