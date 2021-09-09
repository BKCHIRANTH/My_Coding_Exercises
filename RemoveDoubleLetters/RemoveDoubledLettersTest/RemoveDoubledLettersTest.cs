using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveDoubleLetters;

namespace RemoveDoubledLettersTest
{
    [TestClass]
    public class RemoveDoubledLettersTest
    {
        [TestMethod]
        public void RemoveDoubledLettersTest_01()
        {
            String str = "Hello";
            String expectedResult = "Helo";

            RemoveDouble remove = new RemoveDouble();
            String actualResult = remove.removeDoubledLetters(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveDoubledLettersTest_02()
        {
            String str = " ";
            String expectedResult = " ";

            RemoveDouble remove = new RemoveDouble();
            String actualResult = remove.removeDoubledLetters(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveDoubledLettersTest_03()
        {
            String str = "watch";
            String expectedResult = "watch";

            RemoveDouble remove = new RemoveDouble();
            String actualResult = remove.removeDoubledLetters(str);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveDoubledLettersTest_04()
        {
            String str = "1234";
            String expectedResult = null;

            RemoveDouble remove = new RemoveDouble();
            String actualResult = remove.removeDoubledLetters(str);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
