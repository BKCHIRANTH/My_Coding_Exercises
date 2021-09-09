using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveOccurances;

namespace RemoveAllOccurancesTest
{
    [TestClass]
    public class RemoveAllOccurancesTest
    {
        [TestMethod]
        public void RemoveCharactersTest_01()
        {
            String str = "Hello";
            char ch = 'l';
            String expectedResult = "Heo";

            RemoveChars chars = new RemoveChars();
            String actualResult = chars.removeAllOccurances(str, ch);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveCharactersTest_02()
        {
            String str = "Hello world";
            char ch = 'l';
            String expectedResult = "Heo word";

            RemoveChars chars = new RemoveChars();
            String actualResult = chars.removeAllOccurances(str, ch);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveCharactersTest_03()
        {
            String str = "";
            char ch = 'l';
            String expectedResult = null;

            RemoveChars chars = new RemoveChars();
            String actualResult = chars.removeAllOccurances(str, ch);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void RemoveCharactersTest_04()
        {
            String str = "Fime India";
            char ch = 'g';
            String expectedResult = null;

            RemoveChars chars = new RemoveChars();
            String actualResult = chars.removeAllOccurances(str, ch);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
