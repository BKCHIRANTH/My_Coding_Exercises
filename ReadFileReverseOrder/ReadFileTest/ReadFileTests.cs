using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadFileReverseOrder;

namespace ReadFileTest
{
    [TestClass]
    public class ReadFileTests
    {
        [TestMethod]
        public void ReadFileReverseTest_01()
        {
            string filepath = "D:\\Exercise_Problems\\temp_readRev.txt";
            String expectedResult = "Line last Hello Fime! Hello all Hello world" ;

            ReadFile read = new ReadFile();
            String actualResult = read.readFileReverse(filepath);

            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [TestMethod]
        public void ReadFileReverseTest_02()
        {
            string filepath = "D:\\Exercise_Problems\\temp_re.txt";
            String expectedResult = null;

            ReadFile read = new ReadFile();
            String actualResult = read.readFileReverse(filepath);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void ReadFileReverseTest_03()
        {
            string filepath = "D:\\Exercise_Problems\\temp_file_empty.txt";
            String expectedResult = null;

            ReadFile read = new ReadFile();
            String actualResult = read.readFileReverse(filepath);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
