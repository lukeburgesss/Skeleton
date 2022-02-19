using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock theStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(theStock);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign to property
            int TestData = 1;
            //assign the data to the property
            theStock.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theStock.ProductID, TestData);

        }

        [TestMethod]
        public void ProductNameOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign the property
            string TestData = "Hello There1";
            //assign the data to the property
            theStock.ProductName = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theStock.ProductName, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign the property
            Boolean TestData = true;
            //assign the data to the property
            theStock.InStock = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theStock.InStock, TestData);
        }

        [TestMethod]
        public void ProductQuantityOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign the property
            int TestData = 1;
            //assign the data to the property
            theStock.ProductQuantity = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theStock.ProductQuantity, TestData);
        }

        [TestMethod]
        public void LastAdjustmentOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            theStock.LastAdjustment = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theStock.LastAdjustment, TestData);
        }

        [TestMethod]
        public void ColourOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign the property
            string TestData = "Hello There1";
            //assign the data to the property
            theStock.Colour = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theStock.Colour, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign the property
            double TestData = 1.50;
            //assign the data to the property
            theStock.Price = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theStock.Price, TestData);
        }
    }
}
