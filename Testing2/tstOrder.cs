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





    }
}
