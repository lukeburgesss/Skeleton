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

        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSuppliers= new clsSupplierCollection();

            clsSupplier TestItem = new clsSupplier();

            Int32 Primarykey = 0;

            TestItem.SupplierName = "Amin";
            TestItem.SupplierDateAdded = Convert.ToDateTime("28/05/2002");
            TestItem.SupplierArchive = true;

            AllSuppliers.ThisSupplier= TestItem;

            Primarykey = AllSuppliers.Add();

            TestItem.SupplierID = Primarykey;

            AllSuppliers.ThisSupplier.Find(Primarykey);

            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            clsSupplier TestItem = new clsSupplier();

            Int32 Primarykey = 0;

            TestItem.SupplierName = "Amin";
            TestItem.SupplierDateAdded = Convert.ToDateTime("28/05/2002");
            TestItem.SupplierArchive = true;

            AllSuppliers.ThisSupplier = TestItem;

            Primarykey = AllSuppliers.Add();

            TestItem.SupplierID = Primarykey;

            TestItem.SupplierID = 1;
            TestItem.SupplierName = "Amin";
            TestItem.SupplierDateAdded = Convert.ToDateTime("28/05/2002");
            TestItem.SupplierArchive = true;

            AllSuppliers.ThisSupplier.Find(Primarykey);

            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            clsSupplier TestItem = new clsSupplier();

            Int32 Primarykey = 0;

            TestItem.SupplierName = "Amin";
            TestItem.SupplierDateAdded = Convert.ToDateTime("28/05/2002");
            TestItem.SupplierArchive = true;

            AllSuppliers.ThisSupplier = TestItem;

            Primarykey = AllSuppliers.Add();

            TestItem.SupplierID = Primarykey;

            AllSuppliers.ThisSupplier.Find(Primarykey);
            AllSuppliers.Delete();

            Boolean Found = AllSuppliers.ThisSupplier.Find(Primarykey);

            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();

            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            FilteredSuppliers.ReportByName("");

            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);

        }

        [TestMethod]
        public void ReportByNameNoneMethodOK()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            FilteredSuppliers.ReportByName("xxxxxxxx");

            Assert.AreEqual(0, FilteredSuppliers.Count);

        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();

            Boolean OK = true;

            FilteredSuppliers.ReportByName("Amin Amin");

            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierID != 20)
                {
                    OK = false;
                }
                if (FilteredSuppliers.SupplierList[0].SupplierID != 21)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
   
}