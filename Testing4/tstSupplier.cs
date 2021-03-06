using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplier
    {


        //good test data
        //create some testt data to pas to the module 
        string SupplierName = "Test Name";
        string SupplierDateAdded = DateTime.Now.Date.ToString();


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
            int TestData = 1;
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
            int SupplierID = 1;
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
            int SupplierID = 1;
            //invoke the method 
            Found = aSupplier.Find(SupplierID);
            //check the  SupplierID 
            if (aSupplier.SupplierID != 1)
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
            int SupplierID = 1;
            //invoke the method 
            Found = aSupplier.Find(SupplierID);
            //check the  SupplierID 
            if (aSupplier.SupplierName != "Amin") 
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
            int SupplierID = 1;
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
            int SupplierID = 1;
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

        // --------------------- WEEK 24 -----------------------------------

       [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier aSupplier = new clsSupplier();

            String Error = "";

            Error = aSupplier.Valid(SupplierName,SupplierDateAdded);

            Assert.AreEqual(Error, "");
        }


        
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsSupplier aSupplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string SupplierDateAdded = TestDate.ToString();

            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsSupplier aSupplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(-1);

            string SupplierDateAdded = TestDate.ToString();

            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsSupplier aSupplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string SupplierDateAdded = TestDate.ToString();

            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsSupplier aSupplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(1);

            string SupplierDateAdded = TestDate.ToString();

            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsSupplier aSupplier = new clsSupplier();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddDays(100);

            string SupplierDateAdded = TestDate.ToString();

            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsSupplier aSupplier = new clsSupplier();

            String Error = "";

            string SupplierDateAdded = "This is not a Date !"; 

            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierName = "";
            //invoke the method
            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierName = "a";
            //invoke the method
            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierName = "aa";
            //invoke the method
            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierName = "";

            SupplierName = SupplierName.PadRight(49, 'a');
            //invoke the method
            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierName = "";

            SupplierName = SupplierName.PadRight(50, 'a');
            //invoke the method
            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierName = "";
            //invoke the method
            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsSupplier aSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SupplierName = "";

            SupplierName = SupplierName.PadRight(25, 'a');
            //invoke the method
            Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
   }

