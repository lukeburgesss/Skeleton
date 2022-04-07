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
        string EmployeePhoneNo = "2443";
        string EmployeeHouseAddress = "123 fake streat";
        string Employeesalary = "100";
        string EmployeeName = "liuui";
        string EmployeeDob = (DateTime.Now.AddYears(-20)).ToString();


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
        /// <summary>
        /// ///// week 24 work begins hear          ///////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        [TestMethod]
        public void ValidMethodOk()
        {

            clsEmployee AnEmployee = new clsEmployee();

            String Error = "";

            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberMinlessone()
        {
            clsEmployee AnEmployee = new clsEmployee();

            String Error = "";

            string EmployeePhoneNo = "";

            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);

            Assert.AreNotEqual(Error, "");

        }
        public void PhonenumberNoMin()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePhoneNo = "1"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePhoneNo = "11"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePhoneNo = "111111111111111"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonenumberNoMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePhoneNo = "1111111111111111"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhonenumberNoMid()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePhoneNo = "11111111"; //this should be ok
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhonenumberNoExtreemMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePhoneNo = "";
            EmployeePhoneNo = EmployeePhoneNo.PadRight(100, '1');
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

     /*   [TestMethod]
        public void DobExtreemMin()
        {
            clsEmployee AnEmployee = new clsEmployee();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string EmployeeDob = TestDate.ToString();

            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);

            Assert.AreNotEqual(Error, "");
        }
     */
        [TestMethod]
        public void DobMinAddOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-17);
            //convert the date variable to a string variable
            string EmployeeDob = TestDate.ToString();
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMinLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-15);
            //convert the date variable to a string variable
            string EmployeeDob = TestDate.ToString();
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DobMin()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-16);
            //convert the date variable to a string variable
            string EmployeeDob = TestDate.ToString();
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


       /* [TestMethod]
        public void DobMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-89);
            //convert the date variable to a string variable
            string EmployeeDob = TestDate.ToString();
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-91);
            //convert the date variable to a string variable
            string EmployeeDob = TestDate.ToString();
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DobMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-90);
            //convert the date variable to a string variable
            string EmployeeDob = TestDate.ToString();
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }
        [TestMethod]
        public void DobExtreemMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string EmployeeDob = TestDate.ToString();
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, ""); 
        } */

        [TestMethod]
        public void DobInvalidData()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";

            string EmployeeDob = "this is not a date";

            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmployeeHouseAddress = "";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeHouseAddress = "a";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeHouseAddress = "aa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeHouseAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeHouseAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmployeeHouseAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeHouseAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmployeeName = "";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeName = "a";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void nameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeName = "aa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string EmployeeName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






        [TestMethod]
        public void salaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Employeesalary = "99";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void salaryMin()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Employeesalary = "100";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Employeesalary = "101";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Employeesalary = "999999998";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Employeesalary = "999999999";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Employeesalary = "1000000000";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void salaryMid()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Employeesalary = "500000000";
            //invoke the method
            Error = AnEmployee.Valid(EmployeeName, EmployeeHouseAddress, Employeesalary, EmployeePhoneNo, EmployeeDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
