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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited 
        Int32 OrderId;
        //if a recorde has been selectede from the list 
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key velue of the record to edit 
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object 
            Session["OrderId"] = OrderId;
            //rediret to the edit page 
            Response.Redirect("OrderProcessingBookDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}