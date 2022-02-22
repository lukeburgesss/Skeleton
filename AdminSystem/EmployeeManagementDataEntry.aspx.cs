using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //new instance cs employee
        clsEmployee AnEmployee = new clsEmployee();
        //apture house number
        AnEmployee.EmployeeHouseAddress = txtHouseAddress.Text;
        //store the address in the session object
        Session["AnEmployee"] = AnEmployee;
        //navicates to viewer page
        Response.Redirect("EmployeeManagementViewer.aspx");
    }
}