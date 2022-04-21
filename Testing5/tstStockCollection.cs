using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //creats the items of the test data
            clsStockCollection AllStock = new clsStockCollection();
            //list of objects
            List<clsStock> TestList = new List<clsStock>();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Colour = "Blue";
            TestItem.InStock = true;
            TestItem.LastAdjustment = DateTime.Now.Date;
            TestItem.Price = 1.12;
            TestItem.ProductId = 1;
            TestItem.ProductName = "Blue Sock";
            TestItem.ProductQuantity = 10;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see the two values are equal
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data
            clsStock TestStock = new clsStock();
            //set the properties
            TestStock.Colour = "Blue";
            TestStock.InStock = true;
            TestStock.LastAdjustment = DateTime.Now.Date;
            TestStock.Price = 1.12;
            TestStock.ProductId = 1;
            TestStock.ProductName = "Blue Sock";
            TestStock.ProductQuantity = 10;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see the two are equal
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create a list
            List<clsStock> TestList = new List<clsStock>();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set the properties
            TestItem.Colour = "Blue";
            TestItem.InStock = true;
            TestItem.LastAdjustment = DateTime.Now.Date;
            TestItem.Price = 1.12;
            TestItem.ProductId = 1;
            TestItem.ProductName = "Blue Sock";
            TestItem.ProductQuantity = 10;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see the two are equal
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Colour = "Orange";
            TestItem.InStock = true;
            TestItem.LastAdjustment = DateTime.Now.Date;
            TestItem.Price = 1.12;
            TestItem.ProductId = 4;
            TestItem.ProductName = "Orange Sock";
            TestItem.ProductQuantity = 10;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two ar equal
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Colour = "Orange";
            TestItem.InStock = true;
            TestItem.LastAdjustment = DateTime.Now.Date;
            TestItem.Price = 1.12;
            TestItem.ProductId = 4;
            TestItem.ProductName = "Orange Sock";
            TestItem.ProductQuantity = 10;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //modify the test data
            TestItem.Colour = "Purple";
            TestItem.InStock = true;
            TestItem.LastAdjustment = DateTime.Now.Date;
            TestItem.Price = 1.12;
            TestItem.ProductId = 4;
            TestItem.ProductName = "Purple Sock";
            TestItem.ProductQuantity = 10;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two ar equal
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //creates an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Colour = "Orange";
            TestItem.InStock = true;
            TestItem.LastAdjustment = DateTime.Now.Date;
            TestItem.Price = 1.12;
            TestItem.ProductId = 4;
            TestItem.ProductName = "Orange Sock";
            TestItem.ProductQuantity = 10;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string which returns all records
            FilteredStock.ReportByProductName("");
            //test to see that the two are equal
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string which returns all records
            FilteredStock.ReportByProductName("kjdsfdsfdsfsdfkjsdhfkjdsfh");
            //test to see that the two are equal
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection FilteredStock = new clsStockCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a product name that doesn't exist
            FilteredStock.ReportByProductName("Maroon Sock");
            //checkthe correct number of records is found
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].ProductId != 38)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].ProductId != 39)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(OK);
        }
    }
}
