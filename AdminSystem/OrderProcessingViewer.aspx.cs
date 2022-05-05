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
        //create a new instance of clsOrder 
        clsOrder theOrder = new clsOrder();

        //get the data from the session object
        theOrder = (clsOrder)Session["theOrder"] ;

        //display the Order ID on the page 
        Response.Write(theOrder.OrderId);

        //display the Product ID on the page 
        Response.Write(theOrder.ProductID);


        //display the Order ID on the page 
        Response.Write(theOrder.TotalProduct);

        //display the Order ID on the page 
        Response.Write(theOrder.OrderIsPaid);

        //display the Order ID on the page 
        Response.Write(theOrder.OrderCreationData);


        //display the Order ID on the page 
        Response.Write(theOrder.OrderName);


    }
}