using System;
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
        theStock.ProductId = Convert.ToInt32(txtProductId.Text);
        //capture the Product Name
        theStock.ProductName = txtProductName.Text;
        //captures the InStock boolean
        theStock.InStock = Convert.ToBoolean(chkInStock.Checked);
        //captures the Product Quantity
        theStock.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
        //captures the Last Adjustment
        theStock.LastAdjustment = Convert.ToDateTime(txtLastAdjustment.Text);
        //captures the Colour
        theStock.Colour = txtColour.Text;
        //captures the Price
        theStock.Price = Convert.ToDouble(txtPrice.Text);
        //store the ID in the session object
        Session["theStock"] = theStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
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