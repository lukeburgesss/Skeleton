using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstEmployee
    {
        private const double V = 1.99;

        [TestMethod]
        public void InsanceOK()
        {
            //create an instance of the class we want to create 
            clsEmployee anEmployee = new clsEmployee();

            //test to see that it exists 
            Assert.IsNotNull(anEmployee);

        }

        [TestMethod]
        public void EmployeeIDOK()
        {
            //create an instance of the class we want to create
            clsEmployee anEmployee = new clsEmployee();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            anEmployee.EmployeeID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(anEmployee.EmployeeID, TestData);
        }


        [TestMethod]
        public void EmployeeNameOK()
        {
            //create an instance of the class we want to create 
            clsEmployee anEmployee = new clsEmployee();
            //create some test data
            string TestData = "Joe Bloggs";
            //assign the data to the property
            anEmployee.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(anEmployee.EmployeeName, TestData);
        }

        [TestMethod]
        public void EmployeeDobOK()
        {
            //create an instance of the class we want to create 
            clsEmployee anEmployee = new clsEmployee();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anEmployee.EmployeeDob = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(anEmployee.EmployeeDob, TestData);
        }

        [TestMethod]
        public void ContactNumberOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "55555 7070";
            //assign the data to the property
            AnEmployee.phoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.phoneNo, TestData);
        }

        [TestMethod]
        public void HomeAddressOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "21 blurb streat";
            //assign the data to the property
            AnEmployee.HouseAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.HouseAddress, TestData);
        }

        [TestMethod]
        public void SalaryOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            Decimal TestData = 17000;
            //assign the data to the property
            AnEmployee.salary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.salary, TestData);

        
        }
        [TestMethod]
        public void ContractStatusOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnEmployee.ContractStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.ContractStatus, TestData);
        }


    }



}


