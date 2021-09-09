using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiOccuranceCharacter;
namespace MultiOccuranceTest
{
    [TestClass]
    public class MultiOccuranceTest
    {
        [TestMethod]
        public void MultiOccuranceTest_01()
        {
            String sentence = "Heeelloo Woorldd";
            char[] expectedResult = { 'e', 'l', 'o', 'd'};

            MultipleOccurance multiple = new MultipleOccurance();
            char[] actualResult = multiple.RepeatedCharacter(sentence);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void MultiOccuranceTest_02()
        {
            String sentence = " ";
            char[] expectedResult = { };

            MultipleOccurance multiple = new MultipleOccurance();
            char[] actualResult = multiple.RepeatedCharacter(sentence);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void MultiOccuranceTest_03()
        {
            String sentence = "Heeelloo";
            char[] expectedResult = { 'e', 'l', 'o' };

            MultipleOccurance multiple = new MultipleOccurance();
            char[] actualResult = multiple.RepeatedCharacter(sentence);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void MultiOccuranceTest_04()
        {
            String sentence = "Hola";
            char[] expectedResult = {  };

            MultipleOccurance multiple = new MultipleOccurance();
            char[] actualResult = multiple.RepeatedCharacter(sentence);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
