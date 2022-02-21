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
        //display the Product name for this entry
        Response.Write(theStock.ProductName);
        //display the Colour for this entry
        Response.Write(theStock.Colour);
    }
}