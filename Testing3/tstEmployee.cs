using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstEmployee
    {

        
            //good test data
            //create some testt data to pas to the module 
            string EmployeeID = "11";
            string EmployeePhoneNo = "2443";
            string EmployeeHouseAddress = "123 fake streat";
            string Employeesalary = "100";
            string EmployeeName = "liuui";
            string EmployeeDob = DateTime.Now.Date.ToString();

        
        private const double V = 1.99;

        [TestMethod]
        public void InsanceOK()
        {
            //create an instance of the class we want to create 
            clsEmployee anEmployee = new clsEmployee();

            //test to see that it exists 
            Assert.IsNotNull(anEmployee);
            //testtest
        }

        [TestMethod]
        public void EmployeeIDOK()
        {
            //create an instance of the class we want to create
            clsEmployee anEmployee = new clsEmployee();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the propertyw
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
            anEmployee.EmployeeName = TestData;
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
            AnEmployee.EmployeePhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeePhoneNo, TestData);
        }

        [TestMethod]
        public void HomeAddressOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "21 blurb streat";
            //assign the data to the property
            AnEmployee.EmployeeHouseAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeHouseAddress, TestData);
        }

        [TestMethod]
        public void SalaryOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            Decimal TestData = 17000;
            //assign the data to the property
            AnEmployee.Employeesalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.Employeesalary, TestData);


        }
        [TestMethod]
        public void ContractStatusOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnEmployee.EmployeeContractStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.EmployeeContractStatus, TestData);
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// beging of Find Ok
        /// </summary>

        [TestMethod]
        public void FindMethodOK()
        {
            //creates instance of class we want to create 
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AnEmployee.Find(EmployeeID);

            //test to see if the result is true
            Assert.IsTrue(Found);



        }
        [TestMethod]
        public void TestEmployeeNoFound()
        {
            //create instance of class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assum it is)
            Boolean OK = true;
            //create sum test data
            Int32 EmployeeID = 1;
            //ivoke the method
            Found = AnEmployee.Find(EmployeeID);
            //check addrress no
            if (AnEmployee.EmployeeID != 1)
            {
                OK = false;
            }
            //test ti see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestEmployeeNameFound()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AnEmployee.Find(EmployeeID);
            //check the property
            if (AnEmployee.EmployeeName != "luke")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmployeeDobOKFound()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AnEmployee.Find(EmployeeID);
            //check the property
            if (AnEmployee.EmployeeDob != Convert.ToDateTime("08/06/2002"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestContactNumberFound()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AnEmployee.Find(EmployeeID);
            //check the property
            if (AnEmployee.EmployeePhoneNo != ("5641"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HomeAddressTestFound()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AnEmployee.Find(EmployeeID);
            //check the property
            if (AnEmployee.EmployeeHouseAddress != ("1 frake streat"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void SalaryTestFound()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AnEmployee.Find(EmployeeID);
            //check the property
            if (AnEmployee.Employeesalary != Convert.ToDecimal(100))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ContractStatusFound()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeID = 1;
            //invoke the method
            Found = AnEmployee.Find(EmployeeID);
            //check the property
            if (AnEmployee.EmployeeContractStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

       [TestMethod]
        public void ValidMethodOk()
        {
            
            clsEmployee AnEmployee = new clsEmployee();
         
            String Error = "";
       
            Error = AnEmployee.Valid(EmployeeID,EmployeeName,EmployeeHouseAddress,Employeesalary, EmployeePhoneNo,EmployeeDob);
     
            Assert.AreEqual(Error, "");
        }
   
    }
}
