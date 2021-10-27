using CsharpConsoleTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTests
{
    class CodeTests
    {
        public Code code;
        [SetUp]
        public void CheckCreateObject()
        {
            //arrange
            code = new Code();

            //assert
            Assert.IsInstanceOf(typeof(Code), code);

        }

        [Test]
        public void CheckCodeWithINTJ()
        {
            //act
            var actual = code.GenerateCode(false, false, true, true);

            var expect = "INTJ";

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckCodeWithINTP()
        {
            //act
            var actual = code.GenerateCode(false, false, true, false);

            var expect = "INTP";

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckCodeWithENTJ()
        {
            //act
            var actual = code.GenerateCode(true, false, true, true);

            var expect = "ENTJ";

            //assert
            Assert.AreEqual(expect, actual);
        }



        [Test]
        public void CheckCodeWithENTP()
        {
            //act
            var actual = code.GenerateCode(true, false, true, false);

            var expect = "ENTP";

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckCodeWithINFJ()
        {
            //act
            var actual = code.GenerateCode(false, false, false, true);

            var expect = "INFJ";

            //assert
            Assert.AreEqual(expect, actual);

        }

        [Test]
        public void CheckCodeWithINFP()
        {
            //act
            var actual = code.GenerateCode(false, false, false, false);

            var expect = "INFP";

            //assert
            Assert.AreEqual(expect, actual);

        }

        [Test]
        public void CheckCodeWithENFJ()
        {
            //act
            var actual = code.GenerateCode(true, false, false, true);

            var expect = "ENFJ";

            //assert
            Assert.AreEqual(expect, actual);

        }


        [Test]
        public void CheckCodeWithENFP()
        {
            //act
            var actual = code.GenerateCode(true, false, false, false);

            var expect = "ENFP";

            //assert
            Assert.AreEqual(expect, actual);

        }

        [Test]
        public void CheckCodeWithISTJ()
        {
            //act
            var actual = code.GenerateCode(false, true, true, true);

            var expect = "ISTJ";

            //assert
            Assert.AreEqual(expect, actual);

        }

        [Test]
        public void CheckCodeWithISFJ()
        {
            //act
            var actual = code.GenerateCode(false, true, false, true);

            var expect = "ISFJ";

            //assert
            Assert.AreEqual(expect, actual);

        }

        [Test]
        public void CheckCodeWithESTJ()
        {
            //act
            var actual = code.GenerateCode(true, true, true, true);

            var expect = "ESTJ";

            //assert
            Assert.AreEqual(expect, actual);

        }


        [Test]
        public void CheckCodeWithESFJ()
        {
            //act
            var actual = code.GenerateCode(true, true, false, true);

            var expect = "ESFJ";

            //assert
            Assert.AreEqual(expect, actual);

        }


        [Test]
        public void CheckCodeWithISTP()
        {
            //act
            var actual = code.GenerateCode(false, true, true, false);

            var expect = "ISTP";

            //assert
            Assert.AreEqual(expect, actual);

        }


        [Test]
        public void CheckCodeWithISFP()
        {
            //act
            var actual = code.GenerateCode(false, true, false, false);

            var expect = "ISFP";

            //assert
            Assert.AreEqual(expect, actual);

        }


        [Test]
        public void CheckCodeWithESTP()
        {
            //act
            var actual = code.GenerateCode(true, true, true, false);

            var expect = "ESTP";

            //assert
            Assert.AreEqual(expect, actual);
        }


        [Test]
        public void CheckCodeWithESFP()
        {
            //act
            var actual = code.GenerateCode(true, true, false, false);

            var expect = "ESFP";

            //assert
            Assert.AreEqual(expect, actual);
        }

    }
}
