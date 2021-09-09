using System;
using LeapYearCheck;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeapYearTest
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void LeapYearCheckTest_01()
        {
            int year = 2015;
            bool expectedResult = false;

            LeapYear leap = new LeapYear();
            bool actualResult = leap.CheckLeapYear(year);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LeapYearCheckTest_02()
        {
            int year = '@';
            bool expectedResult = false;

            LeapYear leap = new LeapYear();
            bool actualResult = leap.CheckLeapYear(year);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void LeapYearCheckTest_03()
        {
            int year = 2020;
            bool expectedResult = true;

            LeapYear leap = new LeapYear();
            bool actualResult = leap.CheckLeapYear(year);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
