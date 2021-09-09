using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtractLastWord;
namespace ExtractLastWordTest
{
    [TestClass]
    public class ExtractLastWordTest
    {
        [TestMethod]
        public void ExtractLastWordTest_01()
        {
            String input = "Hello World";
            String expectedResult = "World";

            ExtractLastWords extract = new ExtractLastWords();
            string actualResult = extract.GetLastWord(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExtractLastWordTest_02()
        {
            String input = "Hello";
            String expectedResult = "Hello";

            ExtractLastWords extract = new ExtractLastWords();
            String actualResult = extract.GetLastWord(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ExtractLastWordTest_03()
        {
            String input = " ";
            String expectedResult = "";

            ExtractLastWords extract = new ExtractLastWords();
            String actualResult = extract.GetLastWord(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
