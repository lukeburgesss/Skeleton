using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates a new instance of clsStock
        clsStock theStock = new clsStock();
        //get the data from the session object
        theStock = (clsStock)Session["theStock"];
        //display the ProductID for this entry
        Response.Write(theStock.ProductID);
        //display the Product Name for this entry
        Response.Write(theStock.ProductName);
        //display the InStock for this entry
        Response.Write(theStock.InStock);
        //display the Product Quantity for this entry
        Response.Write(theStock.ProductQuantity);
        //display the Last Adjustment for this entry
        Response.Write(theStock.LastAdjustment);
        //display the Colour for this entry
        Response.Write(theStock.Colour);
        //display the Price for this entry
        Response.Write(theStock.Price);
    }
}