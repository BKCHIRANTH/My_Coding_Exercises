using System;
using ListOfWordsFromFile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListOfWordsTest
{
    [TestClass]
    public class ListOfWordsTest
    {
        [TestMethod]
        public void ListOfWordsTest_01()
        {
            String file = "D:\\Exercise_Problems\\ListOfWordsFromFile\\Test_Read.txt";
            String[] expectedResult = { "centuary", "during", "last", "mostly", "the", "together", "ussr", "was" };

            Operations op = new Operations();
            String[] actualResult = op.readFile(file);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ListOfWordsTest_02()
        {
            String file = "D:\\Exercise_Problems\\ListOfWordsFromFile\\Test_Write.txt";
            String[] expectedResult = { };

            Operations op = new Operations();
            String[] actualResult = op.readFile(file);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ListOfWordsTest_03()
        {
            String file = "D:\\Exercise_Problems\\ListOfWordsFromFile\\Wrong_File.txt";
            String[] expectedResult = { };

            Operations op = new Operations();
            String[] actualResult = op.readFile(file);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
