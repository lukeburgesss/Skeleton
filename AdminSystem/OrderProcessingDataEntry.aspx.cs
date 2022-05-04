using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope 
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
            //get the number of the ID to be processed 
            OrderId = Convert.ToInt32(Session["OrderId"]);
            if (IsPostBack == false)
            {
                //if the is not a new record
                if (OrderId != -1)
                {
                    //display the current data for the record
                    DisplayOrders();
                }
            }

    }

    private void DisplayOrders()
    {

        //create an instance of the address book 
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update 
        OrderBook.ThisOrder.Find(OrderId);
        //display the data for this record 
        txtProductID.Text = OrderBook.ThisOrder.ProductID.ToString();
        txtTotalProduct.Text = OrderBook.ThisOrder.TotalProduct.ToString();
        txtTotalProduct.Text = OrderBook.ThisOrder.TotalProduct.ToString();
        chkOrderIsPaid.Checked = OrderBook.ThisOrder.OrderIsPaid;
        txtOrderCreationDate.Text = OrderBook.ThisOrder.OrderCreationDate.ToString();
        txtOrderName.Text = OrderBook.ThisOrder.OrderName;
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder 
        clsOrder theOrder = new clsOrder();
        //capture the OrderId
     //  string OrderId = txtOrderId.Text;
        //capture the Product ID
       string ProductID = txtProductID.Text;
        //capture the Total Product
       string TotalProduct = txtTotalProduct.Text;
        //capture the OrderIsPaid
       //theOrder.OrderIsPaid = Convert.ToBoolean(chkOrderIsPaid.Checked);
        //capture the OrderIsPaid
       string OrderCreationDate = txtOrderCreationDate.Text;
        //capture the OrderName
       string OrderName = txtOrderName.Text;
        //variable to store any error messages 
        string Error = "";
        //validate the data 
        Error = theOrder.Valid(OrderName, OrderCreationDate);
        if (Error == "")
        {
            
            //capture the OrderId 
            theOrder.OrderId = OrderId;
            //capture the ProductID 
            theOrder.ProductID = Convert.ToInt32(ProductID);
            //capture the Total Product 
            theOrder.TotalProduct = Convert.ToInt32(TotalProduct);
            //capture the Order Creation Data
            theOrder.OrderCreationDate = Convert.ToDateTime(OrderCreationDate);
            //capture the Order Name 
            theOrder.OrderName = OrderName;
            //capture the OrderIsPaid
            theOrder.OrderIsPaid = chkOrderIsPaid.Checked;
            //create a new instance of the Order collection
            clsOrderCollection OrderList = new clsOrderCollection();

            //if this is a new record i.e OrderId = -1 then add the data
            if (OrderId == -1)
            {

                //set the thisorder property
                OrderList.ThisOrder = theOrder;
                //add the new record
                OrderList.Add();

            }

            //otherwise it must be an update 

            else
            {
                //find the record to update 
                OrderList.ThisOrder.Find(OrderId);
                //set the thisOrder property
                OrderList.ThisOrder = theOrder;
                //update the record
                OrderList.Update();
            }
            
            //redirect back to this listpage
            Response.Redirect("OrderProcessingList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

 
    
    
    
    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Order class
        clsOrder theOrder = new clsOrder();
        //variable to store primary key
        Int32 OrderId;
        //variable to store the results of the find operation
        Boolean Found = false;
        //get the primary key enterd bu the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = theOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form 

            txtProductID.Text = theOrder.ProductID.ToString();
            txtTotalProduct.Text = theOrder.TotalProduct.ToString();
           // txtOrderIsPaid.Text = theOrder.OrderIsPaid.ToString();
            txtOrderCreationDate.Text = theOrder.OrderCreationDate.ToString();
            txtOrderName.Text = theOrder.OrderName;
            
           

        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}
