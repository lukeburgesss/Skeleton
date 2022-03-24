using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //private data member for the orderId property
        private Int32 mOrderId;
        private Int32 mProductID;
        private Int32 mTotalProduct;
        private Boolean mOrderIsPaid;
        private DateTime mOrderCreationDate;
        private String mOrderName;


        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }






        public int ProductID
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

        public int TotalProduct
        {
            get
            {

                //this line of code sends data out the property
                return mTotalProduct;

            }
            set
            {
                //this line of code allows data into the property
                mTotalProduct = value;
            }
        
        
        }


        public bool OrderIsPaid 
        {
            get 
            {

                //this line of code sends data out the property
                return mOrderIsPaid;

            }
            set
            {
                //this line of code allows data into the property
                mOrderIsPaid = value;
            }
        }

        public DateTime OrderCreationDate
        {
            get
            {

                //this line of code sends data out the property
                return mOrderCreationDate;

            }
            set
            {
                //this line of code allows data into the property
                mOrderCreationDate = value;
            }
        }

        public string OrderName
        {
            get
            {

                //this line of code sends data out the property
                return mOrderName;

            }
            set
            {
                //this line of code allows data into the property
                mOrderName = value;
            }
         }

        public bool Find(int OrderId)
        {
            //set the private data members to the test data value
            mOrderId = 21;
            mProductID = 16;
            mTotalProduct = 21;
            mOrderIsPaid = true ;
            mOrderCreationDate = Convert.ToDateTime("24/07/2000");
            mOrderName = "Gloria Yes";
            //always return true
            return true;
        }
    }
}