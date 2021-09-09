using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SealedClassDemo;
namespace SealedClassTest
{
    [TestClass]
    public class SealedClassTest
    {
        [TestMethod]
        public void SealedClassTest_01()
        {
            double mileage = 125;
            double expectedResult = 62.5;

            Vehicle veh = new Vehicle();
            double actualResult = veh.mileage(mileage);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SealedClassTest_02()
        {
            double cc = 200;
            double expectedResult = 100;

            Bike bike = new Bike();
            double actualResult = bike.Mileage(cc);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SealedClassTest_03()
        {
            double cc = 150;
            double expectedResult = 50;

            Splendor splendor = new Splendor();
            double actualResult = splendor.Mileage(cc);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
