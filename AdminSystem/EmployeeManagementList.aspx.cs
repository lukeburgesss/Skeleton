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
        //if this si the first ttime the pahge is displayed
        if (IsPostBack = false)
        {
            DisplayEmployees();
        }

        void DisplayEmployees()
        {
            clsEmployeeCollection Employees = new clsEmployeeCollection();

            lstEmployeeList.DataSource = Employees.EmployeeList;

            lstEmployeeList.DataValueField = "EmployeeID";

            lstEmployeeList.DataTextField = "EmployeeName";

            lstEmployeeList.DataBind();

        }
    }
}