using CsharpConsoleTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTests
{
    class RandomizeTests
    {
        Randomize randomize;

        [SetUp]
        public void CheckCreateObject()
        {
            //arrange
            var random = new Random();
            randomize = new Randomize(random);

            //act and assert
            Assert.IsInstanceOf(typeof(Randomize), randomize);
            Assert.IsTrue(randomize._random == random);

        }
        [Test]
        public void CheckRandomPositiveNumber()
        {

            //act
            var actual = randomize.RandomNumber(2, 4);
            //assert
            Assert.IsTrue(actual >= 2 && actual < 4);

        }
        [Test]
        public void CheckRandomNegativeNumber()
        {
            //actual
            var actual = randomize.RandomNumber(-4, -2);
            //assert
            Assert.IsTrue(actual >= -4 && actual < -2);
        }
        [Test]
        public void CheckRandomPositiveAndNegativeNumber()
        {
            //act
            //assert
            Assert.Throws<Exception>(()=> randomize.RandomNumber(2, -4));
        }

        [Test]
        public void CheckRandomNegativeAndPositiveNumber()
        {
            //act
            var actual = randomize.RandomNumber(-2, 4);
            //assert
            Assert.IsTrue(actual >= -2 && actual < 4);

        }
        [Test]
        public void CheckThrowExceptionForNegativeNumber()
        {
            //assert
            Assert.Throws<Exception>(() => randomize.RandomNumber(-50, -100));
        }

        [Test]
        public void CheckThrowExceptionForPositiveNumber()
        {
            //assert
            Assert.Throws<Exception>(() => randomize.RandomNumber(2000, 100));
        }

        [Test]
        public void CheckThrowExceptionForPositiveAndNegativeNumber()
        {
            //assert
            Assert.Throws<Exception>(() => randomize.RandomNumber(2000, -10));
        }


        [Test]
        public void CheckThrowExceptionForNegativeAndPositiveNumber()

        {
            //act
            var actual = randomize.RandomNumber(-5, 15);
            //assert
            Assert.IsTrue(actual >= -5 && actual < 15);
        }

        [Test]
        public void CheckRandomUpperString()
        {
            //act
            var actual = randomize.RandomString(12, false);
            //assert
            Assert.IsTrue(actual.Length == 12 && actual.All(char.IsUpper));
        }
        [Test]
        public void CheckRandomLowerString()
        {
            var actual = randomize.RandomString(6, true);

            //assert
            Assert.IsTrue(actual.Length == 6 && actual.All(char.IsLower));
        }

        //Random Password


        [Test]
        public void CheckRandomPasswordWithNumbers()
        {
            //act
            var actual = randomize.RandomPassword(true, false, 0, 0);

            //assert
            Assert.IsTrue(actual.Length == 1 && actual.All(char.IsDigit));
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacter()
        {
            //act
            var actual = randomize.RandomPassword(false, true, 0, 0);

            //assert
            Assert.IsTrue(actual.Length == 1 && !actual.Any(char.IsLetterOrDigit));
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndNumbers()
        {
            //act
            var actual = randomize.RandomPassword(true, true, 0, 0);

            //assert
            Assert.IsFalse(actual.Length == 2 && actual.Any(char.IsDigit) && !actual.Any(char.IsLetterOrDigit));
        }


        [Test]
        public void CheckRandomPasswordWithNumbersAndPositiveSmallerLetters()
        {
            //act
            var actual = randomize.RandomPassword(true, false, 6, 0);

            //assert
            Assert.IsTrue(actual.Length == 7 && actual.Any(char.IsDigit) && actual.Any(char.IsLower)); ;
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndPositiveSmallerLetters()
        {
            //act
            var actual = randomize.RandomPassword(false, true, 8, 0);

            //assert
            Assert.IsFalse(actual.Length == 9 && !actual.Any(char.IsLetterOrDigit) && actual.Any(char.IsLower));
        }

        [Test]
        public void CheckRandomPasswordWithPositiveSmallerLetters()
        {
            //act
            var actual = randomize.RandomPassword(false, false, 8, 0);

            //assert
            Assert.IsTrue(actual.Length == 8 && actual.All(char.IsLower));
        }

        [Test]
        public void CheckRandomPasswordWithNumbersSpecialCharacterPositiveSmallerLetters()
        {
            //act
            var actual = randomize.RandomPassword(true, true, 12, 0);

            //assert
            Assert.IsFalse(actual.Length == 14 && actual.Any(char.IsDigit) && !actual.Any(char.IsLetterOrDigit) && actual.Any(char.IsLower));
        }


        [Test]
        public void CheckRandomPasswordWithNumbersAndPositiveBigLetters()
        {
            //act
            var actual = randomize.RandomPassword(true, false, 0, 6);

            //assert
            Assert.IsTrue(actual.Length == 7 && actual.Any(char.IsDigit) && actual.Any(char.IsUpper)); ;
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndPositiveBigLetters()
        {
            //act
            var actual = randomize.RandomPassword(false, true, 0, 8);

            //assert
            Assert.IsFalse(actual.Length == 9 &&!actual.Any(char.IsLetterOrDigit) && actual.Any(char.IsUpper));
        }

        [Test]
        public void CheckRandomPasswordWithPositiveBigLetters()
        {
            //act
            var actual = randomize.RandomPassword(false, false, 0, 8);

            //assert
            Assert.IsTrue(actual.Length == 8 && actual.All(char.IsUpper));
        }

        [Test]
        public void CheckRandomPasswordWithNumbersSpecialCharacterPositiveBigLetter()
        {
            //act
            var actual = randomize.RandomPassword(true, true, 0, 12);

            //assert
            Assert.IsFalse(actual.Length == 14 && actual.Any(char.IsDigit) && !actual.Any(char.IsLetterOrDigit) && actual.Any(char.IsUpper));
        }

        [Test]
        public void CheckRandomPasswordWithNumbersAndPositiveBigLettersAndPositiveSmallerLetter()
        {
            //act
            var actual = randomize.RandomPassword(true, false, 4, 6);

            //assert
            Assert.IsTrue(actual.Length == 11 && actual.Any(char.IsDigit) && actual.Any(char.IsUpper) && actual.Any(char.IsLower)); 
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndPositiveBigLettersAndPositiveSmallerLetter()
        {
            //act
            var actual = randomize.RandomPassword(false, true, 2, 8);

            //assert
            Assert.IsFalse(actual.Length == 11 && !actual.Any(char.IsLetterOrDigit) && actual.Any(char.IsUpper) && actual.Any(char.IsLower));
        }

        [Test]
        public void CheckRandomPasswordWithPositiveBigLettersAndPositiveSmallerLetter()
        {
            //act
            var actual = randomize.RandomPassword(false, false, 8, 8);

            //assert
            Assert.IsTrue(actual.Length == 16 && actual.Any(char.IsUpper) && actual.Any(char.IsLower));
        }

        [Test]
        public void CheckPasswordWithAll()
        {
            var actual = randomize.RandomPassword(true, true, 4, 24);

            //assert
            Assert.IsTrue(actual.Length == 30 && actual.Any(char.IsUpper) && actual.Any(char.IsLower) && actual.Any(char.IsDigit) && !actual.All(char.IsLetterOrDigit));
        }

        // 36 testów 16 pozytywnych 20 negatywnych 

        [Test]
        public void CheckRandomPasswordWithNumbersAndNegativeBigAndSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, -9, -2));
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndNegativeBigAndSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, -9, -2));
        }


        [Test]
        public void CheckRandomPasswordWithNegativeBigAndSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, -9, -2)); 
        }


        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndNumbersAndNegativeBigAndSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, -9, -2));
        }

        [Test]
        public void CheckRandomPasswordWithNumbersAndNegativeBigLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, 0, -5));
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndNegativeBigLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, 0, -5));
        }


        [Test]
        public void CheckRandomPasswordWithNegativeBigLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, 0, -5)); 
        }


        [Test]
        public void CheckRandomPasswordWithSpecialCharactersAndNumbersAndNegativeBigLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, 0, -5));
        }




        [Test]
        public void CheckRandomPasswordWithNumbersAndNegativeSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, false, -9, 0));
        }

        [Test]
        public void CheckRandomPasswordWithSpecialCharacterAndNegativeSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, true, -9, 0));
        }


        [Test]
        public void CheckRandomPasswordWithNegativeSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(false, false, -9, 0)); ;
        }

        [Test]
        public void CheckRandomPasswordWithNumbersAndSpecialCharacterAndNegativeSmallerLetter()
        {
            //act
            Assert.Throws<Exception>(() => randomize.RandomPassword(true, true, -9, 0)); ;
        }
    }
}
    


