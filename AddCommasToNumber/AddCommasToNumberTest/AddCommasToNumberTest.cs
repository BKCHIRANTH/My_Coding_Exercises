using System;
using AddCommasToNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddCommasToNumberTest
{
    [TestClass]
    public class AddCommasToNumberTest
    {
        [TestMethod]
        public void AddCommasTest_01()
        {
            String number = "1000";
            String expectedResult = "1,000";

            AddComma comma = new AddComma();
            String actualResult = comma.addCommasToNumericString(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddCommasTest_02()
        {
            String number = "12345.32";
            String expectedResult = "12,345.32";

            AddComma comma = new AddComma();
            String actualResult = comma.addCommasToNumericString(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddCommasTest_03()
        {
            String number = "123.23";
            String expectedResult = "123.23";

            AddComma comma = new AddComma();
            String actualResult = comma.addCommasToNumericString(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AddCommasTest_04()
        {
            String number = "Hello";
            String expectedResult = null;

            AddComma comma = new AddComma();
            String actualResult = comma.addCommasToNumericString(number);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
