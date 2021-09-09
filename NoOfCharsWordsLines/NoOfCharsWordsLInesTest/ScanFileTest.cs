using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoOfCharsWordsLines;

namespace NoOfCharsWordsLInesTest
{
    [TestClass]
    public class ScanFileTest
    {
        [TestMethod]
        public void ScanFileTest_01()
        {
            String file = "D:\\Exercise_Problems\\temp_read.txt";
            int[] expectedResult = { 6, 3, 31 };

            ScanFile scan = new ScanFile();
            int[] actualResult = scan.ScanFilesForCharsWordsLines(file);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ScanFileTest_02()
        {
            String file = "D:\\Exercise_Problems\\temp_read_notfound.txt";
            int[] expectedResult = { };

            ScanFile scan = new ScanFile();
            int[] actualResult = scan.ScanFilesForCharsWordsLines(file);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ScanFileTest_03()
        {
            String file = "D:\\Exercise_Problems\\temp_file_empty.txt";
            int[] expectedResult = { };

            ScanFile scan = new ScanFile();
            int[] actualResult = scan.ScanFilesForCharsWordsLines(file);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
