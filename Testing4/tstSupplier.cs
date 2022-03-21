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
            aSupplier.SupplierDateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aSupplier.SupplierDateAdded, TestData);
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



        // ---------------- TEST FOR WEEK 23 ---------------

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //create some test data
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 SupplierID = 5;
            //invoke the method
            Found = aSupplier.Find(SupplierID);
            //test to see that the two values are the same 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIDFound ()
        {
            // create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to  use with the method 
            Int32 SupplierID = 5;
            //invoke the method 
            Found = aSupplier.Find(SupplierID);
            //check the  SupplierID 
            if (aSupplier.SupplierID != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            // create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to  use with the method 
            Int32 SupplierID = 5;
            //invoke the method 
            Found = aSupplier.Find(SupplierID);
            //check the  SupplierID 
            if (aSupplier.SupplierName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierDateAddedFound()
        {
            // create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to  use with the method 
            Int32 SupplierID = 5;
            //invoke the method 
            Found = aSupplier.Find(SupplierID);
            //check the  SupplierID 
            if (aSupplier.SupplierDateAdded != Convert.ToDateTime("28/05/2002"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierArchiveFound()
        {
            // create an instance of the class we want to create 
            clsSupplier aSupplier = new clsSupplier();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to  use with the method 
            Int32 SupplierID = 5;
            //invoke the method 
            Found = aSupplier.Find(SupplierID);
            //check the  SupplierID 
            if (aSupplier.SupplierArchive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




    }
   }

