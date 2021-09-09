using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintLineByLine;

namespace PrintLineByLineTest
{
    [TestClass]
    public class LineByLineTest
    {
        [TestMethod]
        public void LineByLineTest_01()
        {
            String inputNames = "APPLE, BLACKBERRY, COMPUTER, DEFAULT, EMULATOR, FUNCTION";
            String[] expectedResult = { "APPLE", "BLACKBERRY", "COMPUTER", "DEFAULT", "EMULATOR", "FUNCTION" };

            LineByLine line = new LineByLine();
            String[] actualResult = line.PrintLineByLine(inputNames);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void LineByLineTest_02()
        {
            String inputNames = " ";
            String[] expectedResult = { };

            LineByLine line = new LineByLine();
            String[] actualResult = line.PrintLineByLine(inputNames);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void LineByLineTest_03()
        {
            String inputNames = "1234,2541,";
            String[] expectedResult = { };

            LineByLine line = new LineByLine();
            String[] actualResult = line.PrintLineByLine(inputNames);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void LineByLineTest_04()
        {
            String inputNames = "Afric3a, Russia,China2 ";
            String[] expectedResult = { };

            LineByLine line = new LineByLine();
            String[] actualResult = line.PrintLineByLine(inputNames);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
