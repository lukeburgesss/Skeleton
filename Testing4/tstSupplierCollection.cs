using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing4
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Assert.IsNotNull(AllSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            List<clsSupplier> TestList = new List<clsSupplier>();

            clsSupplier TestItem = new clsSupplier();

            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Amin";
            TestItem.SupplierDateAdded = Convert.ToDateTime("28/05/2002");
            TestItem.SupplierArchive = true;
            TestList.Add(TestItem);

            AllSuppliers.SupplierList = TestList;

            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            Int32 SomeCount = 0;
            AllSuppliers.Count = SomeCount;

            Assert.AreEqual(AllSuppliers.Count, SomeCount);

        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            clsSupplier TestSupplier = new clsSupplier();

            TestSupplier.SupplierID = 1;
            TestSupplier.SupplierName = "Amin";
            TestSupplier.SupplierDateAdded = Convert.ToDateTime("28/05/2002");
            TestSupplier.SupplierArchive = true;

            AllSuppliers.ThisSupplier = TestSupplier;

            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            List<clsSupplier> TestList = new List<clsSupplier>();

            clsSupplier TestItem = new clsSupplier();

            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Amin";
            TestItem.SupplierDateAdded = Convert.ToDateTime("28/05/2002");
            TestItem.SupplierArchive = true;
            TestList.Add(TestItem);

            AllSuppliers.SupplierList = TestList;

            Assert.AreEqual(AllSuppliers.Count, TestList.Count);

        }
    }
   
}