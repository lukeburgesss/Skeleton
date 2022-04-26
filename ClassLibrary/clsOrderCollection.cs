using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();


        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
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
      
        
        //public property for ThisOrder
        public clsOrder ThisOrder {
            get 
            {
                //return the private data
                return mThisOrder;

            }
            set 
            {
                //set the privet data 
                mThisOrder = value;
            }
        }
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

        public int Add()
        {
            //adds a new recorde to the database based on the value of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@TotalProduct", mThisOrder.TotalProduct);
            DB.AddParameter("@OrderIsPaid", mThisOrder.OrderIsPaid);
            DB.AddParameter("@OrderCreationDate", mThisOrder.OrderCreationDate);
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            //execute the query returning the prymary key
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            //adds a new recorde to the database based on the value of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@TotalProduct", mThisOrder.TotalProduct);
            DB.AddParameter("@OrderIsPaid", mThisOrder.OrderIsPaid);
            DB.AddParameter("@OrderCreationDate", mThisOrder.OrderCreationDate);
            DB.AddParameter("@OrderName", mThisOrder.OrderName);
            //execute the query returning the prymary key
            DB.Execute("sproc_tblOrder_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed by ProductId
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters or stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByOrderName(string OrderName)
        {
            //filters the records bassed on a full or partial post code 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database 
            DB.AddParameter("@OrderId", OrderName);
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByOrderName");
            //populate the array list with the data table 
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based of the data table in th eparameter DB
            //var for the index

            Int32 Index = 0;
            //var to store the recotd count
            Int32 RecordCount;
            //get count of records
            RecordCount = DB.Count;
            //cleare the private array list 
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address 
                clsOrder TheOrder = new clsOrder();
                //read in the fields from the current record
                TheOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                TheOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                TheOrder.TotalProduct = Convert.ToInt32(DB.DataTable.Rows[Index]["TotalProduct"]);
                TheOrder.OrderIsPaid = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderIsPaid"]);
                TheOrder.OrderCreationDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderCreationDate"]);
                TheOrder.OrderName = Convert.ToString(DB.DataTable.Rows[Index]["OrderName"]);
                //add the record to the private data mamber 
                mOrderList.Add(TheOrder);
                //point at the newxt record 
                Index++;



            }
        }
    }
}