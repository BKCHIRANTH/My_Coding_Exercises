using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderstandingOfTimer;

namespace TimerTest
{
    [TestClass]
    public class TimerTests
    {
        [TestMethod]
        public void TimerTests_01()
        {
            double timeInt = 4;
            bool expectedResult = true;

            Timer time = new Timer();
            bool actualResult = time.SetTimer(timeInt);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TimerTests_02()
        {
            double timeInt = 0;
            bool expectedResult = false;

            Timer time = new Timer();
            bool actualResult = time.SetTimer(timeInt);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TimerTests_03()
        {
            double timeInt = -5;
            bool expectedResult = false;

            Timer time = new Timer();
            bool actualResult = time.SetTimer(timeInt);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
