using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderstandingFileAttributes;

namespace FileAttributesTest
{
    [TestClass]
    public class FileAttributesTest
    {
        [TestMethod]
        public void FileAttributesTest_01()
        {
            String file = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File4.txt";
            String expectedResult = "Hidden";

            FileAttributes attr = new FileAttributes();
            String actualResult = attr.getAttributes(file);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FileAttributesTest_02()
        {
            String file = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File3.txt";
            String expectedResult = "ReadOnly";

            FileAttributes attr = new FileAttributes();
            attr.setReadOnly(file);
            String actualResult = attr.getAttributes(file);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FileAttributesTest_03()
        {
            String file = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File8.txt";
            String expectedResult = null;

            FileAttributes attr = new FileAttributes();
            String actualResult = attr.getAttributes(file);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FileAttributesTest_04()
        {
            String file = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File2.txt";
            String expectedResult = "Normal";

            FileAttributes attr = new FileAttributes();
            String actualResult = attr.getAttributes(file);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
