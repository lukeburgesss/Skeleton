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
    }
}
