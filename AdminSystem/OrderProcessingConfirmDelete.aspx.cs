using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 OrderId;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the sesson object
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //creates a new instance of the class we want to create
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to delete 
        OrderBook.ThisOrder.Find(OrderId);
        //delete the record 
        OrderBook.Delete();
        //redirect back to the main page 
        Response.Redirect("OrderProcessingList.aspx"); 


    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}