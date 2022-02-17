using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {
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
        public void SupplierDateAddedOK()
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
        public void SupplierNameOK()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //create some test data
            string TestData = "Nike";
            //assign the data to the property
            aSupplier.SupplierName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aSupplier.SupplierName, TestData);
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



       }
    }

