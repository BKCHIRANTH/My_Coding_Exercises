using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintAge;

namespace PrintAgeTest
{
    [TestClass]
    public class PrintAgeTest
    {
        [TestMethod]
        public void PrintAgeTest_01()
        {
            int date = 29;
            int month = 04;
            int year = 2020;
            string[] expectedResult = { "1", "52", "0", "1" };

            FindAge age = new FindAge();
            string[] actualResult = age.CalculateAge(date, month, year);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void PrintAgeTest_02()
        {
            int date = 32;
            int month = 04;
            int year = 20201;
            string[] expectedResult = { };

            FindAge age = new FindAge();
            string[] actualResult = age.CalculateAge(date, month, year);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void PrintAgeTest_03()
        {
            int date = '@';
            int month = 04;
            int year = 20201;
            string[] expectedResult = { };

            FindAge age = new FindAge();
            string[] actualResult = age.CalculateAge(date, month, year);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
