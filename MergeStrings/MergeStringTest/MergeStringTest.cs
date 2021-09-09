using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeStrings;
namespace MergeStringTest
{
    [TestClass]
    public class MergeStringTest
    {
        [TestMethod]
        public void MergeStringTest_01()
        {

            String str1 = "Welcome";
            String str2 = "hello";
            String str3 = "Orange";
            String expectedResult = "WelcomehelloOrange";

            MergeString merge = new MergeString();
            String actualResult = merge.Merge(str1, str2, str3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MergeStringTest_02()
        {

            String str1 = "";
            String str2 = "";
            String str3 = "";
            String expectedResult = "";

            MergeString merge = new MergeString();
            String actualResult = merge.Merge(str1, str2, str3);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MergeStringTest_03()
        {

            String str1 = "";
            String str2 = "Fun";
            String str3 = "";
            String expectedResult = "Fun";

            MergeString merge = new MergeString();
            String actualResult = merge.Merge(str1, str2, str3);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
