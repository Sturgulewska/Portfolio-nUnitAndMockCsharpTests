using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class ShopClassTests
    {
        [Test]
        public void CheckCreateObject()
        {
            //arrange
            var shopClass = new ShopClass(2, 6);
            //assert
            Assert.IsTrue(shopClass.Price==6 && shopClass.Quantity==2);
            Assert.IsInstanceOf(typeof(ShopClass), shopClass);
        }
        
        [Test]
        public void CheckDiscountForLessThanTen()
        {
            //Arrange
            var shop = new ShopClass(1, 9);

            //Act
            var actual = shop.CreateDiscount();
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
            var shop = new ShopClass(2, 29);

            //Act
            var actual = shop.CreateDiscount();

            // Liczba zakupionych produktów * 0.1
            var expect = 0.2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDiscountForMoreThanTen()
        {

            //Arrange
            var shop = new ShopClass(2,10);

            //Act
            var actual = shop.CreateDiscount();

            // Liczba zakupionych produktów * 0.1
            var expect = 0.2;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDiscountForMoreThanThirty()
        {

            //Arrange
            var shop = new ShopClass(2,30);

            //Act
            var actual = shop.CreateDiscount();

            // Liczba zakupionych produktów * 0.15 + 5
            var expect = 5.3;
            //Assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckDiscountForLessThanFourtyNine()
        {

            //Arrange
            var shop = new ShopClass(3,49);

            //Act
            var actual = shop.CreateDiscount();

            // Liczba zakupionych produktów * 0.15 + 5 
            var expect = 5.45;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckDiscountForLessThanNinetyNine ()
        {

            //Arrange
            var shop = new ShopClass(3,99);

            //Act
            var actual = shop.CreateDiscount();

            // Liczba zakupionych produktów * 0.2 + 10 
            var expect = 10.6;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void CheckDiscountForMoreThanFifty ()
        {

            //Arrange
            var shop = new ShopClass(3,50);

            //Act
            var actual = shop.CreateDiscount();

            // Liczba zakupionych produktów * 0.2 + 10 
            var expect = 10.6;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
        [Test]
        public void CheckDiscountForMoreThanHundred ()
        {

            //Arrange
            var shop = new ShopClass(3,100);

            //Act
            var actual = shop.CreateDiscount();

            // Liczba zakupionych produktów * 0.25 + 15 
            var expect = 15.75;
            //Assert
            Assert.AreEqual(expect, actual);
        }
        
    }
}
    
