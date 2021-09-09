using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationWithRegularExpressions;

namespace ValidationTest
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void ValidationUsingRegularExpressionTest_01()
        {
            String hexa = "58A";
            bool expectedResult = true;

            Validation validity = new Validation();
            bool actualResult = validity.checkHexa(hexa);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidationUsingRegularExpressionTest_02()
        {
            String hexa = "1G";
            bool expectedResult = false;

            Validation validity = new Validation();
            bool actualResult = validity.checkHexa(hexa);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidationUsingRegularExpressionTest_03()
        {
            String ip = "123.143.0.1";
            bool expectedResult = true;

            Validation validity = new Validation();
            bool actualResult = validity.checkip(ip);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidationUsingRegularExpressionTest_04()
        {
            String ip = "1232.143.0.1";
            bool expectedResult = false;

            Validation validity = new Validation();
            bool actualResult = validity.checkip(ip);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidationUsingRegularExpressionTest_05()
        {
            String file = "_23022010_25963415";
            bool expectedResult = true;

            Validation validity = new Validation();
            bool actualResult = validity.checkFileName(file);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidationUsingRegularExpressionTest_06()
        {
            String data = "ICC>>";
            String expectedResult = "^[a-zA-Z]{3}[>]{2}";

            Validation validity = new Validation();
            String actualResult = validity.parseData(data);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ValidationUsingRegularExpressionTest_07()
        {
            String data = "ICC#>>";
            String expectedResult = null;

            Validation validity = new Validation();
            String actualResult = validity.parseData(data);

            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestMethod]
        //public void ValidationUsingRegularExpressionTest_08()
        //{
        //    String hexa = "1As";
        //    String expectedResult = "1A";

        //    Validation validity = new Validation();
        //    String actualResult = validity.parseHexa(hexa);

        //    Assert.AreEqual(expectedResult, actualResult);
        //}
    }
}
