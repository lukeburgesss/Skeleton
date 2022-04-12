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

        [TestMethod]
        public void AddMethodOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();

            clsEmployee TestItem = new clsEmployee();

            Int32 Primarykey = 0;

            TestItem.EmployeeID = 7;
            TestItem.EmployeePhoneNo = "27";
            TestItem.EmployeeName = "testp";
            TestItem.EmployeeDob = Convert.ToDateTime("08/06/1999");
            TestItem.EmployeeHouseAddress = "teststreat";
            TestItem.Employeesalary = 777;
            TestItem.EmployeeContractStatus = true;

            allEmployees.ThisEmployee = TestItem;

            Primarykey = allEmployees.Add();

            TestItem.EmployeeID = Primarykey;

            allEmployees.ThisEmployee.Find(Primarykey);

            Assert.AreEqual(allEmployees.ThisEmployee, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();

            clsEmployee TestItem = new clsEmployee();

            Int32 Primarykey = 0;


            TestItem.EmployeePhoneNo = "27";
            TestItem.EmployeeName = "testp";
            TestItem.EmployeeDob = Convert.ToDateTime("08/06/1999");
            TestItem.EmployeeHouseAddress = "teststreat";
            TestItem.Employeesalary = 777;
            TestItem.EmployeeContractStatus = true;

            allEmployees.ThisEmployee = TestItem;

            Primarykey = allEmployees.Add();

            TestItem.EmployeeID = Primarykey;

            TestItem.EmployeePhoneNo = "27";
            TestItem.EmployeeName = "Dog";
            TestItem.EmployeeDob = Convert.ToDateTime("08/06/2000");
            TestItem.EmployeeHouseAddress = "20 coldstream close";
            TestItem.Employeesalary = 170;
            TestItem.EmployeeContractStatus = false;

            allEmployees.ThisEmployee = TestItem;

            allEmployees.Update();

            allEmployees.ThisEmployee.Find(Primarykey);

            Assert.AreEqual(allEmployees.ThisEmployee, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();

            clsEmployee TestItem = new clsEmployee();

            Int32 Primarykey = 0;


            TestItem.EmployeePhoneNo = "27";
            TestItem.EmployeeName = "testp";
            TestItem.EmployeeDob = Convert.ToDateTime("08/06/1999");
            TestItem.EmployeeHouseAddress = "teststreat";
            TestItem.Employeesalary = 777;
            TestItem.EmployeeContractStatus = true;

            allEmployees.ThisEmployee = TestItem;

            Primarykey = allEmployees.Add();

            TestItem.EmployeeID = Primarykey;

            allEmployees.ThisEmployee.Find(Primarykey);

            allEmployees.Delete();

            Boolean Found = allEmployees.ThisEmployee.Find(Primarykey);

            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void reportbynameMethodOK()
        {
            clsEmployeeCollection allEmployees = new clsEmployeeCollection();

            clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();

            FilteredEmployees.ReportByName("");

            Assert.AreEqual(allEmployees.Count, FilteredEmployees.Count);

        }

        [TestMethod]
        public void reportbynamenonefound()
        {
            clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();

            FilteredEmployees.ReportByName("xxxx");


        }



        [TestMethod]
        public void reportbynameTestDatafound()
        {
            clsEmployeeCollection FilteredEmployees = new clsEmployeeCollection();

            Boolean OK = true;

            FilteredEmployees.ReportByName("luke");

                if (FilteredEmployees.Count == 2)
                {
                    if (FilteredEmployees.EmployeeList[0].EmployeeID != 1)
                    {
                    OK = false;
                    }
                    if (FilteredEmployees.EmployeeList[0].EmployeeID != 5)
                    {
                    OK = false;
                    }
                }
                else 
                {
                OK = false;
                }
            Assert.IsTrue(OK);
        }


    }
}
