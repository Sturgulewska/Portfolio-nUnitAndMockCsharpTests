using CsharpConsoleTest;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    class PersonalityTests
    {

        [Test]
        public void CheckArchitekt()
        {

            var mock = new Mock<ICode>();

            mock.Setup(m => m.GenerateCode(false, false, true, true)).Returns("INTJ");


            //arrange
            var personality = new Personality(mock.Object, false, false, true, true);

            //act 
            var actual = personality.GetPersonality();
            var expect = "Architekt";

            //assert
            Assert.AreEqual(expect, actual);

        }
        [Test]
        public void CheckLogic()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, false)).Returns("INTP");

            //arrange
            var personality = new Personality(mock.Object, false, false, true, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Logik";

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckDowodca()
        {

            var mock = new Mock<ICode>();

            mock.Setup(m => m.GenerateCode(true, false, true, true)).Returns("ENTJ");


            //arrange
            var personality = new Personality(mock.Object, true, false, true, true);

            //act 
            var actual = personality.GetPersonality();
            var expect = "Dowódca";

            //assert
            Assert.AreEqual(expect, actual);

        }
        [Test]
        public void CheckDyskutant()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, true, false)).Returns("ENTP");

            //arrange
            var personality = new Personality(mock.Object, false, false, true, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Dyskutant";

            //assert
            Assert.AreEqual(expect, actual);
        }


        //Rzecznik - INFJ
        [Test]
        public void CheckRzecznik()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, true)).Returns("INFJ");

            //arrange
            var personality = new Personality(mock.Object, false, false, false, true);

            //act
            var actual = personality.GetPersonality();
            var expect = "Rzecznik";

            //assert
            Assert.AreEqual(expect, actual);
        }

        
        [Test]
        public void CheckPosrednik()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, false, false, false)).Returns("INFP");

            //arrange
            var personality = new Personality(mock.Object, false, false, false, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Pośrednik";

            //assert
            Assert.AreEqual(expect, actual);
        }

        //Protagonista - ENFJ

        [Test]
        public void CheckProtagonista()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, true)).Returns("ENFJ");

            //arrange
            var personality = new Personality(mock.Object, true, false, false, true);

            //act
            var actual = personality.GetPersonality();
            var expect = "Protagonista";

            //assert
            Assert.AreEqual(expect, actual);
        }

        //Działacz - ENFP

        [Test]
        public void CheckDziałacz()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, false, false, false)).Returns("ENFP");

            //arrange
            var personality = new Personality(mock.Object, true, false, false, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Działacz";

            //assert
            Assert.AreEqual(expect, actual);
        }

        //Logistyk - ISTJ

        [Test]
        public void CheckLogistyk()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, true)).Returns("ISTJ");

            //arrange
            var personality = new Personality(mock.Object, false, true, true, true);

            //act
            var actual = personality.GetPersonality();
            var expect = "Logistyk";

            //assert
            Assert.AreEqual(expect, actual);
        }

        //Obrońca - ISFJ
        [Test]
        public void CheckObronca()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, true)).Returns("ISFJ");

            //arrange
            var personality = new Personality(mock.Object, false, true, false, true);

            //act
            var actual = personality.GetPersonality();
            var expect = "Obrońca";

            //assert
            Assert.AreEqual(expect, actual);
        }

        //Wykonawca - ESTJ

        [Test]
        public void CheckWykonawca()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, true)).Returns("ESTJ");

            //arrange
            var personality = new Personality(mock.Object, true, true, true, true);

            //act
            var actual = personality.GetPersonality();
            var expect = "Wykonawca";

            //assert
            Assert.AreEqual(expect, actual);
        }


        // Doradca - ESFJ
        public void CheckDoradca()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, true)).Returns("ESFJ");

            //arrange
            var personality = new Personality(mock.Object, true, true, false, true);

            //act
            var actual = personality.GetPersonality();
            var expect = "Doradca";

            //assert
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void CheckWirtuoz()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, true, false)).Returns("ISTP");

            //arrange
            var personality = new Personality(mock.Object, false, true, true, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Wirtuoz";

            //assert
            Assert.AreEqual(expect, actual);
        }

        // Poszukiwacz przygód - ISFP
        [Test]
        public void CheckPoszukiwaczPrzygod()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(false, true, false, false)).Returns("ISFP");

            //arrange
            var personality = new Personality(mock.Object, false, true, false, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Poszukiwacz przygód";

            //assert
            Assert.AreEqual(expect, actual);
        }

        //Przedsiębiorca - ESTP
        [Test]
        public void CheckPrzedsiębiorca()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, true, false)).Returns("ESTP");

            //arrange
            var personality = new Personality(mock.Object, true, true, true, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Przedsiębiorca";

            //assert
            Assert.AreEqual(expect, actual);
        }

        //Animator - ESFP

        [Test]
        public void CheckAnimator()

        {
            var mock = new Mock<ICode>();
            mock.Setup(m => m.GenerateCode(true, true, false, false)).Returns("ESFP");

            //arrange
            var personality = new Personality(mock.Object, true, true, false, false);

            //act
            var actual = personality.GetPersonality();
            var expect = "Animator";

            //assert
            Assert.AreEqual(expect, actual);
        }

    }
}
