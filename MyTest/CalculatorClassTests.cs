using System;
using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class CalculatorClassTests
    
    
    {
        
        
        [Test]
        public void CheckCreateObject()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = 2, Number2 = 9
            };
            //assert
            Assert.IsTrue(calculatorClassTest.Number1 == 2 && calculatorClassTest.Number2 == 9);
            Assert.IsInstanceOf(typeof(CalculatorClass), calculatorClassTest);
        }

        [Test]
        public void CheckAddPositiveNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = 9, Number2 = 10
            };
            //act
            var actual = calculatorClassTest.Add();
            var expect = 19;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckAddPositiveAndNegativeNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = 5, Number2 = -10
            };
            //act
            var actual = calculatorClassTest.Add();
            var expecte = -5;
            //assert
            Assert.AreEqual(expecte, actual);
        }

        [Test]
        public void CheckAddNegativeAndPositiveNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = -6, Number2 = 2
            };
            //act
            var actual = calculatorClassTest.Add();
            var expect = -4;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckAddNegativeNumber()
        {
            //arrange
            var calculatorTestClass = new CalculatorClass()
            {
                Number1 = -9, Number2 = -4
            };
            //act
            var actual = calculatorTestClass.Add();
            var expect = -13;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstructPositiveNumber()
        {
            //arrange
            var calculatorTestClass = new CalculatorClass()
            {
                Number1 = 6, Number2 = 3
            };
            //act
            var actual = calculatorTestClass.Substruct();
            var expect = 3;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void ChectSubstractPositiveAndNegativeNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = 9, Number2 = -6
            };
            //act
            var actual = calculatorClassTest.Substruct();
            var expect = 15;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstractNegativeAndPositiveNumber()
        {
            //arrange
            var calculatorTestClass = new CalculatorClass()
            {
                Number1 = -6, Number2 = 5
            };
            //act
            var actual = calculatorTestClass.Substruct();
            var expect = -11;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckSubstractNegativeNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = -3, Number2 = -6
            };
            //act
            var actual = calculatorClassTest.Substruct();
            var expect = 3;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayPositiveNumber()
        {
            //arrange
            var calculatorTestClass = new CalculatorClass()
            {
                Number1 = 2, Number2 = 3
            };
            //act
            var actual = calculatorTestClass.Multiply();
            var expect = 6;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayPositiveAndNegativeNumber()
        {
            //arrange
            var calculatorTestClass = new CalculatorClass()
            {
                Number1 = 5, Number2 = -2
            };
            //act
            var actual = calculatorTestClass.Multiply();
            var expect = -10;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayNegativeAndPositiveNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = -3, Number2 = 2
            };
            //act
            var actual = calculatorClassTest.Multiply();
            var expect = -6;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckMultiplayNegativeNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = -3, Number2 = -5
            };
            //act
            var actual = calculatorClassTest.Multiply();
            var expect = 15;
            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckDividePositiveNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = 4, Number2 = 2
            };
            //act
            var actual = calculatorClassTest.Divide();
            var expect = 2;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDividePositiveAndNegativeNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = 4, Number2 = -2
            };
            //act
            var actual = calculatorClassTest.Divide();
            var expect = -2;

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDivideNegativeAndPositiveNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = -6, Number2 = 3
            };
            //act 
            var actual = calculatorClassTest.Divide();
            var expect = -2;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDivideNegativeNumber()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = -6, Number2 = -3
            };
            //act
            var actual = calculatorClassTest.Divide();
            var expect = 2;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDividePositiveByZero()
        {
            var calculatorTest = new CalculatorClass()
            {
                Number1 = 2,
                Number2 = 0
            };
            //act

            // assert
            Assert.Throws<DivideByZeroException>(() => calculatorTest.Divide());
        }

        [Test]
        public void CheckDivideNegativeByZero()
        {
            //arrange
            var calculatorClassTest = new CalculatorClass()
            {
                Number1 = -3, Number2 = 0
            };
            //assert
            Assert.Throws<DivideByZeroException>(() => calculatorClassTest.Divide());
        }
    }
}