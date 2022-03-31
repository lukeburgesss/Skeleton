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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;

        Response.Redirect("SupplierManagementDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;

        if(lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierManagementDataEntry.aspx");

        }
        else
        {
            lblError.Text = " Please select a record to edit from the list: ";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;

        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierManagementConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportByName(txtFilter.Text);
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        Suppliers.ReportByName("");
        txtFilter.Text = "";
        lstSupplierList.DataSource = Suppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }
}












