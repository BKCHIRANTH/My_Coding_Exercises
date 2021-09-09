using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadAndWriteExcel;

namespace ReadWriteExcelTest
{
    [TestClass]
    public class ReadWriteExcelTest
    {
        [TestMethod]
        public void ReadWriteExcelTest_01()
        {
            int row = 4;
            int column = 5;
            String value = "Kiev";
            String expectedResult = "Kiev";

            ReadWriteExcel excel = new ReadWriteExcel();
            excel.writeExcel(row, column, value);
            String actualResult = excel.readExcel(row, column);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ReadWriteExcelTest_02()
        {
            int row = -4;
            int column = 5;
            String value = "Kiev";
            String expectedResult = null;

            ReadWriteExcel excel = new ReadWriteExcel();
            excel.writeExcel(row, column, value);
            String actualResult = excel.readExcel(row, column);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ReadWriteExcelTest_03()
        {
            int row = 2;
            int column = 5;
            String value = null;
            String expectedResult = null;

            ReadWriteExcel excel = new ReadWriteExcel();
            excel.writeExcel(row, column, value);
            String actualResult = excel.readExcel(row, column);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
