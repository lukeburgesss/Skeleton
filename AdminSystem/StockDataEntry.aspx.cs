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
        theStock.ProductID = Convert.ToInt32(txtProductID.Text);
        //capture the Product Name
        theStock.ProductName = txtProductName.Text;
        //captures the InStock boolean
        //theStock.InStock = Convert.ToBoolean(chkInStock.Text);
        //captures the Product Quantity
        //theStock.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
        //captures the Last Adjustment
        //theStock.LastAdjustment = Convert.ToDateTime(txtLastAdjustment.Text);
        //captures the Colour
        theStock.Colour = txtColour.Text;
        //captures the Price
        //theStock.Price = Convert.ToInt32(txtPrice);
        //store the ID in the session object
        Session["theStock"] = theStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}