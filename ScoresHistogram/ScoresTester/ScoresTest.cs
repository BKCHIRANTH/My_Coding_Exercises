using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoresHistogram;

namespace ScoresTester
{
    [TestClass]
    public class ScoresTest
    {
        [TestMethod]
        public void ScoresTest_01()
        {
            string file = "D:\\Exercise_Problems\\ScoresHistogram\\MidTermScoresText.txt";
            int[] expectedResult = { 10, 11, 5, 32, 25, 62, 75, 92, 22, 33, 41 };

            Histogram obj = new Histogram();
            int[] actualResult = obj.readScores(file);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ScoresTest_02()
        {
            string file = "D:\\Exercise_Problems\\ScoresHistogram\\MidTermScoresText.txt";
            int[] expectedResult = { 2, 2, 2, 2, 1, 0, 1, 1, 0, 1 };

            Histogram obj = new Histogram();
            int[] scores = obj.readScores(file);
            int[] actualResult = obj.Counter(scores);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ScoresTest_03()
        {
            string file = "D:\\Exercise_Problems\\ScoresHistogram\\MidTermScoresNotExist.txt";
            int[] expectedResult = { };

            Histogram obj = new Histogram();
            int[] actualResult = obj.readScores(file);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ScoresTest_04()
        {
            string file = "D:\\Exercise_Problems\\ScoresHistogram\\MidTermScoresNotExist.txt";
            int[] expectedResult = { };
            int[] scores = { '%' };
            Histogram obj = new Histogram();
            int[] actualResult = obj.Counter(scores);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
