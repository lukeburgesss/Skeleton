using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderProcessingList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the listbox
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        //create an instance of the Order Collection 
        clsOrderCollection Order = new clsOrderCollection();
        //set the data source to list of addresses in the collectiom 
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data filed to display 
        lstOrderList.DataTextField = "OrderName";
        //bind the data to the list 
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["OrderId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("OrderProcessingBookDataEntry.aspx");
    }
}