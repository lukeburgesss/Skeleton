using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
        private const double V = 1.99;

        [TestMethod]
        public void InsanceOK()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();

            //test to see that it exists 
            Assert.IsNotNull(aSupplier);

        }

        [TestMethod]
        public void SupplierIDOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aSupplier.SupplierID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.SupplierID, TestData);
        }


        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aSupplier.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aSupplier.DateAdded, TestData);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //create some test data
            string TestData = "Nike Tech Fleece Socks";
            //assign the data to the property
            aSupplier.Street = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aSupplier.Street, TestData);
        }

        [TestMethod]
        public void ProductQuantityOK()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 20;
            //assign the data to the property
            aSupplier.ProductQuantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aSupplier.ProductQuantity, TestData);
        }

        [TestMethod]
        public void PurchaseOK()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            aSupplier.Purchase = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aSupplier.Purchase, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //create some test data
            decimal TestData = 1.99m;
            //assign the data to the property
            aSupplier.Price = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aSupplier.Price, TestData);
        }

       }
    }

