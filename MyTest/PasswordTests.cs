using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class PasswordTests
    {
        [Test]
        public void CheckCorrectPassword()
        {
            //arrange
            var password = new Password();
            //act 
            var actual = password.CheckPassword("Anto$128");
           // var expected = true;
            //assert
            Assert.IsTrue(actual);
        }
        
        [Test]
        public void CheckPasswordWithoutEigthCharacters()
        {
            //arrange
            var password = new Password();
            //act 
            var actual = password.CheckPassword("Ato$128");
            // assert
            Assert.IsFalse(actual);
        }
        [Test]
        public void CheckPasswordWithoutBigLetter()
        {
            //arrange
            var password = new Password();
            //act 
            var actual = password.CheckPassword("bato$128");
            //assert
            Assert.IsFalse(actual);
        }
        [Test]
        public void CheckPasswordWithoutSpecialCharacter()
        {
            //arrange
            var password = new Password();
            //act 
            var actual = password.CheckPassword("atoBv128");
            //assert
            Assert.IsFalse(actual);
        }
        [Test]
        public void CheckPasswordWithoutNumbers()
        {
            //arrange
            var password = new Password();
            //act 
            var actual = password.CheckPassword("atoBv#$p");
            //assert
            Assert.IsFalse(actual);
        }
        [Test]
        public void CheckPasswordWithoutSmallLetter()
        {
            //arrange
            var password = new Password();
            //act 
            var actual = password.CheckPassword("@#$BD128");
            //assert
            Assert.IsFalse(actual);
        }
    }
}