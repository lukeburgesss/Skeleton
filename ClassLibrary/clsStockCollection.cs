using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection     
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member thisStock
        clsStock mThisStock = new clsStock();

       //constructor for the class
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //populate array list with the table data
            PopulateArray(DB);
        }
        public List<clsStock> StockList 
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count 
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //later
            }
        }
        public clsStock ThisStock 
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@InStock", mThisStock.InStock);
            DB.AddParameter("@ProductQuantity", mThisStock.ProductQuantity);
            DB.AddParameter("@LastAdjustment", mThisStock.LastAdjustment);
            DB.AddParameter("@Colour", mThisStock.Colour);
            DB.AddParameter("@Price", mThisStock.Price);
            //execute the query
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values
            //conect to databse
            clsDataConnection DB = new clsDataConnection();
            //set parameters for stored procedure
            DB.AddParameter("@ProductId", ThisStock.ProductId);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@InStock", mThisStock.InStock);
            DB.AddParameter("@ProductQuantity", mThisStock.ProductQuantity);
            DB.AddParameter("@LastAdjustment", mThisStock.LastAdjustment);
            DB.AddParameter("@Colour", mThisStock.Colour);
            DB.AddParameter("@Price", mThisStock.Price);
            //execute the query
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed by ProductId
            //conect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters or stored procedure
            DB.AddParameter("@ProductId", mThisStock.ProductId);
            //execute stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            //filters the records based on a full or partial Product Name
            clsDataConnection DB = new clsDataConnection();
            //send the ProductName to database
            DB.AddParameter("@ProductName", ProductName);
            //execute procedure
            DB.Execute("sproc_tblStock_FilterByProductName");
            //populate array list with the table data
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based of the data table in th eparameter DB
            //var for the index
 
            Int32 Index = 0;
            //var to store the record
            Int32 RecordCount;
            //get count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //get the count of records
            while (Index < RecordCount)
            {
                //creates a blank address
                clsStock TheStock = new clsStock();
                //read in the fields from current record
                TheStock.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                TheStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                TheStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                TheStock.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                TheStock.LastAdjustment = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastAdjustment"]);
                TheStock.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                TheStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the records to the private data member
                mStockList.Add(TheStock);
                //point at the next record
                Index++;
            }
        }
    }
}