using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using PrintTableAndColumnNames;

namespace PrintTablesColumnsTest
{
    [TestClass]
    public class PrintTablesColumnsTest
    {
        [TestMethod]
        public void PrintTablesColumnsTest_01()
        {
            String db = "test1";
            ArrayList expectedResult = new ArrayList{ "login", "employeeDetails" };

            PrintTableColumns print = new PrintTableColumns();
            ArrayList actualResult = print.getTables(db);

            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
            
        }

        [TestMethod]
        public void PrintTablesColumnsTest_02()
        {
            String db = "test1";
            string tablename = "login";
            ArrayList expectedResult = new ArrayList { "username", "password" };

            PrintTableColumns print = new PrintTableColumns();
            ArrayList actualResult = print.getColumns(tablename,db);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }

        [TestMethod]
        public void PrintTablesColumnsTest_03()
        {
            String db = "test1";
            string tablename = "loginn";
            ArrayList expectedResult = new ArrayList {  };

            PrintTableColumns print = new PrintTableColumns();
            ArrayList actualResult = print.getColumns(tablename, db);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }

        }
    }
}
