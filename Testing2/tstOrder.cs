using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Testing2
{
    [TestClass]
 
    public class tstOrder
    {
       //---- week 24 ----
        //good test data 
        //create some test data to pass the method
        string OrderName = "Gloria Lubwimi";
        string OrderCreationDate = DateTime.Now.Date.ToString();
        



        [TestMethod]
        
        public void InstanceOK()
        {
            //create an intance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(theOrder);

        }

        [TestMethod]
        public void OrderIdOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //create some test data to assign to property
            int TestData = 1;
            //assign the data to the property
            theOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theOrder.OrderId, TestData);

        }




        [TestMethod]
        public void ProductIDOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //create some test data to assign to property
            int TestData = 1;
            //assign the data to the property
            theOrder.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theOrder.ProductID, TestData);

        }

        [TestMethod]
        public void TotalProductOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //create some test data to assign to property
            int TestData = 1;
            //assign the data to the property
            theOrder.TotalProduct = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theOrder.TotalProduct, TestData);

        }

        [TestMethod]
        public void OrderIsPaidOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //create some test data to assign to property
            Boolean TestData = true;
            //assign the data to the property
            theOrder.OrderIsPaid = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(theOrder.OrderIsPaid, TestData);

        }

        [TestMethod]
        public void OrderCreationDateOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //create some test data to assign the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            theOrder.OrderCreationDate = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theOrder.OrderCreationDate, TestData);
        }

        [TestMethod]
        public void OrderNameOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //create some test data to assign the property
            string TestData = "14bgkw jag";
            //assign the data to the property
            theOrder.OrderName = TestData;
            //test to see that the two are equal
            Assert.AreEqual(theOrder.OrderName, TestData);
        }

        //---week 23-----


        [TestMethod]
        public void FindMethodOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = theOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        //klar

        [TestMethod]
        public void TestOrderIdFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = theOrder.Find(OrderId);
            //check the OrderId
            if (theOrder.OrderId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar

        [TestMethod]
        public void TestProductIDFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = theOrder.Find(OrderId);
            //check the ProductID
            if (theOrder.ProductID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar

        [TestMethod]
        public void TestTotalProductFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = theOrder.Find(OrderId);
            //check the Total product
            if (theOrder.TotalProduct != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //klar

        [TestMethod]
        public void TestOrderIsPaidFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = theOrder.Find(OrderId);
            //check the Order Is Paid
            if (theOrder.OrderIsPaid != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar
        [TestMethod]
        public void TestOrderCreactionDateFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = theOrder.Find(OrderId);
            //check the Order Creaction Date
            if (theOrder.OrderCreationDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar
        [TestMethod]
        public void TestOrderNameFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = theOrder.Find(OrderId);
            //check the Order Creaction Date
            if (theOrder.OrderName != "Gloria Yes")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar



        //.....week 24......

        [TestMethod]
        public void ValidMethodOK()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see tat the result is correct
            Assert.AreEqual(Error, "");
        }

        //---- OrderName ----

        [TestMethod]
        public void OrderNameMinLessOne()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = ""; //this should trigger an error 
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMin()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = "a"; //this should be ok
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMinPlussOne()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = "aa"; //this should be ok
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = String.Concat(Enumerable.Repeat("a", 99)); //should pass
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void OrderNameMax()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = String.Concat(Enumerable.Repeat("a", 100)); //should pass
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMaxPlussOne()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = String.Concat(Enumerable.Repeat("a", 101)); //should trigger an error
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameMid()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = String.Concat(Enumerable.Repeat("a", 50)); //should pass
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNameExtremeMax()
        {
            // create an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string OrderName = String.Concat(Enumerable.Repeat("a", 500)); //this should fail
            //invok the method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //---- OrderCreationDate ----

        [TestMethod]
        public void OrderCreationDateExtremeMin()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create  avariable to store the test date data
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change data to extreme min
            TestData = TestData.AddYears(-100);
            //convert the data to a string variable
            string OrderCreationDate = TestData.ToString();
            //invoke method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to tee the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderCreationDateMinLessOne()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create  avariable to store the test date data
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change data to extreme min
            TestData = TestData.AddDays(-1);
            //convert the data to a string variable
            string OrderCreationDate = TestData.ToString();
            //invoke method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to tee the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderCreationDateMin()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create  avariable to store the test date data
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //convert the data to a string variable
            string OrderCreationDate = TestData.ToString();
            //invoke method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to tee the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderCreationDateMinPlusOne()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create  avariable to store the test date data
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change data to extreme min
            TestData = TestData.AddDays(1);
            //convert the data to a string variable
            string OrderCreationDate = TestData.ToString();
            //invoke method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to tee the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderCreationDateExtremeMax()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create  avariable to store the test date data
            DateTime TestData;
            //set the date to todays date
            TestData = DateTime.Now.Date;
            //change data to extreme min
            TestData = TestData.AddYears(100);
            //convert the data to a string variable
            string OrderCreationDate = TestData.ToString();
            //invoke method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to tee the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //---- invalid data ----


        [TestMethod]
        public void OrderCreationDateInvalidData()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the data added to not be a date
            string OrderCreationDate = "This is not a data";
            //invoke method
            Error = theOrder.Valid(OrderName, OrderCreationDate);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }


    }


}

    

