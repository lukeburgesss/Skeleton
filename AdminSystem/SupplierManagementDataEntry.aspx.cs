using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {   
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            if (SupplierID != -1)
            {
                DisplaySuppliers();

            }
        }
    }

    void DisplaySuppliers()
    {
        clsSupplierCollection supplierbook = new clsSupplierCollection();

        supplierbook.ThisSupplier.Find(SupplierID);

        txtSupplierID.Text = supplierbook.ThisSupplier.SupplierID.ToString();
        
        txtSupplierName.Text = supplierbook.ThisSupplier.SupplierName;
        
        txtSupplierDateAdded.Text = supplierbook.ThisSupplier.SupplierDateAdded.ToString();
        
        chkArchive.Checked = supplierbook.ThisSupplier.SupplierArchive;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsSupplier 
        clsSupplier aSupplier = new clsSupplier();

        // capture the Supplier Information
        string SupplierName = txtSupplierName.Text;
        string SupplierDateAdded = txtSupplierDateAdded.Text;


        string Error = "";
        Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
        if (Error == "")
        {
            aSupplier.SupplierID = SupplierID;
            aSupplier.SupplierName = txtSupplierName.Text;
            aSupplier.SupplierDateAdded = Convert.ToDateTime(txtSupplierDateAdded.Text);
            aSupplier.SupplierArchive = Convert.ToBoolean(chkArchive.Checked);

            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierID == -1)
            {
                SupplierList.ThisSupplier = aSupplier;
                SupplierList.Add();
            }

            else
            {
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = aSupplier;
                SupplierList.Update();

            }

            Response.Redirect("SupplierManagementList.aspx");
        }

        else
        {
            lblError.Text = Error;
        }

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier aSupplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = aSupplier.Find(SupplierID);
        if (Found == true)
        {
            txtSupplierName.Text = aSupplier.SupplierName;
            txtSupplierDateAdded.Text = Convert.ToString(aSupplier.SupplierDateAdded);
            chkArchive.Checked = aSupplier.SupplierArchive;

        }

    }








}
 
  


