using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //private data member thisOrder


        //constructor for the class
        public clsOrderCollection()
        {

            //var for the index
            Int32 Index = 0;
            //var to store the record
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //get the count of records
            while (Index < RecordCount)
            {
                //creates a blank address
                clsOrder TheOrder = new clsOrder();
                //read in the fields from current record
                TheOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                TheOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                TheOrder.TotalProduct = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalProduct"]);
                TheOrder.OrderIsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderIsPaid"]);
                TheOrder.OrderCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderCreationDate"]);
                TheOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
            }





            /* 
             //create the item of test data
             clsOrder TestItem = new clsOrder();
             //set its properties
             TestItem.OrderIsPaid = true;
             TestItem.OrderName = "gloria";
             TestItem.OrderCreationDate = DateTime.Now.Date;
             TestItem.TotalProduct = 14;
             TestItem.ProductID = 2;
             TestItem.OrderId = 1;
             //add the item to the test list
             mOrderList.Add(TestItem);
             //re initialise the object for some new data 
             TestItem = new clsOrder();
             //set its properties
             TestItem.OrderIsPaid = true;
             TestItem.OrderName = "sara";
             TestItem.OrderCreationDate = DateTime.Now.Date;
             TestItem.TotalProduct = 2;
             TestItem.ProductID = 4;
             TestItem.OrderId = 5;
             //add the item to the test list
             mOrderList.Add(TestItem);
            */
        }





        public List<clsOrder> OrderList 
        { 
            get
            {
                //return the private data
                return mOrderList;

            }
            set
            {
                //set the private data
                mOrderList = value;

            }
        }
        public clsOrder ThisOrder { get; set; }
        public int Count 
        { 
            get
            {
                return mOrderList.Count;

            }
            set
            {
                //we shall worry about this later 
            }
        }
    }
}