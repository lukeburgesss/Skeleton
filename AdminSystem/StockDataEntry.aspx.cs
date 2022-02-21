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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //creates  anew instance of clsStock
        clsStock theStock = new clsStock();
        //captures the ProductID
        //theStock.ProductID = txtProductID;
        //capture the Product Name
        theStock.ProductName = txtProductName.Text;
        //captures the Last Adjustment
        //theStock.LastAdjustment = txtLastAdjustment.Text;
        //captures the Colour
        theStock.Colour = txtColour.Text;
        //store the ID in the session object
        Session["theStock"] = theStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}