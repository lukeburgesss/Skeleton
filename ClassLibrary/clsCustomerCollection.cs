using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList 
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomerManagementSystem_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to proccess
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.AccountStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountStatus"]);
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerContactNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerContactNo"]);
                ACustomer.DeliveryAddr = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddr"]);
                ACustomer.CustomerDob = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDob"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }


            
        }

        public int Add()
        {
            //add a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerContactNo", mThisCustomer.CustomerContactNo);
            DB.AddParameter("@DeliveryAddr", mThisCustomer.DeliveryAddr);
            DB.AddParameter("@CustomerDob", mThisCustomer.CustomerDob);
            DB.AddParameter("@AccountStatus", mThisCustomer.AccountStatus);


            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //add a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerContactNo", mThisCustomer.CustomerContactNo);
            DB.AddParameter("@DeliveryAddr", mThisCustomer.DeliveryAddr);
            DB.AddParameter("@CustomerDob", mThisCustomer.CustomerDob);
            DB.AddParameter("@AccountStatus", mThisCustomer.AccountStatus);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}