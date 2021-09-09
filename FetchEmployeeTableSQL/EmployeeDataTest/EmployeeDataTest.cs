using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using FetchEmployeeTableSQL;
using System.Collections.Generic;
namespace EmployeeDataTest
{
    [TestClass]
    public class EmployeeDataTest
    {
        [TestMethod]
        public void EmployeeDataTest_01()
        {
            String table = "employeeDetails";
            String expectedResult = "{1 : Danny, 2 : Jack, 3 : Hana, ";

            Employee empObj = new Employee();
            Dictionary<string, string> actualResult = empObj.getEmpDetails(table);

            String dictionaryString = "{";
            foreach (KeyValuePair<string, string> keyValues in actualResult)
            {
                dictionaryString += keyValues.Key + " : " + keyValues.Value + ", ";
            }
            
            Assert.AreEqual(expectedResult, dictionaryString);

        }

        [TestMethod]
        public void EmployeeDataTest_02()
        {
            String table = "noTable";
            String expectedResult = " ";

            Employee empObj = new Employee();
            Dictionary<string, string> actualResult = empObj.getEmpDetails(table);

            String dictionaryString = " ";
            foreach (KeyValuePair<string, string> keyValues in actualResult)
            {
                dictionaryString += keyValues.Key + " : " + keyValues.Value + ", ";
            }

            Assert.AreEqual(expectedResult, dictionaryString);

        }

        [TestMethod]
        public void EmployeeDataTest_03()
        {
            String table = " ";
            String expectedResult = " ";

            Employee empObj = new Employee();
            Dictionary<string, string> actualResult = empObj.getEmpDetails(table);

            String dictionaryString = " ";
            foreach (KeyValuePair<string, string> keyValues in actualResult)
            {
                dictionaryString += keyValues.Key + " : " + keyValues.Value + ", ";
            }

            Assert.AreEqual(expectedResult, dictionaryString);

        }
    }
}
