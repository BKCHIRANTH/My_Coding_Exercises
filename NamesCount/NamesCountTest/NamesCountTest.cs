using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamesCount;

namespace NamesCountTest
{
    [TestClass]
    public class NamesCountTest
    {
        [TestMethod]
        public void CountNamesTest_01()
        {
            List<String> names = new List<string>();
            names.Add("Danny");
            names.Add("Tony");
            names.Add("Daniel");
            names.Add("Danny");

            String expectedResult = " 211";

            CountingNames count = new CountingNames();
            String actualResult = count.getCounts(names);

            
            Assert.AreEqual(expectedResult, actualResult);
            

        }

        [TestMethod]
        public void CountNamesTest_02()
        {
            List<String> names = new List<string>();
            names.Add("Danny");
            names.Add("Tony");
            names.Add("Daniel123");
            //names.Add("Danny");

            String expectedResult = null;

            CountingNames count = new CountingNames();
            String actualResult = count.getCounts(names);


            Assert.AreEqual(expectedResult, actualResult);


        }

        [TestMethod]
        public void CountNamesTest_03()
        {
            List<String> names = new List<string>();
            names.Add("Danny");
            names.Add("Tony");
            names.Add("123");
            //names.Add("Danny");

            String expectedResult = null;

            CountingNames count = new CountingNames();
            String actualResult = count.getCounts(names);


            Assert.AreEqual(expectedResult, actualResult);


        }
    }
}
