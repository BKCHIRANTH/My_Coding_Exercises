using System;
using DateTimeDifference;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateTimeDifferenceTest
{
    [TestClass]
    public class DateTimeDifferenceTest
    {
        [TestMethod]
        public void DateTimeDifferenceTest_01()
        {
            int date1 = 20;
            int month1 = 4;
            int year1 = 2003;
            int hour1 = 10;
            int min1 = 00;
            int sec1 = 00;

            int date2 = 21;
            int month2 = 4;
            int year2 = 2003;
            int hour2 = 11;
            int min2 = 20;
            int sec2 = 00;


            int[] expectedResult = {1, 1, 20, 0};

            DateTimeDifferences diff = new DateTimeDifferences();
            int[] actualResult = diff.DateTimeDifferenceCalculate(date1, month1, year1, hour1, min1, sec1, date2, month2, year2, hour2, min2, sec2);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void DateTimeDifferenceTest_02()
        {
            int date1 = 20;
            int month1 = 4;
            int year1 = 2003;
            int hour1 = 10;
            int min1 = 00;
            int sec1 = 00;

            int date2 = 21;
            int month2 = 4;
            int year2 = 20034;
            int hour2 = 11;
            int min2 = 20;
            int sec2 = 00;


            int[] expectedResult = {  };

            DateTimeDifferences diff = new DateTimeDifferences();
            int[] actualResult = diff.DateTimeDifferenceCalculate(date1, month1, year1, hour1, min1, sec1, date2, month2, year2, hour2, min2, sec2);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void DateTimeDifferenceTest_03()
        {
            int date1 = '@';
            int month1 = 4;
            int year1 = 2003;
            int hour1 = 10;
            int min1 = 00;
            int sec1 = 00;

            int date2 = 21;
            int month2 = 4;
            int year2 = 2003;
            int hour2 = 11;
            int min2 = 20;
            int sec2 = 00;


            int[] expectedResult = { };

            DateTimeDifferences diff = new DateTimeDifferences();
            int[] actualResult = diff.DateTimeDifferenceCalculate(date1, month1, year1, hour1, min1, sec1, date2, month2, year2, hour2, min2, sec2);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
