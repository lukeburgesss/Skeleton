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


        private DateTime mOrderCreationData;
        public DateTime OrderCreationData
        {
            get
            {

                //this line of code sends data out the property
                return mOrderCreationData;

            }
            set
            {
                //this line of code allows data into the property
                mOrderCreationData = value;
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

       


        //week 23
        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderId");

            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mTotalProduct = Convert.ToInt32(DB.DataTable.Rows[0]["TotalProduct"]);
                mOrderIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderIsPaid"]);
               mOrderCreationData = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderCreationData"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                return true;
            }
            else
            {
                return false;
            }




        }
        public string Valid(string orderName, string orderCreationData)
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
                DateTemp = Convert.ToDateTime(orderCreationData);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }



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
    }
}

