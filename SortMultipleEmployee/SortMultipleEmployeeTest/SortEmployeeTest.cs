using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SortMultipleEmployee;

namespace SortMultipleEmployeeTest
{
    [TestClass]
    public class SortEmployeeTest
    {
        [TestMethod]
        public void SortEmployeeTest_01()
        {
            List<Employee> employeeList = new List<Employee>() {
                new Employee() { employeeName = "Grass", employeeAge = 21, employeeDept = "Security" } ,
                new Employee() { employeeName = "Tomar", employeeAge = 32, employeeDept = "FirstAid"  } ,
                new Employee() { employeeName = "Alpha", employeeAge = 22, employeeDept = "Market"   } ,

            };

            String[] expectedResult = { "Alpha", "Grass", "Tomar" };

            SortEmployee sort = new SortEmployee();
            String[] actualResult = sort.sortName(employeeList);

            for(int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void SortEmployeeTest_02()
        {
            List<Employee> employeeList = new List<Employee>() {
                new Employee() { employeeName = "Grass", employeeAge = 21, employeeDept = "Security" } ,
                new Employee() { employeeName = " ", employeeAge = 32, employeeDept = "FirstAid"  } ,
                new Employee() { employeeName = "Alpha", employeeAge = 22, employeeDept = "Market"   } ,

            };

            String[] expectedResult = { };

            SortEmployee sort = new SortEmployee();
            String[] actualResult = sort.sortName(employeeList);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void SortEmployeeTest_03()
        {
            List<Employee> employeeList = new List<Employee>() {
                new Employee() { employeeName = "Grass", employeeAge = 1, employeeDept = "Security" } ,
                new Employee() { employeeName = "Tomar", employeeAge = 32, employeeDept = "FirstAid"  } ,
                new Employee() { employeeName = "Alpha", employeeAge = 22, employeeDept = "Market"   } ,

            };

            String[] expectedResult = { };

            SortEmployee sort = new SortEmployee();
            String[] actualResult = sort.sortName(employeeList);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }

        [TestMethod]
        public void SortEmployeeTest_04()
        {
            List<Employee> employeeList = new List<Employee>() {
                new Employee() { employeeName = "Grass", employeeAge = 1, employeeDept = "Security" } ,
                new Employee() { employeeName = "Tomar", employeeAge = 32, employeeDept = "FirstAid"  } ,
                new Employee() { employeeName = "Alpha", employeeAge = 22, employeeDept = " "   } ,

            };

            String[] expectedResult = { };

            SortEmployee sort = new SortEmployee();
            String[] actualResult = sort.sortName(employeeList);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], actualResult[i]);
            }
        }
    }
}
