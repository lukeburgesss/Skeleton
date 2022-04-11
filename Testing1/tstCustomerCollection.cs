using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{

    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountStatus = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Sam Smith";
            TestItem.CustomerContactNo = "01234567890";
            TestItem.DeliveryAddr = "Some address";
            TestItem.CustomerDob = Convert.ToDateTime("15/04/2002");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
       
        [TestMethod]
        public void ThisCustomerPorpertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.AccountStatus = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.CustomerName = "Sam Smith";
            TestCustomer.CustomerContactNo = "01234567890";
            TestCustomer.DeliveryAddr = "Some address";
            TestCustomer.CustomerDob = Convert.ToDateTime("15/04/2002");
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AccountStatus = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Sam Smith";
            TestItem.CustomerContactNo = "01234567890";
            TestItem.DeliveryAddr = "Some address";
            TestItem.CustomerDob = Convert.ToDateTime("15/04/2002");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the ckass we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountStatus = true;
            TestItem.CustomerNo = 1;
            TestItem.CustomerName = "Sam Smith";
            TestItem.CustomerContactNo = "07555555555";
            TestItem.DeliveryAddr = "2 Bond Street, W17 5HT";
            TestItem.CustomerDob = Convert.ToDateTime("24/03/2000");
            //set ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            //set the primary key of the test data
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //find the record
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the ckass we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountStatus = true;
            TestItem.CustomerName = "Sam Smith";
            TestItem.CustomerContactNo = "07555555555";
            TestItem.DeliveryAddr = "2 Bond Street, W17 5HT";
            TestItem.CustomerDob = Convert.ToDateTime("24/03/2000");
            //set ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            //set the primary key of the test data
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the test data
            TestItem.AccountStatus = false;
            TestItem.CustomerName = "some name";
            TestItem.CustomerContactNo = "0766666666";
            TestItem.DeliveryAddr = "5 High Street, W18 6HT";
            TestItem.CustomerDob = Convert.ToDateTime("15/03/2002");
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the ckass we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AccountStatus = true;
            TestItem.CustomerName = "Sam Smith";
            TestItem.CustomerContactNo = "07555555555";
            TestItem.DeliveryAddr = "2 Bond Street, W17 5HT";
            TestItem.CustomerDob = Convert.ToDateTime("24/03/2000");
            //set ThisCustomer to test data
            AllCustomers.ThisCustomer = TestItem;
            //set the primary key of the test data
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see record was not found
            Assert.IsFalse(Found);
        }

    }
    }
