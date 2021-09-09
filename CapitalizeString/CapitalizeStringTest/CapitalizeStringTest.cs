using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapitalizeString;
namespace CapitalizeStringTest
{
    [TestClass]
    public class CapitalizeStringTest
    {
        [TestMethod]
        public void CapitalizeTest_01()
        {
            String name = "fred";
            
            String expectedResult = "Hello FRED, nice to meet you!";

            Capitalize capital = new Capitalize();
            String actualResult = capital.CapitalizeName(name);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CapitalizeTest_02()
        {
            String name = "";

            String expectedResult = "Hello ANONYMOUS, nice to meet you!";

            Capitalize capital = new Capitalize();
            String actualResult = capital.CapitalizeName(name);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void CapitalizeTest_03()
        {
            String name = "123";

            String expectedResult = null;

            Capitalize capital = new Capitalize();
            String actualResult = capital.CapitalizeName(name);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
