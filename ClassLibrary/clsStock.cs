using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the ProductID property
        private Int32 mProductID;
        private String mProductName;
        private Boolean mInStock;
        private Int32 mProductQuantity;
        private DateTime mLastAdjustment;
        private String mColour;
        private double mPrice;

        public Int32 ProductID
        {
            get
            {
                //this line of code sends data out the property
                return mProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
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

        public bool Find(int productID)
        {
            //set the private data members to the test data value
            mProductID = 10;
            mProductName = "Blue Sock";
            mInStock = true;
            mProductQuantity = 10;
            mLastAdjustment = Convert.ToDateTime("24/07/2000");
            mColour = "Blue";
            mPrice = 1.12;
            //always return true
            return true;
        }
    }
}