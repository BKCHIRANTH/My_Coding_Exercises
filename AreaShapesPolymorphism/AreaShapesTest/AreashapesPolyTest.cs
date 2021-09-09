using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaShapesPolymorphism;
namespace AreaShapesTest
{
    [TestClass]
    public class AreashapesPolyTest
    {
        [TestMethod]
        public void AreaOfShapesTest_01()
        {
            double radius = 5;
            double expectedResult = 78.54;

            Shapes circle = new Circle();
            double actualResult = circle.area();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AreaOfShapesTest_02()
        {
            double length = 4;
            double breadth = 12.1;
            double expectedResult = 48.4;

            Shapes rectangle = new Rectangle();
            double actualResult = rectangle.area();

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestMethod]
        //public void AreaOfShapesTest_03()
        //{
        //    double side =- 5;
        //    double expectedResult = 0;

        //    Shapes square = new Square();
        //    double actualResult = square.area();

        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        [TestMethod]
        public void AreaOfShapesTest_04()
        {
            double side = 5.2;
            double expectedResult = 27.04;

            Shapes square = new Square();
            double actualResult = square.area();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
