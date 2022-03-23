using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 EmployeeID;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeID = Convert.ToInt32(Session["EmployeeID"]);
    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        clsEmployeeCollection EmployeeBook = new clsEmployeeCollection();

        EmployeeBook.ThisEmployee.Find(EmployeeID);

        EmployeeBook.Delete();

        Response.Redirect("EmployeeManagementList.aspx");
    }
}