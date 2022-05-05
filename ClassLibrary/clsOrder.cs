using System;

namespace ClassLibrary
{
    public class clsOrder
    {

       
        


        private Int32 mOrderId;
        public int OrderId
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




        private Int32 mProductID;

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

        private Int32 mTotalProduct;
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

        private Boolean mOrderIsPaid;
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


        private DateTime mOrderCreationDate;
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

        private string mOrderName;
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
       

        //------week 24----------

        public string Valid(string orderName, string orderCreationDate)
        {
            //create a string variable to store the error
            String Error = "";
            //variable to store DateTemp
            DateTime DateTemp;
            //if the ProductName is blank
            if (orderName.Length == 0)
            {
                //record the error
                Error = Error + "The Order Name may not be blank";
            }

            if (orderName.Length > 100)
            {
                //record the error
                Error = Error + "The order Name May Not Be Greater Than 100 Characters";
            }

            try
            {
                //copy the orderCreationDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderCreationDate);
                if (DateTemp < DateTime.Now.Date)


                    //record the error
                    Error = Error + "The date cannot be in the past : ";


                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The Date Was Not A Valid Date";
            }

            return Error;
        }


        //week 23
        public bool Find(int orderId)
        {
            mOrderId = 21;
            mOrderCreationDate = Convert.ToDateTime("16/09/2015");
            mProductID = 21;
            mTotalProduct = 21;
            mOrderIsPaid = true;
            mOrderName = "Gloria Yes";


            return true;
        }
    }
}

