using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadTablesInWordFile;
using System.Collections;

namespace ReadTablesTest
{
    [TestClass]
    public class ReadTablesTest
    {
        [TestMethod]
        public void ReadTablesTest_01()
        {
            String file = "D:\\Exercise_Problems\\ReadTablesInWordFile\\Sample.docx";
            ArrayList expectedResult = new ArrayList { };


            ReadTables data = new ReadTables();
            ArrayList actualResult = data.readWordFile(file);
            
            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ReadTablesTest_02()
        {
            String file = "D:\\Exercise_Problems\\ReadTablesInWordFile\\wrongfile.docx";
            ArrayList expectedResult = new ArrayList { };

            ReadTables data = new ReadTables();
            ArrayList actualResult = data.readWordFile(file);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void ReadTablesTest_03()
        {
            String file = " ";
            ArrayList expectedResult = new ArrayList { };

            ReadTables data = new ReadTables();
            ArrayList actualResult = data.readWordFile(file);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
