using System.Collections.Generic;
using System.Linq;
using CsharpConsoleTest;
using NUnit.Framework;

namespace MyTests
{
    public class ArtHistoryTests
    {
        [Test]
        public void CheckCreateFieldObject()
        {
            //arrange
            var fieldArt = new Field(1, "Painting");
            //act and assert
            Assert.IsTrue(fieldArt.Id ==1 && fieldArt.Name=="Painting");
            Assert.IsInstanceOf(typeof(Field), fieldArt);
            
    }

        [Test]
        public void CheckStyleObject()
        {//arrange
            var fieldArt = new Field(1, "Painting");
            var fieldArt1 = new Field(2, "Sculpture");

            var fieldList = new List<Field>();
            fieldList.Add(fieldArt);
            fieldList.Add(fieldArt1);
            //arrange
            var styleArt = new Style(1, "Renaissane", fieldList);
            
            //act and assert
            Assert.IsTrue(styleArt.Id==1 && styleArt.Name=="Renaissane" && styleArt.Fields.Any(f=>
                f.Id==1 && f.Name=="Painting") && styleArt.Fields.Any(f=> f.Id==2&&f.Name=="Sculpture"));
            Assert.IsInstanceOf(typeof(Style), styleArt);
        }

        [Test]
        public void CheckCreateArtHistory()
        {
            //arrange
            var fieldArt = new Field(1, "Painting");
            var fieldArt1 = new Field(2, "Sculpture");

            var fieldList = new List<Field>();
            fieldList.Add(fieldArt);
            fieldList.Add(fieldArt1);
            
            //arrange
            var styleArt = new Style(1, "Renaissane", fieldList);
            var styleArt1 = new Style(2, "Mannerism", fieldList);

            var styleList = new List<Style>();
            styleList.Add(styleArt);
            styleList.Add(styleArt1);

            var artHistory = new ArtHistory(1, "Aesthetics", styleList);
            
            //act and assert
            Assert.IsTrue(artHistory.Id == 1 && artHistory.Name == "Aesthetics" && artHistory.Styles.Any(s =>
                s.Id == 1 && s.Name == "Renaissane" && s.Fields.Any(f => f.Id == 1 && f.Name == "Painting") &&
                s.Fields.Any(f =>
                    f.Id == 2 && f.Name == "Sculpture") && artHistory.Styles.Any(s => s.Id == 2 &&
                    s.Name == "Mannerism" && s.Fields.Any(
                        f => f.Id == 1 && f.Name == "Painting") && s.Fields.Any(f =>
                        f.Id == 2 && f.Name == "Sculpture"))));
        }

    }
}