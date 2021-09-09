using System;
using DateToString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateToStringFormatTest
{
    [TestClass]
    public class DateToStringTest
    {
        [TestMethod]
        public void DateToStringTest_01()
        {
            int date = 10;
            int month = 5;
            int year = 2020;
            String expectedResult = "May 10 2020";


            String actualResult = DateToStringFormat.ConvertDateToStringMonthName(year, month, date);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DateToStringTest_02()
        {
            int date = 10;
            int month = 5;
            int year = 2020;
            String expectedResult = "Sunday, 10 May 2020";


            String actualResult = DateToStringFormat.ConvertDateToStringDay(year, month, date);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DateToStringTest_03()
        {
            int date = 10;
            int month = 5;
            int year = 2020;
            String expectedResult = "Sunday, 10 May 2020 15:24:16";


            String actualResult = DateToStringFormat.ConvertDateToStringWithDayTime(year, month, date);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DateToStringTest_04()
        {
            int date = 32;
            int month = 5;
            int year = 2020;
            String expectedResult = " ";


            String actualResult = DateToStringFormat.ConvertDateToStringMonthName(year, month, date);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
