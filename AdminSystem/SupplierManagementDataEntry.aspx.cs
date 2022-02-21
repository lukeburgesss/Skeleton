using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {

        // create a new instance of clsSupplier 
        clsSupplier aSupplier = new clsSupplier();

        // capture the Supplier Number
        aSupplier.SupplierName = txtSupplierName.Text;

        // store the supplier in the session object
        Session["aSupplier"] = aSupplier;

        // navigate to the viewer page 
        Response.Redirect("SupplierManagementViewer.aspx");
    }

}