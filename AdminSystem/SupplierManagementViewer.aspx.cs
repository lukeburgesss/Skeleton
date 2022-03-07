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
        // create a new instance of the class 
        clsSupplier aSupplier = new clsSupplier();

        // get the data from the session object 
        aSupplier = (clsSupplier)Session["aSupplier"];

        // display the supplier number on the page
        Response.Write(aSupplier.SupplierID); Console.WriteLine();
        Response.Write(aSupplier.SupplierName); Console.WriteLine();
        Response.Write(aSupplier.SupplierDateAdded); Console.WriteLine();
        Response.Write(aSupplier.SupplierArchive); Console.WriteLine();
    }
}