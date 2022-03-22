using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the CustomerNo property
        private Int32 mCustomerNo;

        public Int32 CustomerNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerNo = value;
            }
        }

        //private data member for the CustomerName property
        private String mCustomerName;
        public String CustomerName
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }

        //private data member for the CustomerName property
        private String mCustomerContactNo;
        public String CustomerContactNo
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerContactNo;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerContactNo = value;
            }
        }

        //private data member for the CustomerName property
        private String mDeliveryAddr;
        public String DeliveryAddr
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryAddr;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryAddr = value;
            }
        }

        //private data member for the CustomerName property
        private DateTime mCustomerDob;
        public DateTime CustomerDob
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerDob;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerDob = value;
            }
        }

        //private data member for the CustomerName property
        private Boolean mAccountStatus;
        public Boolean AccountStatus
        {
            get
            {
                //this line of code sends data out of the property
                return mAccountStatus;
            }
            set
            {
                //this line of code allows data into the property
                mAccountStatus = value;
            }
        }




        public bool Find(int CustomerNo)
        {
            
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerContactNo = Convert.ToString(DB.DataTable.Rows[0]["CustomerContactNo"]);
                mDeliveryAddr = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddr"]);
                mCustomerDob = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDob"]);
                mAccountStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["AccountStatus"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string customerName, string customerContactNo, string deliveryAddr, string customerDob)
        {
            //create a string varaible to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the CustomerName is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be blank : ";
            }
            //if the CustomerName is greater than 50 characters
            if (customerName.Length > 50)
            {
                //record the error
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            if (customerContactNo.Length == 0)
            {
                //record the error
                Error = Error + "The customer contact no may not be blank : ";
            }
            if (customerContactNo.Length > 16)
            {
                //record the error
                Error = Error + "The customer contact no must be less than 16 characters : ";
            }
            if (deliveryAddr.Length == 0)
            {
                //record the error
                Error = Error + "The delivery address may not be blank : ";
            }
            if (deliveryAddr.Length > 100)
            {
                //record the error
                Error = Error + "The delivery address must be less than 100 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(customerDob);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date canot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error message
            return Error;
        }
    }
}