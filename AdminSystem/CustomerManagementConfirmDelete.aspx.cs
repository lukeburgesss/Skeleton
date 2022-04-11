﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store primary key value of the record to be deleted
    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the num of the customer to be deleted from the session object
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer book class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete
        CustomerBook.ThisCustomer.Find(CustomerNo);
        //delete the record
        CustomerBook.Delete();
        //redirect back to the main page
        Response.Redirect("CustomerManagementList.aspx");
    }
}