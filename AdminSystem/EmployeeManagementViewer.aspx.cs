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
        //create a new isntance oif cls employee
        clsEmployee AnEmployee = new clsEmployee();
        //get the data form the seccosion object 
        AnEmployee = (clsEmployee)Session["AnEmployee"];
        //display the home for this entry
        Response.Write(AnEmployee.EmployeeName);
        Response.Write(AnEmployee.EmployeeID);
        Response.Write(AnEmployee.EmployeeDob);
        Response.Write(AnEmployee.EmployeeHouseAddress);
        Response.Write(AnEmployee.Employeesalary);
        Response.Write(AnEmployee.EmployeeContractStatus);

        //test test
    }
}