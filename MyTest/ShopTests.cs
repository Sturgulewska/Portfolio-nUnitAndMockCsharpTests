using System;
using System.Collections.Generic;
using System.Text;
using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class ShopTests
    {
        // 10 testów

        [Test]
        public void CheckDiscountForLessThanTen()
        {
            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(1, 9);
            var expect = 0;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        //- dla kowty 10-29 rabat wynosi libcza zakupionych produktów*0,1
        //CheckDiscountFroLessThanTwenthyNine

        [Test]
        public void CheckDiscountForLessThanTwenthyNine()
        {
            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(2, 29);

            // Liczba zakupionych produktów * 0.1
            var expect = 0.2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDiscountForMoreThanTen()
        {

            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(2, 10);

            // Liczba zakupionych produktów * 0.1
            var expect = 0.2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDiscountForMoreThanThirty()
        {

            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(2, 30);

            // Liczba zakupionych produktów * 0.15 + 5
            var expect = 5.3;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDiscountForLessThanFourtyNine()
        {

            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(3, 49);

            // Liczba zakupionych produktów * 0.15 + 5 
            var expect = 5.45;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckDiscountForLessThanNinetyNine ()
        {

            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(3, 99);

            // Liczba zakupionych produktów * 0.2 + 10 
            var expect = 10.6;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckDiscountForMoreThanFifty ()
        {

            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(3, 50);

            // Liczba zakupionych produktów * 0.2 + 10 
            var expect = 10.6;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckDiscountForMoreThanHundred ()
        {

            //Arrange
            var shop = new Shop();

            //Act
            var actual = shop.CreateDiscount(3, 100);

            // Liczba zakupionych produktów * 0.25 + 15 
            var expect = 15.75;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
    }
}