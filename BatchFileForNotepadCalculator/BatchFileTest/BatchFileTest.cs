using System;
using BatchFileForNotepadCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BatchFileTest
{
    [TestClass]
    public class BatchFileTest
    {
        [TestMethod]
        public void BatchFileTest_01()
        {
            String application = "notepad.exe";
            int expectedResult = 0;

            Batch_Class batchObj = new Batch_Class();
            int actualResult = batchObj.runNotepad(application);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BatchFileTest_02()
        {
            String application = "calc.exe";
            int expectedResult = 0;

            Batch_Class batchObj = new Batch_Class();
            int actualResult = batchObj.runCalculator(application);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BatchFileTest_03()
        {
            String application = " ";
            int expectedResult = 1;

            Batch_Class batchObj = new Batch_Class();
            int actualResult = batchObj.runCalculator(application);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
