using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using ReadHTMLAndTextFiles;

namespace ReadFilesTest
{
    [TestClass]
    public class ReadFilesTest
    {
        [TestMethod]
        public void ReadFilesTest_01()
        {
            String dir = "D:\\Exercise_Problems\\ReadHTMLAndTextFiles\\Testing Purpose";
            ArrayList expectedResult = new ArrayList { "Text File Contents:" , "Sample for test", null, "End of this text file"  };

            ReadHTMLTextFiles read = new ReadHTMLTextFiles();
            ArrayList actualResult = read.readTextFile(dir);

            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ReadFilesTest_02()
        {
            String dir = "D:\\Exercise_Problems\\ReadHTMLAndTextFiles\\wrong";
            ArrayList expectedResult = new ArrayList {  };

            ReadHTMLTextFiles read = new ReadHTMLTextFiles();
            ArrayList actualResult = read.readTextFile(dir);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ReadFilesTest_03()
        {
            String dir = "D:\\Exercise_Problems\\ReadHTMLAndTextFiles\\Testing Purpose";
            ArrayList expectedResult = new ArrayList {  "<html>", "<body>", "<p> Trial </p>", "</body>", "</html>"};

            ReadHTMLTextFiles read = new ReadHTMLTextFiles();
            ArrayList actualResult = read.readHTMLFile(dir);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ReadFilesTest_04()
        {
            String dir = "D:\\Exercise_Problems\\ReadHTMLAndTextFiles\\Testing Purpose\\Trial";
            ArrayList expectedResult = new ArrayList { };

            ReadHTMLTextFiles read = new ReadHTMLTextFiles();
            ArrayList actualResult = read.readTextFile(dir);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
