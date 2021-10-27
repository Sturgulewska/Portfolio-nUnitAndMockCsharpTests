using CsharpConsoleTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    class LengthTests
    {
        [Test]
        public void CheckCreateObject()
        {
            //arrange
            var lengthOperation = new LengthOperation();

            //assert
            Assert.IsInstanceOf(typeof(LengthOperation), lengthOperation);
        }

        [Test]
        public void CheckObjectWhenStringLengthIsTheSame()
        {
            //arrange
            var lengthOperation = new LengthOperation();

            //act
            var actual = lengthOperation.CompareLength("auuu", "anka");
            var expect = true;


            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void CheckObjectWhenStringLengthIsNotTheSame()
        {
            //arrange
            var lengthOperation = new LengthOperation();

            //act
            var actual = lengthOperation.CompareLength("auuu", "apteka");
            var expect = false;


            //assert
            Assert.IsFalse(actual);
        }

    }
}
