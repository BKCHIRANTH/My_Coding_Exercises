using System;
using BatchfileForInstallation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BatchForInstallationTest
{
    [TestClass]
    public class BatchfileTest
    {
        [TestMethod]
        public void BatchFileInstallTest_01()
        {
            String path = "c:\\temp\\TEST.bat";
            bool expectedResult = true;

            RunBatch runObj = new RunBatch();
            bool actualResult = runObj.runMyBatchFile(path);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BatchFileInstallTest_02()
        {
            String path = " ";
            bool expectedResult = false;

            RunBatch runObj = new RunBatch();
            bool actualResult = runObj.runMyBatchFile(path);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BatchFileInstallTest_03()
        {
            String path = "c:\\somepath";
            bool expectedResult = false;

            RunBatch runObj = new RunBatch();
            bool actualResult = runObj.runMyBatchFile(path);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
