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
        //capture the Product Name
        string ProductName = txtProductName.Text;
        //captures the Product Quantity
        string ProductQuantity = txtProductQuantity.Text;
        //captures the Last Adjustment
        string LastAdjustment = txtLastAdjustment.Text;
        //captures the Colour
        string Colour = txtColour.Text;
        //captures the Price
        string Price = txtPrice.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = theStock.Valid(ProductName, LastAdjustment, Colour);
        if (Error == "")
        {
            //captures the Product Name
            theStock.ProductName = ProductName;
            //captures the Product Quantity
            theStock.ProductQuantity = Convert.ToInt32(ProductQuantity);
            //captures the Last Adjustment
            theStock.LastAdjustment = Convert.ToDateTime(LastAdjustment);
            //captures the Colour
            theStock.Colour = Colour;
            //captures the Price
            theStock.Price = Convert.ToDouble(Price);
            //creates a new instance of the stock collection
            clsStockCollection StockList = new clsStockCollection();
            //set ThisStock property
            StockList.ThisStock = theStock;
            //add the new record
            StockList.Add();
            //redirect to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsStock theStock = new clsStock();
        //variable to store the primary key
        Int32 ProductId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ProductId = Convert.ToInt32(txtProductId.Text);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductId.Text = Convert.ToString(theStock.ProductId);
            txtProductName.Text = Convert.ToString(theStock.ProductName);
            chkInStock.Text = Convert.ToString(theStock.InStock);
            txtProductQuantity.Text = Convert.ToString(theStock.ProductQuantity);
            txtColour.Text = Convert.ToString(theStock.Colour);
            txtPrice.Text = Convert.ToString(theStock.Price);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}