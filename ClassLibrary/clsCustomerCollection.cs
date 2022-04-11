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
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomerManagementSystem_SelectAll");

            PopulateArray(DB);
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

        public void ReportByCustomerName(string CustomerName)
        {
            //filter the records based on a full or partial post code
            //connect to the databse
            clsDataConnection DB = new clsDataConnection();
            //sent the name parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);
            //execute the strored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();

                ACustomer.AccountStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["AccountStatus"]);
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerContactNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerContactNo"]);
                ACustomer.DeliveryAddr = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryAddr"]);
                ACustomer.CustomerDob = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDob"]);


                mCustomerList.Add(ACustomer);

                Index++;
            }
        }
    }
}