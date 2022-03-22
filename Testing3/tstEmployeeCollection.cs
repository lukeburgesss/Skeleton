using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstEmployeeCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();
            Assert.IsNotNull(allEmployees);
        }

        [TestMethod]
        public void EmployeeListOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();

            List<clsEmployee> TestList = new List<clsEmployee>();

            clsEmployee TestItem = new clsEmployee();

            TestItem.EmployeeID = 1;
            TestItem.EmployeeName = "luke";
            TestItem.EmployeeDob = Convert.ToDateTime("08/06/2002");
            TestItem.EmployeeHouseAddress = "19 coldstream close";
            TestItem.Employeesalary = 180;
            TestItem.EmployeeContractStatus = true;

            TestList.Add(TestItem);

            allEmployees.EmployeeList = TestList;

            Assert.AreEqual(allEmployees.EmployeeList, TestList);


        }


        [TestMethod]
        public void ThisEmployeePropertyOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();

            clsEmployee TestEmployee = new clsEmployee();

            TestEmployee.EmployeeID = 1;
            TestEmployee.EmployeeName = "luke";
            TestEmployee.EmployeeDob = Convert.ToDateTime("08/06/2002");
            TestEmployee.EmployeeHouseAddress = "19 coldstream close";
            TestEmployee.Employeesalary = 180;
            TestEmployee.EmployeeContractStatus = true;

            allEmployees.ThisEmployee = TestEmployee;

            Assert.AreEqual(allEmployees.ThisEmployee, TestEmployee);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();

            List<clsEmployee> TestList = new List<clsEmployee>();

            clsEmployee TestItem = new clsEmployee();

            TestItem.EmployeeID = 1;
            TestItem.EmployeeName = "luke";
            TestItem.EmployeeDob = Convert.ToDateTime("08/06/2002");
            TestItem.EmployeeHouseAddress = "19 coldstream close";
            TestItem.Employeesalary = 180;
            TestItem.EmployeeContractStatus = true;

            TestList.Add(TestItem);

            allEmployees.EmployeeList = TestList;

            Assert.AreEqual(allEmployees.Count, TestList.Count);

        }





    }
}
