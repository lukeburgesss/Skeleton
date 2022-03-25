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

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByOrderId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mTotalProduct = Convert.ToInt32(DB.DataTable.Rows[0]["TotalProduct"]);
                mOrderIsPaid = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderPaid"]);
                mOrderCreationDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderCreationDate"]);
                mOrderName = Convert.ToString(DB.DataTable.Rows[0]["OrderName"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }
        }


    }
}