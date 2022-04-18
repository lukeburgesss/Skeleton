using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection

      
    {
       //constructor for the class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get count of records
            RecordCount = DB.Count;
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
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
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
        public clsStock ThisStock { get; set; }
    }
}