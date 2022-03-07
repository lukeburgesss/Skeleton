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



        // capture the Supplier Information
        aSupplier.SupplierID = Convert.ToInt32(txtSupplierNumber.Text);
        aSupplier.SupplierName = txtSupplierName.Text;
        aSupplier.SupplierDateAdded = Convert.ToDateTime(txtSupplierDateAdded.Text);
        aSupplier.SupplierArchive = Convert.ToBoolean(chkArchive.Checked);

        // store the supplier in the session object
        Session["aSupplier"] = aSupplier;

        // navigate to the viewer page 
        Response.Redirect("SupplierManagementViewer.aspx");
    }

}
