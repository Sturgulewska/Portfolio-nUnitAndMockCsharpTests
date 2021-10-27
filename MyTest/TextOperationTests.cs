using CsharpConsoleTest;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    class TextOperationTests
    {
        [Test]
        public void CheckCreateObject()
        {
            //mock
            var mock = new Mock<ILengthOperation>();

            //arrange 
            var textOperation = new TextOperation(mock.Object, "auuu", "auu");
            //act and assert
            Assert.IsInstanceOf(typeof(TextOperation), textOperation);
            Assert.IsTrue(textOperation.Text1 == "auuu" && textOperation.Text2 == "auu" && textOperation.LengthOperation == mock.Object);
        }


        [Test]
        public void CheckTwoStringWhenItIsPalindrome()

        {
            //mock
            var mock = new Mock<ILengthOperation>();

            mock.Setup(m => m.CompareLength("kajak", "kajak")).Returns(true);
            
            var textOperation = new TextOperation(mock.Object, "kajak", "kajak");

            //act
            var actual = textOperation.GetNameCompare();
            var expect = "Palindrom";

            //assert
            Assert.AreEqual(expect, actual);
        }


        //markotny
        [Test]
        public void CheckTwoStringWhenItIsAnagram()

        {
            //mock
            var mock = new Mock<ILengthOperation>();

            mock.Setup(m => m.CompareLength("markotny", "romantyk")).Returns(true);

            var textOperation = new TextOperation(mock.Object, "markotny", "romantyk");

            //act
            var actual = textOperation.GetNameCompare();
            var expect = "Anagram";

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckTwoStringWhenOneIsPalindrome()

        {
            //mock
            var mock = new Mock<ILengthOperation>();

            mock.Setup(m => m.CompareLength("kajak", "Andrzej")).Returns(true);

            var textOperation = new TextOperation(mock.Object, "kajak", "Andrzej");

            //act
            var actual = textOperation.GetNameCompare();
            var expect = "Brak";

            //assert
            Assert.AreEqual(expect, actual);
        }

        public void CheckTwoStringWhenOneIsAnagram()

        {
            //mock
            var mock = new Mock<ILengthOperation>();

            mock.Setup(m => m.CompareLength("markotny", "Andrzej")).Returns(true);

            var textOperation = new TextOperation(mock.Object, "markotny", "Andrzej");

            //act
            var actual = textOperation.GetNameCompare();
            var expect = "Brak";

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckTwoStringWhenItIsNotPalindromeAndAnagram()

        {
            //mock
            var mock = new Mock<ILengthOperation>();

            mock.Setup(m => m.CompareLength("Anna", "Andrzej")).Returns(false);

            var textOperation = new TextOperation(mock.Object, "Anna", "Andrzej");

            //assert
            Assert.Throws<Exception>(() => textOperation.GetNameCompare());

           // Assert.Throws<Exception>(() => randomize.RandomNumber(2, -4));



        }

    }
}
