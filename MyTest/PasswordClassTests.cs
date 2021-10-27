using System;
using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class PasswordClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            //arrange
            var passwordClassTest = new PasswordClass()
            {
        MyPassword = "Anto$128"
            };
            //assert
            Assert.IsTrue(passwordClassTest.MyPassword=="Anto$128");
            Assert.IsInstanceOf(typeof(PasswordClass), passwordClassTest);
        }
        [Test]
        public void CheckCorrectPassword()
        {
            //arrange
            var passwordClassTest = new PasswordClass()
            {
                MyPassword = "Anto$128"
            };
            //act 
            var actual = passwordClassTest.CheckPassword();
            var expected = true;
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void CheckPasswordWithoutEigthCharacters()
        {
            //arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Ato$128"
            };
            //act 
            var actual = passwordClass.CheckPassword();
            //var expect = false;
            // assert
            Assert.IsFalse(actual);
            //Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckPasswordWithoutBigLetter(){
            //arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "atos$123"
            };
            //act
            var actual = passwordClass.CheckPassword();
            //var expect = false
            //assert
            Assert.IsFalse(actual);
        }
        
        [Test]
        public void CheckPasswordWithoutSpecialCharacter()
        {
            //arrange
            var passwordClass = new PasswordClass()
            {
                MyPassword = "Atoss123"
            };
                //act
                var actual = passwordClass.CheckPassword();
                //assert
                Assert.IsFalse(actual);
        }
        [Test]
        public void CheckPasswordWithoutNumbers()
        {
         //arrange
         var passwordClass = new PasswordClass()
         {
             MyPassword = "Atos#$%$"
         };
         //act
         var actual = passwordClass.CheckPassword();
             //assert
             Assert.IsFalse(actual);
        }
        [Test]
        public void CheckPasswordWithoutSmallLetter()
        {
         //arrange
         var passwordClass = new PasswordClass()
         {
             MyPassword = "ATOS#123"
         };
         //act
         var actual = passwordClass.CheckPassword();
         //assert
         Assert.IsFalse(actual);
        }
    }
}