using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass to the method
        string CustomerName = "Sam Smith";
        string CustomerContactNo = "0123456789012345";
        string DeliveryAddr = "2 Bond Street, W17 5HT";
        string CustomerDob = DateTime.Now.Date.ToString();




        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActiveAccountOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.AccountStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.AccountStatus, TestData);
        }
        [TestMethod]
        public void CustomerDobOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.CustomerDob = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerDob, TestData);
        }
        [TestMethod]
        public void CustomerNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }
        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Name";
            //assign the data to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }
        [TestMethod]
        public void CustomerContactNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "012345679012345";
            //assign the data to the property
            ACustomer.CustomerContactNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerContactNo, TestData);
        }
        [TestMethod]
        public void DeliveryAddrOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Some Address";
            //assign the data to the property
            ACustomer.DeliveryAddr = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DeliveryAddr, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerName != "Sam Smith")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerContactNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerContactNo != "07555555555")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveryAddrFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.DeliveryAddr != "2 Bond Street, W17 5HT")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerDobFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.CustomerDob != Convert.ToDateTime("24/03/2000"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAccountStatusFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the address no
            if (ACustomer.AccountStatus != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        //CUSTOMER NAME VALIDATION TESTS
        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "a"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');    //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //CUSTOMER CONTACT NO VALIDATION TESTS
        [TestMethod]
        public void CustomerContactNoMinLessOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerContactNoMin()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = "0"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerContactNoMinPlusOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = "01"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerContactNoMaxLessOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = "012345678901234"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerContactNoMax()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = "0123456789012345"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerContactNoMid()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = "01234567"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerContactNoMaxPlusOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = "01234567890123456"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerContactNoExtremeMax()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerContactNo = "";
            CustomerName = CustomerName.PadRight(500, '0');    //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //CUSTOMER DELIVERY ADDR VALIDATION TESTS
        [TestMethod]
        public void DeliveryAddrMinLessOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddrMin()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = "a"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddrMinPlusOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = "aa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddrMaxLessOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddrMax()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddrMid()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this would be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddrMaxPlusOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryAddrExtremeMax()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddr = "";
            CustomerName = CustomerName.PadRight(500, '0');    //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        //CUSTOMER DOB VALIDATION TESTS
        [TestMethod]
        public void CustomerDobExtremeMin()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string CustomerDob = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMinLessOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string CustomerDob = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMin()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string CustomerDob = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobMinPlusOne()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string CustomerDob = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobExtremeMax()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string CustomerDob = TestDate.ToString();
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDobInvalidData()
        {
            //create an isntance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string CustomerDob = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerContactNo, DeliveryAddr, CustomerDob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }








    }
}
