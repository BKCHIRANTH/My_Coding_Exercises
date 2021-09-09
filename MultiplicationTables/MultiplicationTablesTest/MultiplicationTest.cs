using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationTables;
namespace MultiplicationTablesTest
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void MultiplicationTest_01()
        {
            //arrange
            int input = 2;
            int[] expectedResult = { 1, 2, 2, 4 };

            //act
            MultiplicationTable mul = new MultiplicationTable();
            int[] actualResult = mul.GetTable(input);

            //assert
            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void MultiplicationTest_02()
        {
            //arrange
            int input = -2;
            int[] expectedResult = { };

            //act
            MultiplicationTable mul = new MultiplicationTable();
            int[] actualResult = mul.GetTable(input);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void MultiplicationTest_03()
        {
            //arrange
            int input = 0;
            int[] expectedResult = { };

            //act
            MultiplicationTable mul = new MultiplicationTable();
            int[] actualResult = mul.GetTable(input);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void MultiplicationTest_04()
        {
            //arrange
            int input = 'k';
            int[] expectedResult = { };

            //act
            MultiplicationTable mul = new MultiplicationTable();
            int[] actualResult = mul.GetTable(input);

            //assert
            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
