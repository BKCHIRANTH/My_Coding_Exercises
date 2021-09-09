using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticClasses;
namespace StaticClassTest
{
    [TestClass]
    public class StaticClassTest
    {
        [TestMethod]
        public void StaticClassTest_01()
        {
            string animal = "Cow";
            string sound = "Moos";
            string expectedResult = "Cow Moos";

            string actualResult = Animal.Sound(animal, sound);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
