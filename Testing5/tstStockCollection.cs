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
    }
}
