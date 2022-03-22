using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsSupplier
    {
        // SupplierID
        //public int SupplierID { get; set; }

        // SupplierName
        // public string SupplierName { get; set; }

        // SupplierDateAdded
        // public DateTime SupplierDateAdded { get; set; }

        // Archive
        //public bool SupplierArchive { get; set; }




        //---------- Find Method --------------
        /*

        public bool Find(int supplierID)
        {
            //set the private data members to the test data value 
            aSupplierID = 21;
            //always return true
            return true;
        } */


        //----------------------- SUPPLIER ID TEST --------------------

        //private data member for the SupplierID property 
        private Int32 aSupplierID;
        //SupplierID Public Property
        public int SupplierID
        {
            get
            {
                //this line of code sends data out of the property 
                return aSupplierID;
            }

            set
            {
                //this line of code allows datat into the property 
                aSupplierID = value;
            }
        }

        //------------------- SUPPLIER NAME TEST ---------------------

        //private date added data member
        private string aSupplierName;
       
        //public property for date added
        public string SupplierName
        {
            get
            {
                //return the private data
                return aSupplierName;
            }
            set
            {
                //set the private data
                aSupplierName = value;
            }
        }

        //------------------- SUPPLIER DATE ADDED TEST ------------------

        //private date added data member
        private DateTime aSupplierDateAdded;
       
        //public property for date added
        public DateTime SupplierDateAdded
        {
            get
            {
                //return the private data
                return aSupplierDateAdded;
            }
            set
            {
                //set the private data
                aSupplierDateAdded = value;
            }
        }

        //------------------- SUPPLIER ARCHIVE TEST ------------------

        //private date added data member
        private Boolean aSupplierArchive;
        //public property for date added
        public bool SupplierArchive
        {
            get
            {
                //return the private data
                return aSupplierArchive;
            }
            set
            {
                //set the private data
                aSupplierArchive = value;
            }
        }

        //------------------- SUPPLIER TESTING --------------------

        public bool Find(int SupplierID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the employee no to search for
            DB.AddParameter("@SupplierID", SupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if one record is found there should be either one or zero!)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                aSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                aSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                aSupplierDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["SupplierDateAdded"]);
                aSupplierArchive = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierArchive"]);
                //return that everything worked OK
                return true;
                //if no record was found
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        /*
        public bool Find(int supplierID)
        {
            //set the private data members to the test data value
            aSupplierID = 21;
            aSupplierName = "Test Name";
            aSupplierDateAdded = Convert.ToDateTime("28/05/2002");
            aSupplierArchive = true;
            //always return true
            return true;
        */

        // ------------------- WEEK 24 --------------------------

        //public string Valid(string supplierName, string supplierDateAdded)
        //{

        //}


        
    }
}

