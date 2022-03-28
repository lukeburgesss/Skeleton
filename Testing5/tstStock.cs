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
        public void ProductIdOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //create some test data to assign to property
            Int32 TestData = 1;
            //assign the data to the property
            theStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theStock.ProductId, TestData);

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
            Int32 TestData = 1;
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

        [TestMethod]
        public void FindMethodOK()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //check the ProductID
            if (theStock.ProductId != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //check the ProductID
            if (theStock.ProductName != "Blue Sock")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //check the ProductID
            if (theStock.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductQuantityFound()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //check the ProductID
            if (theStock.ProductQuantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastAdjustmentFound()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //check the ProductID
            if (theStock.LastAdjustment != Convert.ToDateTime("24/07/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //check the ProductID
            if (theStock.Colour != "Blue")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //creates an instance of the class we want to create
            clsStock theStock = new clsStock();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 ProductId = 10;
            //invoke the method
            Found = theStock.Find(ProductId);
            //check the ProductID
            if (theStock.Price != 1.12)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
