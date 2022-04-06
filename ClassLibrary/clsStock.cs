using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the ProductID property
        private Int32 mProductId;
        private String mProductName;
        private Boolean mInStock;
        private Int32 mProductQuantity;
        private DateTime mLastAdjustment;
        private String mColour;
        private double mPrice;

        public Int32 ProductId
        {
            get
            {
                //this line of code sends data out the property
                return mProductId;
            }
            set
            {
                //this line of code allows data into the property
                mProductId = value;
            }
        }
        public string ProductName
        {
            get
            {
                //this line of code sends data out the property
                return mProductName;
            }
            set
            {
                //this line of code allows data into the property
                mProductName = value;
            }
        }
        public bool InStock
        {
            get
            {
                //this line of code sends data out the property
                return mInStock;
            }
            set
            {
                //this line of code allows data into the property
                mInStock = value;
            }
        }
        public int ProductQuantity
        {
            get
            {
                //this line of code sends data out the property
                return mProductQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mProductQuantity = value;
            }
        }
        public DateTime LastAdjustment
        {
            get
            {
                //this line of code sends data out the property
                return mLastAdjustment;
            }
            set
            {
                //this line of code allows data into the property
                mLastAdjustment = value;
            }
        }
        public string Colour
        {
            get
            {
                //this line of code sends data out the property
                return mColour;
            }
            set
            {
                //this line of code allows data into the property
                mColour = value;
            }
        }
        public double Price
        {
            get
            {
                //this line of code sends data out the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }

        public bool Find(int ProductId)
        {
            //creates an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the ProductID to search for
            DB.AddParameter("@ProductId", ProductId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByProductId");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mLastAdjustment = Convert.ToDateTime(DB.DataTable.Rows[0]["LastAdjustment"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string productName, string lastAdjustment, string colour)
        {
            //create a string variable to store the error
            String Error = "";
            //variable to store DateTemp
            DateTime DateTemp;
            //if the ProductName is blank
            if (productName.Length == 0)
            {
                //record the error
                Error = Error + "The Product Name May Not Be Blank";
            }

            if (productName.Length > 50)
            {
                //record the error
                Error = Error + "The Product Name May Not Be Greater Than 50 Characters";
            }

            try
            {
                DateTemp = Convert.ToDateTime(lastAdjustment);
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date Cannot Be In The Future";
                }
            }
            catch 
            {
                //record the error
                Error = Error + "The Date Was Not A Valid Date";
            }

            if (colour.Length == 0)
            {
                //record the error
                Error = Error + "The Colour May Not Be Blank";
            }

            if (colour.Length > 50)
            {
                //record the error
                Error = Error + "The Colour May Not Be Greater Than 50 Characters";
            }

            return Error;
        }
    }
}