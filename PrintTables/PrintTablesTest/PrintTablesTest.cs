using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintTables;

namespace PrintTablesTest
{
    [TestClass]
    public class PrintTablesTest
    {
        [TestMethod]
        public void TestTable_01()
        {
            //arrange
            int num = 3;
            int[] expectedResult = { 0, 0, 2, 0, 3, 6 };

            //act
            PrintingTables print = new PrintingTables();
            int[] actualResult = print.PrintingTablePyramid(num);

            //assert
            int leng = expectedResult.Length;
            for(int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);
            }

        }

        [TestMethod]
        public void TestTable_02()
        {
            //arrange
            int num = 5;
            int[] expectedResult = { 0, 0, 2, 0, 3, 6, 0, 4, 8, 12, 0, 5, 10, 15, 20 };

            //act
            PrintingTables print = new PrintingTables();
            int[] actualResult = print.PrintingTablePyramid(num);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);

            }

        }

        [TestMethod]
        public void TestTable_03()
        {
            //arrange
            int num = 0;
            int[] expectedResult = { 0 };

            //act
            PrintingTables print = new PrintingTables();
            int[] actualResult = print.PrintingTablePyramid(num);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);

            }

        }

        [TestMethod]
        public void TestTable_04()
        {
            //arrange
            int num = -5;
            int[] expectedResult = { };

            //act
            PrintingTables print = new PrintingTables();
            int[] actualResult = print.PrintingTablePyramid(num);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);

            }

        }

        [TestMethod]
        public void TestTable_05()
        {
            //arrange
            //string num ="hh";
            char num = 'k';

            int[] expectedResult = { };

            //act
            PrintingTables print = new PrintingTables();
            int[] actualResult = print.PrintingTablePyramid(num);

            //assert
            int leng = expectedResult.Length;
            for (int i = 0; i < leng; i++)
            {
                Assert.AreEqual(actualResult[i], expectedResult[i]);

            }

        }

    }
}
