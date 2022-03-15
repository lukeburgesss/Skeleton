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
        //new instance cls employee
        clsEmployee AnEmployee = new clsEmployee();

        //capture employee name        
        AnEmployee.EmployeeID = Convert.ToInt32(txtEmployeeNo.Text);
        AnEmployee.EmployeeName = txtEmployeeName.Text;
        AnEmployee.EmployeeDob = Convert.ToDateTime(txtDOB.Text);
        AnEmployee.EmployeeHouseAddress = txtHouseAddress.Text;
        AnEmployee.Employeesalary = Convert.ToInt32(txtsalary.Text);
        AnEmployee.EmployeeContractStatus = Convert.ToBoolean(chkActive.Checked);


        //test test


        //store the employee in the session object
        Session["AnEmployee"] = AnEmployee;
        //navicates to viewer page
        Response.Redirect("EmployeeManagementViewer.aspx");
    }

    protected void txtHouseAddress_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtEmployeeNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsEmployee anEmployee = new clsEmployee();
        //store primary key
        Int32 EmployeeID;
        //variable to store the results of the find operation
        Boolean Found=false;
        //get the primary key enterd bu the user
        EmployeeID = Convert.ToInt32(txtEmployeeNo.Text);
        //find the record
        Found = anEmployee.Find(EmployeeID);
        //if found
        if (Found == true)
        {
            txtEmployeeNo.Text = anEmployee.EmployeeID;
            txtEmployeeName.Text = anEmployee.EmployeeName;
            txtDOB.Text = anEmployee.EmployeeDob;
            txtHouseAddress.Text = anEmployee.EmployeeHouseAddress;
            txtsalary.Text = anEmployee.Employeesalary;
            chkActive.Checked = anEmployee.EmployeeContractStatus;


        }
    }
}