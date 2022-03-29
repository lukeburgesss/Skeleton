using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySuppliers();
        }
    }


    void DisplaySuppliers()
    {
        clsSupplierCollection Supplier = new clsSupplierCollection();

        lstSupplierList.DataSource = Supplier.SupplierList;

        lstSupplierList.DataValueField = "SupplierID";

        lstSupplierList.DataTextField = "SupplierName";

        lstSupplierList.DataBind();

    }


    protected void lstSupplierList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;

        Response.Redirect("SupplierManagementDataEntry.aspx");
    }
}