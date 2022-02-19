using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
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
            ACustomer.ActiveAccount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.ActiveAccount, TestData);
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
    }
}
