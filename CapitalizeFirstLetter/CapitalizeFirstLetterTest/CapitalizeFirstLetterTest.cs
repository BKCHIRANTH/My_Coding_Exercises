using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapitalizeFirstLetter;
namespace CapitalizeFirstLetterTest
{
    [TestClass]
    public class CapitalizeFirstLetterTest
    {
        [TestMethod]
        public void CapitalizeFirstLetterTest_01()
        {
            String sentence = "this is a contemperory world!";
            String expectedResult = "This Is A Contemperory World!";

            CapitalizeFirstLetters caps = new CapitalizeFirstLetters();
            String actualResult = caps.CapitalizeFirst(sentence);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CapitalizeFirstLetterTest_02()
        {
            String sentence = "";
            String expectedResult = null;

            CapitalizeFirstLetters caps = new CapitalizeFirstLetters();
            String actualResult = caps.CapitalizeFirst(sentence);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CapitalizeFirstLetterTest_03()
        {
            String sentence = "88";
            String expectedResult = null;

            CapitalizeFirstLetters caps = new CapitalizeFirstLetters();
            String actualResult = caps.CapitalizeFirst(sentence);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
