using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using CsharpConsoleTest;

namespace MyTests
{
    class NumerManagerTests
    {
        public NumbersManager numbersManager;
        [SetUp]
        public void CheckCreateObject()
        {
            //arrange
            numbersManager = new NumbersManager();
            //act
            //assert
            Assert.IsInstanceOf(typeof(NumbersManager), numbersManager);
        }

        [Test]
        public void CheckAscendingly()
        {

            var numberList = new List<int>() { 5, 3, 8, 4, 1, 8 };

            //act
            var actual = numbersManager.SortNumbers( numberList, true);
            var expect = new List<int>() { 1, 3, 4, 5, 8, 8 };
            //assert
            Assert.AreEqual(expect, actual);
        }



        [Test]
        public void CheckDescendingList()
        {

            var numberList = new List<int>() { 5, 3, 8, 4, 1, 8 };

            //act
            var actual = numbersManager.SortNumbers(numberList, false);
            var expect = new List<int>() {8, 8, 5, 4, 3, 1};
            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckListWithOnlyZero()
        {

            var numberList = new List<int>() { 0, 0, 0, 0, 0, 0 };

            Assert.Throws<Exception>(()=> numbersManager.SortNumbers(numberList, true));
        }


        [Test]
        public void CheckListWithZeroAndNegativeNumber()
        {

            var numberList = new List<int>() { 0, 0, 0, -1,-8, -1000 };

            Assert.Throws<Exception>(() => numbersManager.SortNumbers(numberList, true));
        }


        [Test]
        public void CheckListWithZeroAndPositiveNumber()
        {

            var numberList = new List<int>() { 0, 0, 0, 1, 8, 1000 };

            Assert.Throws<Exception>(() => numbersManager.SortNumbers(numberList, true));
        }

        [Test]
        public void CheckListWithPositiveAndNegativeNumber()
        {

            var numberList = new List<int>() { -8, -7, -4, 1, 8, 1000 };

            Assert.Throws<Exception>(() => numbersManager.SortNumbers(numberList, true));
        }

        [Test]
        public void CheckListWithNegativeNumber()
        {

            var numberList = new List<int>() { -8, -7, -4, -1, -8, -10 };

            Assert.Throws<Exception>(() => numbersManager.SortNumbers(numberList, true));
        }


    }
}
