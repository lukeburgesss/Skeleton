using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    private void DisplayCustomers()
    {
        //create instance of Customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of primary key
        lstCustomerList.DataValueField = "CustomerNo";
        //set the date field to display
        lstCustomerList.DataTextField = "CustomerName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store primary key value of the record to be edited
        Int32 CustomerNo;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the edit page
            Response.Redirect("CustomerManagementDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}