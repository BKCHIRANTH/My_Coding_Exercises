using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitsToWords;

namespace DigitsToWordsTest
{
    [TestClass]
    public class DigitsWordsTest
    {
        [TestMethod]
        public void DigitsTest_01()
        {
            //arrange
            int num = 1235;
            string[] expectedResult = new string[] {"One", "Two", "Three", "Five"};

            //act
            DigitsWords digiword = new DigitsWords();
            string[] actualResult = digiword.DigitsToWords(num);
            int j = 0;

            //assert
            foreach (string s in expectedResult)
            {
                j++;
            }
            for (int i = 0; i <= j-1; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void DigitsTest_02()
        {
            //arrange
            int num = -5874;
            string[] expectedResult = new string[] { "Five", "Eight", "Seven", "Four" };

            //act
            DigitsWords digiword = new DigitsWords();
            string[] actualResult = digiword.DigitsToWords(num);
            int j = 0;

            //assert
            foreach (string s in expectedResult)
            {
                j++;
            }
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void DigitsTest_03()
        {
            //arrange
            int num = +5879;
            string[] expectedResult = new string[] { "Five", "Eight", "Seven", "Nine" };

            //act
            DigitsWords digiword = new DigitsWords();
            string[] actualResult = digiword.DigitsToWords(num);
            int j = 0;

            //assert
            foreach (string s in expectedResult)
            {
                j++;
            }
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void DigitsTest_04()
        {
            //arrange
            int num = 0;
            string[] expectedResult = new string[] { "Zero" };

            //act
            DigitsWords digiword = new DigitsWords();
            string[] actualResult = digiword.DigitsToWords(num);


            //assert
            int j = 0;
            foreach (string s in expectedResult)
            {
                j++;
            }
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }


        [TestMethod]
        public void DigitsTest_05()
        {
            //arrange
            int num = 15;
            string[] expectedResult = new string[] { "One","Five" };

            //act
            DigitsWords digiword = new DigitsWords();
            string[] actualResult = digiword.DigitsToWords(num);
            int j = 0;

            //assert
            foreach (string s in expectedResult)
            {
                j++;
            }
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void DigitsTest_06()
        {
            //arrange
            int num = 'u';
            //string num = "hello";
            string[] expectedResult = new string[] { };

            //act
            DigitsWords digiword = new DigitsWords();
            string[] actualResult = digiword.DigitsToWords(num);
            int j = 0;

            //assert
            foreach (string s in expectedResult)
            {
                j++;
            }
            for (int i = 0; i <= j - 1; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

    }
}
