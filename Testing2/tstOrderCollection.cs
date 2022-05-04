using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test to assign to the property
            //in this case the date needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderIsPaid = true;
            TestItem.OrderName = "gloria";
            TestItem.OrderCreationDate = DateTime.Now.Date;
            TestItem.TotalProduct = 14;
            TestItem.ProductID = 2;
            TestItem.OrderId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrders.OrderList = TestList;
            //test to se that the two values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }

        public void ThisOrdersPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test to assign to the property
            clsOrder TestOrders = new clsOrder();
            //set the properties
            TestOrders.OrderIsPaid = true;
            TestOrders.OrderName = "gloria";
            TestOrders.OrderCreationDate = DateTime.Now.Date;
            TestOrders.TotalProduct = 14;
            TestOrders.ProductID = 2;
            TestOrders.OrderId = 1;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrders;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test to assign to the property
            //in this case the date needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list 
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderIsPaid = true;
            TestItem.OrderName = "gloria";
            TestItem.OrderCreationDate = DateTime.Now.Date;
            TestItem.TotalProduct = 14;
            TestItem.ProductID = 2;
            TestItem.OrderId = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllOrders.OrderList = TestList;
            //test to se that the two values are the same 
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create a item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primeay key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderIsPaid = true;
            TestItem.OrderName = "gloria";
            TestItem.OrderCreationDate = DateTime.Now.Date;
            TestItem.TotalProduct = 14;
            TestItem.ProductID = 2;
            TestItem.OrderId = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data 
            TestItem.OrderId = PrimaryKey;
            //find the record 
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create a item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primeay key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderIsPaid = true;
            TestItem.OrderName = "gloria";
            TestItem.OrderCreationDate = DateTime.Now.Date;
            TestItem.TotalProduct = 14;
            TestItem.ProductID = 2;
            TestItem.OrderId = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the prymary key of the test data 
            TestItem.OrderId = PrimaryKey;
            //modify the test data 
            TestItem.OrderIsPaid = false;
            TestItem.OrderName = "benta";
            TestItem.OrderCreationDate = DateTime.Now.Date;
            TestItem.TotalProduct = 4;
            TestItem.ProductID = 3;
            TestItem.OrderId = 5;
            //set the record based on the new test data 
            AllOrders.ThisOrder = TestItem;
            //uppdate the recode 
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see thisAddress matches the test data 
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create a item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primeay key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderIsPaid = true;
            TestItem.OrderName = "gloria";
            TestItem.OrderCreationDate = DateTime.Now.Date;
            TestItem.TotalProduct = 14;
            TestItem.ProductID = 2;
            TestItem.OrderId = 1;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the prymary key of the test data 
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record 
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that thr record was not found 
            Assert.IsFalse(Found); 
        }

        [TestMethod]
        public void ReportByOrderNameMethodOK()
        {
            //create an instance of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredOrder.ReportByOrderName("");
            //test to see that the teo values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrder.Count);
        }

        [TestMethod]
        public void ReportByOrderNameNoneFound()
        {
            //create an instance of the class we want to create 
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //apply a blank string which returns all records
            FilteredOrder.ReportByOrderName("fdjbdjhbjhkdahkncz");
            //test to see that there are no recordes 
            Assert.AreEqual(0, FilteredOrder.Count);
        }

        public void ReportByOrdertNameTestDataFound()
        {
            //create an instance of the class we want to create 
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //var to store outcome 
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredOrder.ReportByOrderName("lets see");
            //checkthe correct number of records is found
            if (FilteredOrder.Count == 2)
            {
                if (FilteredOrder.OrderList[0].OrderId !=100)
                {
                    OK = false;
                }
                if (FilteredOrder.OrderList[1].OrderId != 101)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }

            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
