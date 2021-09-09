using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortArray;

namespace SortArrayUnitTest
{
    [TestClass]
    public class SortArrayUnitTest
    {
        [TestMethod]
        public void SortArray_01()
        {
            string[] names = new string[] { "Russia", "Australia", "Iran", "Africa", "Iraq" };

            string[] expectedNames = new string[] {"Russia", "Iraq", "Iran",  "Australia", "Africa" };

            Sort sortNames = new Sort();
            string[] actualNames = sortNames.SortNamesInReverseOrder(names);

            int j = expectedNames.Length;
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }
            
        }

        [TestMethod]
        public void SortArray_02()
        {
            //arrange
            string[] names = new string[] { "Apple", "10", "Zinc", "Orange" };

            string[] expectedNames = new string[] { };

            //act
            Sort sortNames = new Sort();
            string[] actualNames = sortNames.SortNamesInReverseOrder(names);

            //assert
            int j = expectedNames.Length;
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }

        }

        [TestMethod]
        public void SortArray_03()
        {
            //arrange
            string[] names = new string[] { "4Yatch", "Pl9ane", "Car", "Bus" };

            string[] expectedNames = new string[] { };

            //act
            Sort sortNames = new Sort();
            string[] actualNames = sortNames.SortNamesInReverseOrder(names);

            //assert
            int j = expectedNames.Length;
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }

        }

        [TestMethod]
        public void SortArray_04()
        {
            string[] names = new string[] { "5", "8", "6", "1" };

            string[] expectedNames = new string[] { };

            Sort sortNames = new Sort();
            string[] actualNames = sortNames.SortNamesInReverseOrder(names);

            int j = expectedNames.Length;
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }

        }

        [TestMethod]
        public void SortArray_05()
        {
            char[] names = new char[] { '%' };

            string[] expectedNames = new string[] { };

            Sort sortNames = new Sort();
            string[] actualNames = sortNames.SortNamesInReverseOrder(names);

            int j = expectedNames.Length;
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedNames[i], actualNames[i]);
            }

        }
    }
}
