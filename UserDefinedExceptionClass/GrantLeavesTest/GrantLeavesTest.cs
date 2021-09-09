using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserDefinedExceptionClass;

namespace GrantLeavesTest
{
    [TestClass]
    public class GrantLeavesTest
    {
        [TestMethod]
        public void GrantLeavesTest_01()
        {
            int leaves = 2;
            bool expectedResult = true;

            GrantLeave leave = new GrantLeave();
            bool actualResult = leave.GrantingLeaves(leaves);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GrantLeavesTest_02()
        {
            int leaves = 4;
            bool expectedResult = false;

            GrantLeave leave = new GrantLeave();
            bool actualResult = leave.GrantingLeaves(leaves);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GrantLeavesTest_03()
        {
            int leaves = '@';
            bool expectedResult = false;

            GrantLeave leave = new GrantLeave();
            bool actualResult = leave.GrantingLeaves(leaves);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
