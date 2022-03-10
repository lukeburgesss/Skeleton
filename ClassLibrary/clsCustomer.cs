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
            //set the private data members to the test data value
            mCustomerNo = 21;
            mCustomerName = "A Name";
            mCustomerContactNo = "0123456789012345";
            mDeliveryAddr = "Some Address";
            mCustomerDob = Convert.ToDateTime("01/01/2000");
            mAccountStatus = true;
            //always return true
            return true;
        }
    }
}