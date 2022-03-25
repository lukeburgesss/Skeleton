using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
 
    public class tstOrder
    {

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
            Boolean found = false;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            found = theOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(found);
        }
        //klar

        [TestMethod]
        public void TestOrderIdFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            found = theOrder.Find(OrderId);
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
            Boolean found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            found = theOrder.Find(OrderId);
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
            Boolean found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            found = theOrder.Find(OrderId);
            //check the Total product
            if (theOrder.TotalProduct != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //klar

        public void TestOrderIsPaidFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            found = theOrder.Find(OrderId);
            //check the Order Is Paid
            if (theOrder.OrderIsPaid != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar

        public void TestOrderCreactionDateFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            found = theOrder.Find(OrderId);
            //check the Order Creaction Date
            if (theOrder.OrderCreationDate != Convert.ToDateTime("24/07/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar

        public void TestOrderNameFound()
        {
            //creates an instance of the class we want to create
            clsOrder theOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //creates some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            found = theOrder.Find(OrderId);
            //check the Order Creaction Date
            if (theOrder.OrderName != "Gloria Yes")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //klar


    }


}

    

