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
                //DisplayESuppliers();

            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsSupplier 
        clsSupplier aSupplier = new clsSupplier();

        // capture the Supplier Information
        string SupplierID = txtSupplierNumber.Text;
        string SupplierName = txtSupplierName.Text;
        string SupplierDateAdded = txtSupplierDateAdded.Text;


        string Error = "";
        Error = aSupplier.Valid(SupplierName, SupplierDateAdded);
        if (Error == "")
        {
            aSupplier.SupplierID = Convert.ToInt32(txtSupplierNumber.Text);
            aSupplier.SupplierName = txtSupplierName.Text;
            aSupplier.SupplierDateAdded = Convert.ToDateTime(txtSupplierDateAdded.Text);
            aSupplier.SupplierArchive = Convert.ToBoolean(chkArchive.Checked);

            /* clsEmployeeCollection EmployeeList = new clsEmployeeCollection();

             if (Convert.ToInt32(EmployeeID) == -1)
             {
                 EmployeeList.ThisEmployee = AnEmployee;
                 EmployeeList.Add();

             }

             else
             {
                 EmployeeList.ThisEmployee.Find(Convert.ToInt32(EmployeeID));

                 EmployeeList.ThisEmployee = AnEmployee;

                 EmployeeList.Update();
             }

             //navicates to list page
             Response.Redirect("EmployeeManagementList.aspx");
         }
         else
         {
             lblError.Text = Error;
         }

     } */


        }








        /*
        protected void btnFind_Click(object sender, EventArgs e)
        {
            clsSupplier aSupplier = new clsSupplier();
            Int32 SupplierID;
            Boolean Found = false;
            SupplierID = Convert.ToInt32(txtSupplierNumber);
            Found = aSupplier.Find(SupplierID);
            if (Found == true)
            {
                txtSupplierNumber.Text = Convert.ToString(aSupplier.SupplierID);

                txtSupplierName.Text = aSupplier.SupplierName;

                txtSupplierDateAdded.Text = Convert.ToString(aSupplier.SupplierDateAdded);

                chkArchive.Checked = aSupplier.SupplierArchive;
            } */
        }

    protected void btnFind_Click(object sender, EventArgs e)
    {

    }
}
  


