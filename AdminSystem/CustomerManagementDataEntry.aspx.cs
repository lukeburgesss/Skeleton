﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the CustomerNo
        ACustomer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //capture the CustomerName
        ACustomer.CustomerName = txtCustomerName.Text;
        //capture the CustomerContactNo
        ACustomer.CustomerContactNo = txtCustomerContactNo.Text;
        //capture the DeliveryAddr
        ACustomer.DeliveryAddr = txtDeliveryAddr.Text;
        //capture the CustomerDob
        ACustomer.CustomerDob = Convert.ToDateTime(txtDeliveryAddr.Text);
        //capture the AccountStatus
        ACustomer.AccountStatus = Convert.ToBoolean(chkAccountStatus);
        //store the a customer in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerManagementViewer.aspx");
    }
}