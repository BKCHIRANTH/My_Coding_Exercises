using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadAndWriteFile;

namespace ReadAndWritetest
{
    [TestClass]
    public class ReadAndWriteTest
    {
        [TestMethod]
        public void ReadAndWriteTest_01()
        {
            string filepath = "D:\\Exercise_Problems\\temp_read.txt";
            string expectedResult = "hello worldHello all";

            ReadAndWrite read = new ReadAndWrite();
            string actualResult = read.Read(filepath);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReadAndWriteTest_02()
        {
            string filepath = "D:\\Exercise_Problems\\tem_file.txt";
            string expectedResult = null;

            ReadAndWrite read = new ReadAndWrite();
            string actualResult = read.Read(filepath);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReadAndWriteTest_03()
        {
            string filepath = "D:\\Exercise_Problems\\temp_file_empty.txt";
            string expectedResult = "emp";

            ReadAndWrite read = new ReadAndWrite();
            string actualResult = read.Read(filepath);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReadAndWriteTest_04()
        {
            string filepath = "D:\\Exercise_Problems\\temp_write.txt";
            string expectedResult = "Sample_Text_To_Be_Written_One!!!Sample_Text_To_Be_Written_Two!!!";

            ReadAndWrite readwrite = new ReadAndWrite();
            readwrite.Write(filepath);
            string actualResult = readwrite.Read(filepath);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
